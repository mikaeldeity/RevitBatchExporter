using Autodesk.Revit.DB;
using Autodesk.Revit.DB.Events;
using Autodesk.Revit.UI;
using Autodesk.Revit.UI.Events;
using RevitBatchExporter.Dialogs;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace RevitBatchExporter
{
    [Autodesk.Revit.Attributes.Transaction(Autodesk.Revit.Attributes.TransactionMode.Manual)]
    [Autodesk.Revit.Attributes.Regeneration(Autodesk.Revit.Attributes.RegenerationOption.Manual)]

    class Export : IExternalCommand
    {
        internal static List<string> Documents;

        internal static string DestinationPath;

        internal static string Splash;

        internal List<string[]> Errors;
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            UIApplication uiapp = commandData.Application;

            DestinationPath = string.Empty;
            Documents = new List<string>();
            Splash = string.Empty;
            Errors = new List<string[]>();

            string date = DateTime.Now.ToString("dd/MM/yyyy");

            int completed = 0;

            int failed = 0;

            ExportDialog exportdialog = new ExportDialog();

            System.Windows.Forms.DialogResult dialog = exportdialog.ShowDialog();

            if (dialog != System.Windows.Forms.DialogResult.OK)
            {
                return Result.Cancelled;
            }

            WorksetConfiguration openconfig = new WorksetConfiguration(WorksetConfigurationOption.CloseAllWorksets);
            OpenOptions openoptions = new OpenOptions();
            openoptions.SetOpenWorksetsConfiguration(openconfig);
            if (exportdialog.DiscardRadioButton.Checked)
            {
                openoptions.DetachFromCentralOption = DetachFromCentralOption.DetachAndDiscardWorksets;
            }
            else
            {
                openoptions.DetachFromCentralOption = DetachFromCentralOption.DetachAndPreserveWorksets;
            }

            SaveAsOptions worksharedsaveas = new SaveAsOptions();
            WorksharingSaveAsOptions saveConfig = new WorksharingSaveAsOptions
            {
                SaveAsCentral = true
            };
            worksharedsaveas.SetWorksharingOptions(saveConfig);
            worksharedsaveas.OverwriteExistingFile = true;

            SaveAsOptions regularsaveas = new SaveAsOptions
            {
                OverwriteExistingFile = true
            };

            if (exportdialog.AuditCheckBox.Checked)
            {
                openoptions.Audit = true;
            }

            if (exportdialog.SafeNameTextbox.Text.Trim() != string.Empty)
            {
                Splash = exportdialog.SafeNameTextbox.Text.Trim();
            }

            string customdate = exportdialog.DateTimePickerIssue.Value.ToString("yyyy/MM/dd");

            string nameprefix = exportdialog.PrefixTextBox.Text.Trim();

            string namesuffix = exportdialog.SuffixTextBox.Text.Trim();

            bool samepath = false;

            List<string[]> results = new List<string[]>();

            foreach (string path in Documents)
            {
                string destdoc = nameprefix + Path.GetFileNameWithoutExtension(path) + namesuffix + ".rvt";

                if (File.Exists(DestinationPath + destdoc))
                {
                    samepath = true;
                    break;
                }

                string pathonly = Path.GetDirectoryName(path) + "\\";

                if (pathonly == DestinationPath)
                {
                    samepath = true;
                    break;
                }
            }

            if (samepath)
            {
                TaskDialog td = new TaskDialog("Export")
                {
                    MainInstruction = "Some documents already exist in the destination path.",
                    MainContent = "The files will be overritten, do you wish to continue?"
                };

                td.AddCommandLink(TaskDialogCommandLinkId.CommandLink1, "Continue");
                td.AddCommandLink(TaskDialogCommandLinkId.CommandLink2, "Cancel");

                switch (td.Show())
                {
                    case TaskDialogResult.CommandLink1:
                        break;

                    case TaskDialogResult.CommandLink2:
                        return Result.Cancelled;

                    default:
                        return Result.Cancelled;
                }
            }

            uiapp.DialogBoxShowing += new EventHandler<DialogBoxShowingEventArgs>(OnDialogBoxShowing);
            uiapp.Application.FailuresProcessing += FailureProcessor;

            DateTime start = DateTime.Now;

            foreach (string path in Documents)
            {
                string[] result = new string[6];
                string resultmessage = string.Empty;

                if (!File.Exists(path))
                {
                    result[0] = Path.GetFileName(path);
                    result[1] = "File Not Found";
                    result[2] = string.Empty;
                    results.Add(result);
                    failed++;
                    continue;
                }

                DateTime s1 = DateTime.Now;

                Document doc = null;

                //try
                //{
                    doc = uiapp.Application.OpenDocumentFile(ModelPathUtils.ConvertUserVisiblePathToModelPath(path), openoptions);

                    string docname = nameprefix + Path.GetFileNameWithoutExtension(path) + namesuffix;

                    using (Transaction t = new Transaction(doc, "Export"))
                    {
                        t.Start();

                        if (exportdialog.AutoCheckBox.Checked)
                        {
                            doc.ProjectInformation.IssueDate = date;
                        }
                        else
                        {
                            doc.ProjectInformation.IssueDate = customdate;
                        }

                        if (exportdialog.RemoveCADLinksCheckBox.Checked) { DeleteCADLinks(doc); }
                        if (exportdialog.RemoveCADImportsCheckBox.Checked) { DeleteCADImports(doc); }
                        if (exportdialog.RemoveRVTLinksCheckBox.Checked) { DeleteRVTLinks(doc); }
                        DeleteViewsAndSheets(doc, exportdialog.ViewsONSheetsCheckBox.Checked, exportdialog.ViewsNOTSheetsCheckBox.Checked, exportdialog.SheetsCheckBox.Checked, exportdialog.TemplatesCheckBox.Checked);
                        if (exportdialog.RemoveSchedulesCheckBox.Checked) { DeleteSchedules(doc); }
                        if (exportdialog.UngroupCheckBox.Checked) { UngroupGroups(doc); }
                        if (exportdialog.PurgeCheckBox.Checked) { PurgeDocument(doc); }

                        t.Commit();
                    }


                    if (doc.IsWorkshared)
                    {
                        doc.SaveAs(DestinationPath + docname + ".rvt", worksharedsaveas);
                    }
                    else
                    {
                        doc.SaveAs(DestinationPath + docname + ".rvt", regularsaveas);
                    }

                    doc.Close(false);

                    string backupfolder = DestinationPath + docname + "_backup";
                    string tempfolder = DestinationPath + "Revit_temp";

                    if (Directory.Exists(backupfolder))
                    {
                        Directory.Delete(backupfolder, true);
                    }
                    if (Directory.Exists(tempfolder))
                    {
                        Directory.Delete(tempfolder, true);
                    }

                    resultmessage = "Completed";
                    completed++;
                //}
                // catch (Exception e)
                //{
                //    try
                //    {
                //        doc.Close(false);
                //    }
                //    catch { }

                //    resultmessage = e.Message;
                //    failed++;
                //}

                DateTime e1 = DateTime.Now;

                int h = (e1 - s1).Hours;
                int m = (e1 - s1).Minutes;
                int s = (e1 - s1).Seconds;

                result[0] = Path.GetFileName(path);
                result[1] = resultmessage;
                result[2] = h.ToString() + ":" + m.ToString() + ":" + s.ToString();
                results.Add(result);
            }

            uiapp.DialogBoxShowing -= OnDialogBoxShowing;
            uiapp.Application.FailuresProcessing -= FailureProcessor;

            DateTime end = DateTime.Now;

            int hours = (end - start).Hours;

            int minutes = (end - start).Minutes;

            int seconds = (end - start).Seconds;

            TaskDialog rd = new TaskDialog("Export")
            {
                MainInstruction = "Results",
                MainContent = "Exported to: " + DestinationPath + "\n" + "Completed: " + completed.ToString() + "\nFailed: " + failed.ToString() + "\nTotal Time: " + hours.ToString() + " h " + minutes.ToString() + " m " + seconds.ToString() + " s"
            };

            rd.AddCommandLink(TaskDialogCommandLinkId.CommandLink1, "Close");
            rd.AddCommandLink(TaskDialogCommandLinkId.CommandLink2, "Show Details");

            switch (rd.Show())
            {
                case TaskDialogResult.CommandLink1:
                    return Result.Succeeded;

                case TaskDialogResult.CommandLink2:

                    ResultsDialog resultsdialog = new ResultsDialog();

                    foreach (string[] r in results)
                    {
                        var item = new System.Windows.Forms.ListViewItem(r);
                        resultsdialog.ResultsView.Items.Add(item);
                    }

                    var rdialog = resultsdialog.ShowDialog();

                    return Result.Succeeded;

                default:
                    return Result.Succeeded;
            }
        }
        private void DeleteRVTLinks(Document doc)
        {
            var collector = new FilteredElementCollector(doc).OfCategory(BuiltInCategory.OST_RvtLinks).ToElementIds();

            if (collector.Count != 0)
            {
                foreach (ElementId id in collector)
                {
                    if (doc.GetElement(id) != null)
                    {
                        doc.Delete(id);
                    }
                }
            }
        }
        private void DeleteCADLinks(Document doc)
        {
            var collector = new FilteredElementCollector(doc).OfClass(typeof(ImportInstance)).ToElementIds();

            if (collector.Count != 0)
            {
                foreach (ElementId id in collector)
                {
                    if (doc.GetElement(id) != null)
                    {
                        ImportInstance cad = doc.GetElement(id) as ImportInstance;

                        if (cad.IsLinked)
                        {
                            doc.Delete(id);
                        }
                    }
                }
            }
        }
        private void DeleteCADImports(Document doc)
        {
            var collector = new FilteredElementCollector(doc).OfClass(typeof(ImportInstance)).ToElementIds();

            if (collector.Count != 0)
            {
                foreach (ElementId id in collector)
                {
                    if (doc.GetElement(id) != null)
                    {
                        ImportInstance cad = doc.GetElement(id) as ImportInstance;

                        if (!cad.IsLinked)
                        {
                            doc.Delete(id);
                        }
                    }
                }
            }
        }
        private void DeleteViewsAndSheets(Document doc, bool onsheet, bool notonsheets, bool sheets, bool templates)
        {
            List<ElementId> delete = new List<ElementId>();

            var allsheets = new FilteredElementCollector(doc).OfCategory(BuiltInCategory.OST_Sheets).ToElementIds();

            var allviews = new FilteredElementCollector(doc).OfCategory(BuiltInCategory.OST_Views).ToElements().Cast<View>().Where(x => x.IsTemplate != true && x.CanBePrinted).ToList();

            if (onsheet)
            {
                if (allsheets.Count > 0)
                {
                    foreach (ElementId id in allsheets)
                    {
                        ViewSheet sheet = doc.GetElement(id) as ViewSheet;

                        ISet<ElementId> views = sheet.GetAllPlacedViews();

                        foreach (ElementId view in views)
                        {
                            if (doc.GetElement(view) != null)
                            {
                                doc.Delete(view);
                            }
                        }
                    }

                    allviews = new FilteredElementCollector(doc).OfCategory(BuiltInCategory.OST_Views).ToElements().Cast<View>().Where(x => x.IsTemplate != true && x.CanBePrinted).ToList();
                }
            }

            if (sheets)
            {
                foreach (ElementId sheet in allsheets)
                {
                    if (doc.GetElement(sheet) != null)
                    {
                        doc.Delete(sheet);
                    }
                }
                allsheets = new FilteredElementCollector(doc).OfCategory(BuiltInCategory.OST_Sheets).ToElementIds();
            }

            if (notonsheets)
            {
                List<ElementId> viewsonsheets = new List<ElementId>();

                if (allsheets.Count > 0)
                {
                    foreach (ElementId id in allsheets)
                    {
                        ViewSheet sheet = doc.GetElement(id) as ViewSheet;

                        viewsonsheets.AddRange(sheet.GetAllPlacedViews());
                    }
                }

                if (viewsonsheets.Count > 0)
                {
                    allviews = new FilteredElementCollector(doc).OfCategory(BuiltInCategory.OST_Views).Excluding(viewsonsheets).ToElements().Cast<View>().Where(x => x.IsTemplate != true && x.CanBePrinted).ToList();
                }
                else
                {
                    allviews = new FilteredElementCollector(doc).OfCategory(BuiltInCategory.OST_Views).ToElements().Cast<View>().Where(x => x.IsTemplate != true && x.CanBePrinted).ToList();
                }

                foreach (View view in allviews)
                {
                    if (view.IsValidObject)
                    {
                        if (doc.GetElement(view.Id) != null)
                        {
                            if (view.GetDependentViewIds().Count == 0)
                            {
                                doc.Delete(view.Id);
                            }
                        }
                    }
                }

                if (viewsonsheets.Count > 0)
                {
                    allviews = new FilteredElementCollector(doc).OfCategory(BuiltInCategory.OST_Views).Excluding(viewsonsheets).ToElements().Cast<View>().Where(x => x.IsTemplate != true && x.CanBePrinted).ToList();
                }
                else
                {
                    allviews = new FilteredElementCollector(doc).OfCategory(BuiltInCategory.OST_Views).ToElements().Cast<View>().Where(x => x.IsTemplate != true && x.CanBePrinted).ToList();
                }

                foreach (View view in allviews)
                {
                    if (view.IsValidObject)
                    {
                        if (doc.GetElement(view.Id) != null)
                        {
                            if (view.GetDependentViewIds().Count == 0)
                            {
                                doc.Delete(view.Id);
                            }
                        }
                    }
                }
            }

            if (templates)
            {
                var alltemplates = new FilteredElementCollector(doc).OfCategory(BuiltInCategory.OST_Views).ToElements().Cast<View>().Where(x => x.IsTemplate == true);

                foreach (View template in alltemplates)
                {
                    if (doc.GetElement(template.Id) != null)
                    {
                        doc.Delete(template.Id);
                    }
                }
            }

            allviews = new FilteredElementCollector(doc).OfCategory(BuiltInCategory.OST_Views).ToElements().Cast<View>().Where(x => x.IsTemplate != true && x.CanBePrinted).ToList();

            if (allviews.Count() == 0)
            {
                var viewFamilyType = new FilteredElementCollector(doc).OfClass(typeof(ViewFamilyType)).Cast<ViewFamilyType>().FirstOrDefault(x => x.ViewFamily == ViewFamily.ThreeDimensional);

                var view3D = View3D.CreateIsometric(doc, viewFamilyType.Id);
            }
        }
        private void DeleteSchedules(Document doc)
        {
            var collector = new FilteredElementCollector(doc).OfClass(typeof(ViewSchedule)).ToElementIds();

            if (collector.Count > 0)
            {
                foreach (ElementId id in collector)
                {
                    if (doc.GetElement(id) != null)
                    {
                        doc.Delete(id);
                    }
                }
            }
        }
        private void UngroupGroups(Document doc)
        {
            var collector = new FilteredElementCollector(doc).OfCategory(BuiltInCategory.OST_IOSModelGroups).WhereElementIsNotElementType().ToElements();

            if (collector.Count == 0)
            {
                return;
            }

            foreach (Group g in collector)
            {
                g.UngroupMembers();
            }

            var groups = new FilteredElementCollector(doc).OfCategory(BuiltInCategory.OST_IOSModelGroups).ToElementIds();

            foreach (ElementId id in groups)
            {
                if (doc.GetElement(id) != null)
                {
                    doc.Delete(id);
                }
            }
        }
        private void PurgeDocument(Document doc)
        {
            Guid guid = new Guid("e8c63650-70b7-435a-9010-ec97660c1bda");

            var performanceAdviser = PerformanceAdviser.GetPerformanceAdviser();

            List<PerformanceAdviserRuleId> ruleId = new List<PerformanceAdviserRuleId>();

            var allRuleIds = performanceAdviser.GetAllRuleIds();

            foreach (var r in allRuleIds)
            {
                if (r.Guid == guid)
                {
                    ruleId.Add(r);
                }
            }

            var failureMessages = performanceAdviser.ExecuteRules(doc, ruleId);

            if (failureMessages.Count > 0)
            {
                var purgableElementIds = failureMessages[0].GetFailingElements();

                foreach (ElementId id in purgableElementIds)
                {
                    if (doc.GetElement(id) != null)
                    {
                        doc.Delete(id);
                    }
                }
            }
        }
        private void FailureProcessor(object sender, FailuresProcessingEventArgs e)
        {
            FailuresAccessor fas = e.GetFailuresAccessor();

            List<FailureMessageAccessor> fma = fas.GetFailureMessages().ToList();

            foreach (FailureMessageAccessor fa in fma)
            {
                fas.DeleteWarning(fa);
            }
        }
        private void OnDialogBoxShowing(object sender, DialogBoxShowingEventArgs e)
        {
            if (e is TaskDialogShowingEventArgs e1)
            {
                e1.OverrideResult((int)TaskDialogResult.CommandLink1);
            }
        }
    }
}
