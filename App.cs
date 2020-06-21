using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using System;
using System.Reflection;
using System.Windows.Media.Imaging;

namespace RevitBatchExporter
{
    public class App : IExternalApplication
    {
        static void AddRibbonPanel(UIControlledApplication application)
        {
            RibbonPanel ribbonPanel = application.CreateRibbonPanel("Exporter");

            string assembly = Assembly.GetExecutingAssembly().Location;

            PushButtonData buttondata = new PushButtonData("Batch Export", "Batch Export", assembly, "RevitBatchExporter.Export");
            buttondata.AvailabilityClassName = "RevitBatchExporter.Availability";
            PushButton button = ribbonPanel.AddItem(buttondata) as PushButton;
            button.ToolTip = "Batch export Revit documents.";
            BitmapImage image = new BitmapImage(new Uri("pack://application:,,,/RevitBatchExporter;component/Resources/RevitBatchExporter.png"));
            button.LargeImage = image;
        }
        public Result OnShutdown(UIControlledApplication application)
        {
            return Result.Succeeded;
        }
        public Result OnStartup(UIControlledApplication application)
        {
            AddRibbonPanel(application);

            return Result.Succeeded;
        }
    }
    public class Availability : IExternalCommandAvailability
    {
        public bool IsCommandAvailable(UIApplication a, CategorySet b)
        {
            return true;
        }
    }
}
