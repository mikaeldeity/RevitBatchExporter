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

namespace XPORT
{
    public class App : IExternalApplication
    {
        static void AddRibbonPanel(UIControlledApplication application)
        {
            RibbonPanel ribbonPanel = application.CreateRibbonPanel("XPORT");

            string thisAssemblyPath = Assembly.GetExecutingAssembly().Location;            

            PushButtonData b1Data = new PushButtonData("XPORT", "XPORT", thisAssemblyPath, "XPORT.Export");
            b1Data.AvailabilityClassName = "XPORT.Availability";
            PushButton pb1 = ribbonPanel.AddItem(b1Data) as PushButton;
            pb1.ToolTip = "Export Revit documents.";
            BitmapImage pb1Image = new BitmapImage(new Uri(thisAssemblyPath.Replace("XPORT.dll","") + "XP.png"));
            pb1.LargeImage = pb1Image;

            PushButtonData b2Data = new PushButtonData("XCOPY", "XCOPY", thisAssemblyPath, "XPORT.Copy");
            PushButton pb2 = ribbonPanel.AddItem(b2Data) as PushButton;
            pb2.ToolTip = "Copy Elements from Link Instance to current Document.";
            BitmapImage pb2Image = new BitmapImage(new Uri(thisAssemblyPath.Replace("XPORT.dll", "") + "XC.png"));
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
