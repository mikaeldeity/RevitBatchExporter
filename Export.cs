using Autodesk.Revit.DB;
using Autodesk.Revit.DB.Events;
using Autodesk.Revit.UI;
using Autodesk.Revit.UI.Events;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Autodesk.Revit.DB.ExternalService;
using System.Reflection;
using Autodesk.Revit.DB.IFC;
using BIM.IFC.Export.UI;



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
        internal static IList<string> optionname(Document doc)
        {
            IList<string> setupNames = BaseExportOptions.GetPredefinedSetupNames(doc);
            return setupNames;
        }

        internal static List<string> IFCExportpredefined()
        {
            
            List<string> ifcs = new List<string>();
            IFCExportConfigurationsMap configurationsMap = new IFCExportConfigurationsMap();
            configurationsMap.AddBuiltInConfigurations();
            configurationsMap.Add(IFCExportConfiguration.GetInSession());
            configurationsMap.AddSavedConfigurations();

            int n = configurationsMap.Values.Count();

            for (int j = 0; j < configurationsMap.Values.Count(); j++)
            {
                List<IFCExportConfiguration> val = configurationsMap.Values.ToList();
                ifcs.Add(val[j].Name);
                    
            }
            return ifcs;
        }
        private bool ExportIFC(Document doc,string folder,string name, ElementId viewid, string settings)
        {
            
            //Create an instance of IFCExportOptions
            IFCExportOptions IFCOptions = new IFCExportOptions();
            
            IFCExportConfigurationsMap configurationsMap = new IFCExportConfigurationsMap();        
            configurationsMap.AddBuiltInConfigurations();
            configurationsMap.Add(IFCExportConfiguration.GetInSession());
            configurationsMap.AddSavedConfigurations();
            int n = configurationsMap.Values.Count();

            for (int i = 0; i < n; i++)
            {
                //var values = configurationsMap.Values;
                for (int j = 0; j < configurationsMap.Values.Count(); j++)
                {
                    List<IFCExportConfiguration> val = configurationsMap.Values.ToList();
                    if (val[j].Name == settings)
                    {
                        val[j].UpdateOptions(IFCOptions, viewid);

                    }

                }

            }
            try
            {
                Transaction k = new Transaction(doc, "export ifc");
                k.Start();
                doc.Export(folder, name, IFCOptions);
                k.Commit();
                return true;
            }
            catch (Exception e)
            {
                string error = e.Message;
                return false;
            }     
                      
        }
        private bool ExportNWC(Document doc, string folder, string name, ElementId viewid, bool shared)
        {
            NavisworksExportOptions navisoptions = new NavisworksExportOptions();
            if (shared)
            {
                navisoptions.Coordinates = NavisworksCoordinates.Shared;
            }
            else
            {
                navisoptions.Coordinates = NavisworksCoordinates.Internal;
            }

            navisoptions.ConvertElementProperties = true;
            navisoptions.Parameters = NavisworksParameters.All;
            navisoptions.ConvertLinkedCADFormats = true;
            navisoptions.ExportLinks = false;
            navisoptions.ExportRoomAsAttribute = true;
            navisoptions.ExportUrls = true;
            navisoptions.DivideFileIntoLevels = true;
            navisoptions.ExportRoomGeometry = true;
            navisoptions.ViewId = viewid;
            navisoptions.FacetingFactor = 1;
            navisoptions.FindMissingMaterials = true;

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
        private bool ExportDWG(Document doc, string folder, string name, ElementId viewid, string optionname)
        {
            DWGExportOptions dwgOptions = null;
            IList<string> setupNames = BaseExportOptions.GetPredefinedSetupNames(doc);
            List<ElementId> ids = new List<ElementId>();
            foreach (string n in setupNames)
            {
                if (n == optionname)
                {
                    dwgOptions = DWGExportOptions.GetPredefinedOptions(doc, name);
                }
            }

            ids.Add(viewid);
            
            try
            {
                doc.Export(folder, name, ids, dwgOptions);
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

            exportdialog.DWGCombobox.DataSource = optionname(doc);

            exportdialog.IFCCombobox.DataSource = IFCExportpredefined();

            exportdialog.DWGCombobox.Enabled = false;
            exportdialog.IFCCombobox.Enabled = false;

            var dialog = exportdialog.ShowDialog();

            if (dialog != DialogResult.OK)
            {
                return Result.Cancelled;
            }    
            
            ElementId selectedview = views[exportdialog.comboBox1.SelectedItem.ToString()];
            string dwgoption = exportdialog.DWGCombobox.SelectedItem.ToString();
            string settings = exportdialog.IFCCombobox.SelectedItem.ToString();
            int count = 0;

            if (destinationpath.Trim() != "" && Directory.Exists(destinationpath))
            {
                if (exportdialog.IFCCheckBox.Checked)
                {
                    ExportIFC(doc, destinationpath, doc.Title, selectedview, settings);
                    count++;
                }
                if (exportdialog.NWCCheckBox.Checked)
                {
                    ExportNWC(doc, destinationpath, doc.Title, selectedview, exportdialog.SharedRadio.Checked);
                    count++;
                }
                if (exportdialog.DWGCheckbox.Checked)
                {
                    ExportDWG(doc, destinationpath, doc.Title, selectedview, dwgoption);
                    count++;
                }
                TaskDialog.Show("Success", "exported " + count + " documents");        
                return Result.Succeeded;
            }   
            else
            {
                return Result.Cancelled;
            }
                           
        }
    }
}
