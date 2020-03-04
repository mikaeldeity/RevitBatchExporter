using Autodesk.Revit.DB;
using Autodesk.Revit.DB.Events;
using Autodesk.Revit.UI;
using Autodesk.Revit.UI.Events;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace RevitBatchExporter
{
    [Autodesk.Revit.Attributes.Transaction(Autodesk.Revit.Attributes.TransactionMode.Manual)]
    [Autodesk.Revit.Attributes.Regeneration(Autodesk.Revit.Attributes.RegenerationOption.Manual)]

    class Export : IExternalCommand
    {
        internal static List<string> documents = new List<string>();

        internal static string destinationpath = "";

        internal static Dictionary<string, ElementId> GetViews(Document doc)
        {
            FilteredElementCollector collector = new FilteredElementCollector(doc).OfClass(typeof(View3D));

            Dictionary<string, ElementId> views = new Dictionary<string, ElementId>();

            foreach (View3D v in collector)
            {
                if (!v.IsTemplate)
                {
                    if (!views.ContainsKey(v.Name))
                    {
                        views.Add(v.Name, v.Id);
                    }
                }
            }
            return views;
        }
        private bool ExportIFC(Document doc,string folder,string name, ElementId viewid)
        {
            IFCExportOptions ifcoptions = new IFCExportOptions();
            try
            {
                doc.Export(folder, name, ifcoptions);
                return true;
            }
            catch { return false; }
        }
        private bool ExportNWC(Document doc, string folder, string name, ElementId viewid)
        {
            
            NavisworksExportOptions navisoptions = new NavisworksExportOptions();
            navisoptions.ExportLinks = false;
            navisoptions.ConvertElementProperties = true;
            navisoptions.FindMissingMaterials = true;
            navisoptions.Coordinates = NavisworksCoordinates.Shared;
            navisoptions.ViewId = viewid;                     
            
            try
            {                
                doc.Export(folder, name, navisoptions);
                return true;
            }
            catch (Exception e)
            {               
                string message = e.Message;

                return false;
            }
        }
        private bool ExportDWG(Document doc, string folder, string name, ElementId viewid)
        {

            NavisworksExportOptions navisoptions = new NavisworksExportOptions();
            navisoptions.ExportLinks = false;
            navisoptions.ConvertElementProperties = true;
            navisoptions.FindMissingMaterials = true;
            navisoptions.Coordinates = NavisworksCoordinates.Shared;
            navisoptions.ViewId = viewid;

            try
            {
                doc.Export(folder, name, navisoptions);
                return true;
            }
            catch (Exception e)
            {
                string message = e.Message;

                return false;
            }
        }
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {

            UIApplication uiapp = commandData.Application;
            UIDocument uidoc = uiapp.ActiveUIDocument;
            Document doc = uidoc.Document;

            destinationpath = "";
            documents.Clear();

            Dictionary<string, ElementId> views = GetViews(doc);

            string date = DateTime.Now.ToString("dd/MM/yyyy");

            var exportdialog = new RevitBatchExporter.Dialogs.ExportDialog();

            exportdialog.comboBox1.DataSource = views.Keys.ToList();        

            var dialog = exportdialog.ShowDialog();

            if (dialog != DialogResult.OK)
            {
                return Result.Cancelled;
            }

            ElementId selectedview = views[exportdialog.comboBox1.SelectedItem.ToString()];

            if (destinationpath.Trim() != "" && Directory.Exists(destinationpath))
            {
                
                ExportNWC(doc, destinationpath, doc.Title, selectedview);
                return Result.Succeeded;
            }   
            else
            {
                return Result.Cancelled;
            }
                           
        }
    }
}
