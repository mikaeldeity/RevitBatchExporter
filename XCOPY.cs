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
                selected = uidoc.Selection.PickObjects(ObjectType.LinkedElement, "Select Elements from Links");
            }
            catch
            {
                return Result.Cancelled;
            }

            Dictionary<Document, List<ElementId>> linkelements = new Dictionary<Document, List<ElementId>>();

            Dictionary<Document, Transform> transforms = new Dictionary<Document, Transform>();

            foreach (Reference element in selected)
            {
                ElementId id = element.ElementId;

                ElementId linkid = element.LinkedElementId;

                Document linkedDoc = (doc.GetElement(id) as RevitLinkInstance).GetLinkDocument();

                Transform transform = (doc.GetElement(id) as RevitLinkInstance).GetTotalTransform();

                if (!transforms.ContainsKey(linkedDoc))
                {
                    transforms.Add(linkedDoc, transform);
                }

                if (!linkelements.ContainsKey(linkedDoc))
                {
                    List<ElementId> lst = new List<ElementId>();
                    linkelements.Add(linkedDoc,lst);
                }

                linkelements[linkedDoc].Add(linkedDoc.GetElement(linkid).Id);
                count++;
            }

            CopyPasteOptions cp = new CopyPasteOptions();
            cp.SetDuplicateTypeNamesHandler(new CustomCopyHandler());

            Transaction t1 = new Transaction(doc, "Copy Elements From Links");

            t1.Start();            

            try
            {
                DateTime start = DateTime.Now;

                foreach (Document d in linkelements.Keys)
                {
                    ElementTransformUtils.CopyElements(d, linkelements[d], doc, transforms[d], cp);
                }

                t1.Commit();

                DateTime end = DateTime.Now;

                int hours = (end - start).Hours;

                int minutes = (end - start).Minutes;

                int seconds = (end - start).Seconds;

                TaskDialog.Show("Results", "Copied " + count.ToString() + " Elements in " + hours.ToString() + " h " + minutes.ToString() + " m " + seconds.ToString() + " s");

                return Result.Succeeded;
            }
            catch
            {
                t1.RollBack();
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
