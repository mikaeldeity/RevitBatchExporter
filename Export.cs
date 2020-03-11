using Autodesk.Revit.DB;
//using Autodesk.Revit.DB.Events;
using Autodesk.Revit.UI;
//using Autodesk.Revit.UI.Events;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
//using Autodesk.Revit.DB.ExternalService;
//using System.Reflection;
using Autodesk.Revit.DB.IFC;
using BIM.IFC.Export.UI;
//using Revit.IFC.Common.Extensions;
//using Revit.IFC.Common.Utility;
//using Autodesk.UI.Windows;
//using Revit.IFC.Export.Utility;
using Autodesk.Revit.DB.ExtensibleStorage;
//using System.Text;
//using Autodesk.Revit;


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
            
            if (setupNames.Count == 0)
            {
                setupNames.Add("<in-session export setup>");
            }
            return setupNames;
        }

        // The MapField is to defined the map<string,string> in schema. 
        // Please don't change the name values, it affects the schema.
        private const string s_configMapField = "MapField";
        // The following are the keys in the MapField in new schema. For old schema, they are simple fields.
        private const string s_setupName = "Name";
        private const string s_setupVersion = "Version";
        private const string s_setupFileFormat = "FileFormat";
        private const string s_setupSpaceBoundaries = "SpaceBoundaryLevel";
        private const string s_setupQTO = "ExportBaseQuantities";
        private const string s_splitWallsAndColumns = "SplitWallsAndColumns";
        private const string s_setupCurrentView = "VisibleElementsInCurrentView";
        private const string s_setupExport2D = "Export2DElements";
        private const string s_setupExportRevitProps = "ExportInternalRevitPropertySets";
        private const string s_setupExportIFCCommonProperty = "ExportIFCCommonPropertySets";
        private const string s_setupUse2DForRoomVolume = "Use2DBoundariesForRoomVolume";
        private const string s_setupUseFamilyAndTypeName = "UseFamilyAndTypeNameForReference";
        private const string s_setupExportPartsAsBuildingElements = "ExportPartsAsBuildingElements";
        private const string s_useActiveViewGeometry = "UseActiveViewGeometry";
        private const string s_setupExportSpecificSchedules = "ExportSpecificSchedules";
        private const string s_setupExportBoundingBox = "ExportBoundingBox";
        private const string s_setupExportSolidModelRep = "ExportSolidModelRep";
        private const string s_setupExportSchedulesAsPsets = "ExportSchedulesAsPsets";
        private const string s_setupExportUserDefinedPsets = "ExportUserDefinedPsets";
        private const string s_setupExportUserDefinedPsetsFileName = "ExportUserDefinedPsetsFileName";
        private const string s_setupExportUserDefinedParameterMapping = "ExportUserDefinedParameterMapping";
        private const string s_setupExportUserDefinedParameterMappingFileName = "ExportUserDefinedParameterMappingFileName";
        private const string s_setupExportLinkedFiles = "ExportLinkedFiles";
        private const string s_setupIncludeSiteElevation = "IncludeSiteElevation";
        private const string s_setupUseCoarseTessellation = "UseCoarseTessellation";
        private const string s_useOnlyTriangulation = "UseOnlyTriangulation";
        private const string s_setupStoreIFCGUID = "StoreIFCGUID";
        private const string s_setupActivePhase = "ActivePhase";
        private const string s_setupExportRoomsInView = "ExportRoomsInView";
        private const string s_excludeFilter = "ExcludeFilter";
        private const string s_setupSitePlacement = "SitePlacement";
        private const string s_useTypeNameOnlyForIfcType = "UseTypeNameOnlyForIfcType";
        private const string s_useVisibleRevitNameAsEntityName = "UseVisibleRevitNameAsEntityName";
        // Used for COBie 2.4
        private const string s_cobieCompanyInfo = "COBieCompanyInfo";
        private const string s_cobieProjectInfo = "COBieProjectInfo";
        private const string s_includeSteelElements = "IncludeSteelElements"; 
        //public void PrintPDF(Document doc)
        //{
        //    PrintManager pm = doc.PrintManager;           
        //    ViewSet viewSet = new ViewSet();         
                     
        //}
        public IFCExportConfigurationsMap AddSavedConfigurations(IFCExportConfigurationsMap conf, Document doc)
        {
            Guid m_schemaId = new Guid("A1E672E5-AC88-4933-A019-F9068402CFA7");
            Schema m_schema = Schema.Lookup(m_schemaId);
            Guid m_mapSchemaId = new Guid("DCB88B13-594F-44F6-8F5D-AE9477305AC3");
            Schema m_mapSchema = Schema.Lookup(m_mapSchemaId);
            try
            {
                if (m_mapSchema != null)
                {
                    foreach (DataStorage storedSetup in GetSavedConfigurations(doc, m_mapSchema))
                    {
                        Entity configEntity = storedSetup.GetEntity(m_mapSchema);
                        IDictionary<string, string> configMap = configEntity.Get<IDictionary<string, string>>(s_configMapField);
                        IFCExportConfiguration configuration = IFCExportConfiguration.CreateDefaultConfiguration();
                        if (configMap.ContainsKey(s_setupName))
                            configuration.Name = configMap[s_setupName];
                        if (configMap.ContainsKey(s_setupVersion))
                            configuration.IFCVersion = (IFCVersion)Enum.Parse(typeof(IFCVersion), configMap[s_setupVersion]);
                        if (configMap.ContainsKey(s_setupFileFormat))
                            configuration.IFCFileType = (IFCFileFormat)Enum.Parse(typeof(IFCFileFormat), configMap[s_setupFileFormat]);
                        if (configMap.ContainsKey(s_setupSpaceBoundaries))
                            configuration.SpaceBoundaries = int.Parse(configMap[s_setupSpaceBoundaries]);
                        if (configMap.ContainsKey(s_setupActivePhase))
                            configuration.ActivePhaseId = new ElementId(int.Parse(configMap[s_setupActivePhase]));
                        if (configMap.ContainsKey(s_setupQTO))
                            configuration.ExportBaseQuantities = bool.Parse(configMap[s_setupQTO]);
                        if (configMap.ContainsKey(s_setupCurrentView))
                            configuration.VisibleElementsOfCurrentView = bool.Parse(configMap[s_setupCurrentView]);
                        if (configMap.ContainsKey(s_splitWallsAndColumns))
                            configuration.SplitWallsAndColumns = bool.Parse(configMap[s_splitWallsAndColumns]);
                        if (configMap.ContainsKey(s_setupExport2D))
                            configuration.Export2DElements = bool.Parse(configMap[s_setupExport2D]);
                        if (configMap.ContainsKey(s_setupExportRevitProps))
                            configuration.ExportInternalRevitPropertySets = bool.Parse(configMap[s_setupExportRevitProps]);
                        if (configMap.ContainsKey(s_setupExportIFCCommonProperty))
                            configuration.ExportIFCCommonPropertySets = bool.Parse(configMap[s_setupExportIFCCommonProperty]);
                        if (configMap.ContainsKey(s_setupUse2DForRoomVolume))
                            configuration.Use2DRoomBoundaryForVolume = bool.Parse(configMap[s_setupUse2DForRoomVolume]);
                        if (configMap.ContainsKey(s_setupUseFamilyAndTypeName))
                            configuration.UseFamilyAndTypeNameForReference = bool.Parse(configMap[s_setupUseFamilyAndTypeName]);
                        if (configMap.ContainsKey(s_setupExportPartsAsBuildingElements))
                            configuration.ExportPartsAsBuildingElements = bool.Parse(configMap[s_setupExportPartsAsBuildingElements]);
                        if (configMap.ContainsKey(s_useActiveViewGeometry))
                            configuration.UseActiveViewGeometry = bool.Parse(configMap[s_useActiveViewGeometry]);
                        if (configMap.ContainsKey(s_setupExportSpecificSchedules))
                            configuration.ExportSpecificSchedules = bool.Parse(configMap[s_setupExportSpecificSchedules]);
                        if (configMap.ContainsKey(s_setupExportBoundingBox))
                            configuration.ExportBoundingBox = bool.Parse(configMap[s_setupExportBoundingBox]);
                        if (configMap.ContainsKey(s_setupExportSolidModelRep))
                            configuration.ExportSolidModelRep = bool.Parse(configMap[s_setupExportSolidModelRep]);
                        if (configMap.ContainsKey(s_setupExportSchedulesAsPsets))
                            configuration.ExportSchedulesAsPsets = bool.Parse(configMap[s_setupExportSchedulesAsPsets]);
                        if (configMap.ContainsKey(s_setupExportUserDefinedPsets))
                            configuration.ExportUserDefinedPsets = bool.Parse(configMap[s_setupExportUserDefinedPsets]);
                        if (configMap.ContainsKey(s_setupExportUserDefinedPsetsFileName))
                            configuration.ExportUserDefinedPsetsFileName = configMap[s_setupExportUserDefinedPsetsFileName];
                        if (configMap.ContainsKey(s_setupExportUserDefinedParameterMapping))
                            configuration.ExportUserDefinedParameterMapping = bool.Parse(configMap[s_setupExportUserDefinedParameterMapping]);
                        if (configMap.ContainsKey(s_setupExportUserDefinedParameterMappingFileName))
                            configuration.ExportUserDefinedParameterMappingFileName = configMap[s_setupExportUserDefinedParameterMappingFileName];
                        if (configMap.ContainsKey(s_setupExportLinkedFiles))
                            configuration.ExportLinkedFiles = bool.Parse(configMap[s_setupExportLinkedFiles]);
                        if (configMap.ContainsKey(s_setupIncludeSiteElevation))
                            configuration.IncludeSiteElevation = bool.Parse(configMap[s_setupIncludeSiteElevation]);
                        if (configMap.ContainsKey(s_setupStoreIFCGUID))
                            configuration.StoreIFCGUID = bool.Parse(configMap[s_setupStoreIFCGUID]);
                        if (configMap.ContainsKey(s_setupExportRoomsInView))
                            configuration.ExportRoomsInView = bool.Parse(configMap[s_setupExportRoomsInView]);
                        if (configMap.ContainsKey(s_includeSteelElements))
                            configuration.IncludeSteelElements = bool.Parse(configMap[s_includeSteelElements]);
                        //if (configMap.ContainsKey(s_useTypeNameOnlyForIfcType))
                        //    configuration.UseTypeNameOnlyForIfcType = bool.Parse(configMap[s_useTypeNameOnlyForIfcType]);
                        //if (configMap.ContainsKey(s_useVisibleRevitNameAsEntityName))
                        //    configuration.UseVisibleRevitNameAsEntityName = bool.Parse(configMap[s_useVisibleRevitNameAsEntityName]);


                        conf.Add(configuration);
                    }
                    return conf; // if finds the config in map schema, return and skip finding the old schema.
                }            
                // find the config in old schema.
                if (m_schema != null)
                {
                    foreach (DataStorage storedSetup in GetSavedConfigurations(doc,m_schema))
                    {
                        Entity configEntity = storedSetup.GetEntity(m_schema);
                        IFCExportConfiguration configuration = IFCExportConfiguration.CreateDefaultConfiguration();
                        configuration.Name = configEntity.Get<String>(s_setupName);
                        configuration.IFCVersion = (IFCVersion)configEntity.Get<int>(s_setupVersion);
                        configuration.IFCFileType = (IFCFileFormat)configEntity.Get<int>(s_setupFileFormat);
                        configuration.SpaceBoundaries = configEntity.Get<int>(s_setupSpaceBoundaries);
                        configuration.ExportBaseQuantities = configEntity.Get<bool>(s_setupQTO);
                        configuration.SplitWallsAndColumns = configEntity.Get<bool>(s_splitWallsAndColumns);
                        configuration.Export2DElements = configEntity.Get<bool>(s_setupExport2D);
                        configuration.ExportInternalRevitPropertySets = configEntity.Get<bool>(s_setupExportRevitProps);
                        Field fieldIFCCommonPropertySets = m_schema.GetField(s_setupExportIFCCommonProperty);
                        if (fieldIFCCommonPropertySets != null)
                            configuration.ExportIFCCommonPropertySets = configEntity.Get<bool>(s_setupExportIFCCommonProperty);
                        configuration.Use2DRoomBoundaryForVolume = configEntity.Get<bool>(s_setupUse2DForRoomVolume);
                        configuration.UseFamilyAndTypeNameForReference = configEntity.Get<bool>(s_setupUseFamilyAndTypeName);
                        Field fieldPartsAsBuildingElements = m_schema.GetField(s_setupExportPartsAsBuildingElements);
                        if (fieldPartsAsBuildingElements != null)
                            configuration.ExportPartsAsBuildingElements = configEntity.Get<bool>(s_setupExportPartsAsBuildingElements);
                        Field fieldExportBoundingBox = m_schema.GetField(s_setupExportBoundingBox);
                        if (fieldExportBoundingBox != null)
                            configuration.ExportBoundingBox = configEntity.Get<bool>(s_setupExportBoundingBox);
                        Field fieldExportSolidModelRep = m_schema.GetField(s_setupExportSolidModelRep);
                        if (fieldExportSolidModelRep != null)
                            configuration.ExportSolidModelRep = configEntity.Get<bool>(s_setupExportSolidModelRep);
                        Field fieldExportSchedulesAsPsets = m_schema.GetField(s_setupExportSchedulesAsPsets);
                        if (fieldExportSchedulesAsPsets != null)
                            configuration.ExportSchedulesAsPsets = configEntity.Get<bool>(s_setupExportSchedulesAsPsets);
                        Field fieldExportUserDefinedPsets = m_schema.GetField(s_setupExportUserDefinedPsets);
                        if (fieldExportUserDefinedPsets != null)
                            configuration.ExportUserDefinedPsets = configEntity.Get<bool>(s_setupExportUserDefinedPsets);
                        Field fieldExportUserDefinedPsetsFileName = m_schema.GetField(s_setupExportUserDefinedPsetsFileName);
                        if (fieldExportUserDefinedPsetsFileName != null)
                            configuration.ExportUserDefinedPsetsFileName = configEntity.Get<string>(s_setupExportUserDefinedPsetsFileName);

                        Field fieldExportUserDefinedParameterMapingTable = m_schema.GetField(s_setupExportUserDefinedParameterMapping);
                        if (fieldExportUserDefinedParameterMapingTable != null)
                            configuration.ExportUserDefinedParameterMapping = configEntity.Get<bool>(s_setupExportUserDefinedParameterMapping);

                        Field fieldExportUserDefinedParameterMappingFileName = m_schema.GetField(s_setupExportUserDefinedParameterMappingFileName);
                        if (fieldExportUserDefinedParameterMappingFileName != null)
                            configuration.ExportUserDefinedParameterMappingFileName = configEntity.Get<string>(s_setupExportUserDefinedParameterMappingFileName);

                        Field fieldExportLinkedFiles = m_schema.GetField(s_setupExportLinkedFiles);
                        if (fieldExportLinkedFiles != null)
                            configuration.ExportLinkedFiles = configEntity.Get<bool>(s_setupExportLinkedFiles);
                        Field fieldIncludeSiteElevation = m_schema.GetField(s_setupIncludeSiteElevation);
                        if (fieldIncludeSiteElevation != null)
                            configuration.IncludeSiteElevation = configEntity.Get<bool>(s_setupIncludeSiteElevation);
                        Field fieldStoreIFCGUID = m_schema.GetField(s_setupStoreIFCGUID);
                        if (fieldStoreIFCGUID != null)
                            configuration.StoreIFCGUID = configEntity.Get<bool>(s_setupStoreIFCGUID);
                        Field fieldActivePhase = m_schema.GetField(s_setupActivePhase);
                        if (fieldActivePhase != null)
                            configuration.ActivePhaseId = new ElementId(int.Parse(configEntity.Get<string>(s_setupActivePhase)));
                        Field fieldExportRoomsInView = m_schema.GetField(s_setupExportRoomsInView);
                        if (fieldExportRoomsInView != null)
                            configuration.ExportRoomsInView = configEntity.Get<bool>(s_setupExportRoomsInView);
                        Field fieldIncludeSteelElements = m_schema.GetField(s_includeSteelElements);
                        if (fieldIncludeSteelElements != null)
                            configuration.IncludeSteelElements = configEntity.Get<bool>(s_includeSteelElements);
                        //Field fieldUseTypeNameOnlyForIfcType = m_schema.GetField(s_useTypeNameOnlyForIfcType);
                        //if (fieldUseTypeNameOnlyForIfcType != null)
                        //    configuration.UseTypeNameOnlyForIfcType = configEntity.Get<bool>(s_useTypeNameOnlyForIfcType);
                        //Field fieldUseVisibleRevitNameAsEntityName = m_schema.GetField(s_useVisibleRevitNameAsEntityName);
                        //if (fieldUseVisibleRevitNameAsEntityName != null)
                        //    configuration.UseVisibleRevitNameAsEntityName = configEntity.Get<bool>(s_useVisibleRevitNameAsEntityName);

                        conf.Add(configuration);
                        
                    }
                }
                return conf;
            }
            catch (Exception e)
            {
                string error = e.Message;
                return conf;// to avoid fail to show the dialog if any exception throws in reading schema.
            }
        }
        private void DeleteLog(string directory)
        {
            DirectoryInfo destfolder = new DirectoryInfo(directory);
            foreach (FileInfo f in destfolder.GetFiles())
            {
                if (f.Extension != ".ifc" && f.Extension != ".nwc" && f.Extension != ".dwg")
                {
                    f.Delete();
                    
                }
                
            }

        }
        private IList<DataStorage> GetSavedConfigurations(Document doc, Schema schema)
        {

            FilteredElementCollector collector = new FilteredElementCollector(doc);
            collector.OfClass(typeof(DataStorage));
            Func<DataStorage, bool> hasTargetData = ds => (ds.GetEntity(schema) != null && ds.GetEntity(schema).IsValid());

            return collector.Cast<DataStorage>().Where<DataStorage>(hasTargetData).ToList<DataStorage>();
        }
        internal List<string> IFCExportpredefined(Document doc)
        {
            //import
            
            List<string> ifcs = new List<string>();
            IFCExportConfigurationsMap configurationsMap = new IFCExportConfigurationsMap();
            configurationsMap.AddBuiltInConfigurations();
            configurationsMap.Add(IFCExportConfiguration.GetInSession());
            configurationsMap.AddSavedConfigurations();
            configurationsMap = AddSavedConfigurations(configurationsMap, doc);
            //configurationsMap.Add(mauro);
            //IFCExport mainWindow = new IFCExport(doc, configurationsMap, configurationsMap.Values.ToList()[5].Name);
            //IFCExporterUIWindow iFCExporterUIWindow = new IFCExporterUIWindow(configurationsMap, configurationsMap.Values.ToList()[0].Name);
            //mainWindow.ShowDialog();



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
            AddSavedConfigurations(configurationsMap, doc);

            
            for (int i = 0; i < n; i++)
            {
                //var values = configurationsMap.Values;
                for (int j = 0; j < configurationsMap.Values.Count(); j++)
                {
                    List<IFCExportConfiguration> val = configurationsMap.Values.ToList();
                    if (val[j].Name == settings)
                    {
                        val[j].VisibleElementsOfCurrentView = true;
                        try
                        {
                            val[j].UpdateOptions(IFCOptions, viewid);
                        }
                        catch
                        {

                        }
                        
                        val[j].VisibleElementsOfCurrentView = true;

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
            navisoptions.ExportScope = NavisworksExportScope.View;

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

            exportdialog.IFCCombobox.DataSource = IFCExportpredefined(doc);

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
                if (exportdialog.NWCCheckBox.Checked)
                {
                    ExportNWC(doc, destinationpath, doc.Title, selectedview, exportdialog.SharedRadio.Checked);
                    count++;
                }
                if (exportdialog.IFCCheckBox.Checked)
                {
                    ExportIFC(doc, destinationpath, doc.Title, selectedview, settings);
                    count++;
                }
                if (exportdialog.DWGCheckbox.Checked)
                {
                    ExportDWG(doc, destinationpath, doc.Title, selectedview, dwgoption);
                    count++;
                }
                TaskDialog.Show("Success", "exported " + count + " documents");

                //clear the folder
                if (exportdialog.DeleteLogFilesButton.Checked)
                {
                    DeleteLog(destinationpath);
                }
                //REPORT---------------
                try
                {
                    string[] log = new string[6];
                    List<string> rep = new List<string>();
                    string locationpath = "\\\\zaha-hadid.com\\Data\\Projects\\2100_BIMManagement\\User\\MS\\users";
                    DirectoryInfo exportFolder = new DirectoryInfo(destinationpath);
                    string filepath = destinationpath;
                    string path = string.Format(locationpath + "\\report.txt");
                    string[] vs = new string[1];
                    string a = "";
                    foreach (FileInfo f in exportFolder.GetFiles())
                    {
                        log[0] = (Environment.UserName.ToString());
                        log[1] = (DateTime.UtcNow.ToString("yyyy/MM/dd HH:mm"));//date;;
                        log[2] = Path.GetFileNameWithoutExtension(f.Name);
                        log[3] = f.Extension;
                        log[4] = (f.Length * 0.001).ToString();
                        log[5] = Environment.NewLine;
                        a = log[0] + "," + log[1] + "," + log[2] + "," + log[3] + "," + log[4] + log[5];
                        File.AppendAllText(path, a);
                    }
                }
                catch
                {

            }

            return Result.Succeeded;
            }   
            else
            {
                return Result.Cancelled;
            }
                           
        }
    }
}
