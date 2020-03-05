using Autodesk.Revit.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.IO;
using System.Windows.Media.Imaging;
using System.Text;
using System.Threading.Tasks;
using Autodesk.Revit.DB;

namespace RevitBatchExporter
{
    public class App : IExternalApplication
    {
        static void AddRibbonPanel(UIControlledApplication application)
        {
            RibbonPanel ribbonPanel = application.CreateRibbonPanel("Exporter");

            string thisAssemblyPath = Assembly.GetExecutingAssembly().Location;            

            PushButtonData b1Data = new PushButtonData("Batch Export", "Batch Export", thisAssemblyPath, "RevitBatchExporter.BatchExport");
            b1Data.AvailabilityClassName = "RevitBatchExporter.Availability";
            PushButton pb1 = ribbonPanel.AddItem(b1Data) as PushButton;
            pb1.ToolTip = "Batch export Revit documents.";
            BitmapImage pb1Image = new BitmapImage(new Uri("pack://application:,,,/RevitBatchExporter;component/Resources/RevitBatchExporter.png"));
            pb1.LargeImage = pb1Image;

            PushButtonData b2Data = new PushButtonData("Export", "Export", thisAssemblyPath, "RevitBatchExporter.Export");
            PushButton pb2 = ribbonPanel.AddItem(b2Data) as PushButton;
            pb2.ToolTip = "Export Current Revit document in different formats.";
            BitmapImage pb2Image = new BitmapImage(new Uri("pack://application:,,,/RevitBatchExporter;component/Resources/RevitBatchExporter.png"));
            pb2.LargeImage = pb2Image;
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
