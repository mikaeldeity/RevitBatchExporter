using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Autodesk.Revit.UI.Selection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XPORT
{
    [Autodesk.Revit.Attributes.Transaction(Autodesk.Revit.Attributes.TransactionMode.Manual)]
    [Autodesk.Revit.Attributes.Regeneration(Autodesk.Revit.Attributes.RegenerationOption.Manual)]

    class Copy : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            UIApplication uiapp = commandData.Application;
            UIDocument uidoc = uiapp.ActiveUIDocument;
            Document doc = uidoc.Document;

            IList<Reference> selected;

            int count = 0;

            try
            {
                selected = uidoc.Selection.PickObjects(ObjectType.LinkedElement, "Select Elements");
            }
            catch
            {
                return Result.Cancelled;
            }

            Dictionary<Document, List<ElementId>> linkelements = new Dictionary<Document, List<ElementId>>();

            foreach (Reference element in selected)
            {
                ElementId id = element.ElementId;

                ElementId linkid = element.LinkedElementId;

                Document linkedDoc = (doc.GetElement(id) as RevitLinkInstance).GetLinkDocument();

                if (!linkelements.ContainsKey(linkedDoc))
                {
                    List<ElementId> lst = new List<ElementId>();
                    linkelements.Add(linkedDoc,lst);
                    count++;
                }

                linkelements[linkedDoc].Add(linkedDoc.GetElement(linkid).Id);
            }

            CopyPasteOptions cp = new CopyPasteOptions();
            cp.SetDuplicateTypeNamesHandler(new CustomCopyHandler());

            try
            {
                Transaction t1 = new Transaction(doc, "Copy From Link");

                t1.Start();

                foreach (Document d in linkelements.Keys)
                {
                    ElementTransformUtils.CopyElements(d, linkelements[d], doc, null, cp);
                }

                t1.Commit();                

                return Result.Succeeded;
            }
            catch
            {
                TaskDialog.Show("Results", "Failed to copy Elements from Links");
                return Result.Failed;
            }
        }
    }
    public class CustomCopyHandler : IDuplicateTypeNamesHandler
    {
        public DuplicateTypeAction OnDuplicateTypeNamesFound(DuplicateTypeNamesHandlerArgs args)
        {
            return DuplicateTypeAction.UseDestinationTypes;
        }
    }
}
