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
            RibbonPanel ribbonPanel = application.CreateRibbonPanel("Revit Batch Exporter");

            string thisAssemblyPath = Assembly.GetExecutingAssembly().Location;            

            PushButtonData b1Data = new PushButtonData("Export", "Export", thisAssemblyPath, "RevitBatchExporter.Export");
            b1Data.AvailabilityClassName = "RevitBatchExporter.Availability";
            PushButton pb1 = ribbonPanel.AddItem(b1Data) as PushButton;
            pb1.ToolTip = "Batch export Revit documents.";
            BitmapImage pb1Image = new BitmapImage(new Uri(thisAssemblyPath.Replace("RevitBatchExporter.dll", "") + "RevitBatchExporter.png"));
            pb1.LargeImage = pb1Image;
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
