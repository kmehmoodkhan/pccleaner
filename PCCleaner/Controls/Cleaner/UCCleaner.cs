using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PCCleaner.Properties;
using PCCleaner.Controls.Common;
using PCCleaner.Common;

namespace PCCleaner.Controls
{
    public partial class UCCleaner : UserControl
    {
        public UCCleaner()
        {
            InitializeComponent();

            AddBrowsers();
            AddExplorerFeature();
            AddSystemFeature();
            AddAdvancedFeature();
            //AddWindowsApplications();
            //AddWindowStoreApps();
        }


        private void AddBrowsers()
        {

            if (Navigators.IsEdgeBrowserInstalled())
            {
                UCAppsList appsList = new UCAppsList(Navigators.GetBrowserFeatures(), "Edge", Resources.Edge,"Edge");
                panelWindowApps.Controls.Add(appsList);
            }

            var browsers = Navigators.GetBrowsers();


            foreach (Browser browser in browsers)
            {
                string iconPath = browser.IconPath.Split(',')[0];
                Icon icon = Icon.ExtractAssociatedIcon(iconPath);
                Image image = icon.ToBitmap();

                image = Helper.ResizeImage(image, 20, 20);

                if (browser.BrowserType == BrowserType.Microsoft)
                {
                    UCAppsList appsList = new UCAppsList(Navigators.GetBrowserFeatures(), browser.Name, image,"IE");
                    panelWindowApps.Controls.Add(appsList);
                }
                else if (browser.BrowserType == BrowserType.Others)
                {
                    UCAppsList appsList = new UCAppsList(Navigators.GetBrowserFeatures(), browser.Name, image,browser.Name);
                    panelNonWindowsApps.Controls.Add(appsList);
                }
            }

           

        }

        private void AddExplorerFeature()
        {
            UCAppsList explorerList = new UCAppsList(Helper.GetExplorerFeatures(), "Explorer", Resources.Explorer,"Explorer");
            panelWindowApps.Controls.Add(explorerList);
        }
        private void AddSystemFeature()
        {
            UCAppsList explorerList = new UCAppsList(Helper.GetSystemFeatures(), "System", Resources.System,"System");
            panelWindowApps.Controls.Add(explorerList);
        }

        private void AddAdvancedFeature()
        {
            UCAppsList advancedList = new UCAppsList(Helper.GetAdvancedFeatures(), "Advanced", Resources.Information,"Advanced");
            panelWindowApps.Controls.Add(advancedList);

        }

        private void AddWindowsApplications()
        {
            UCAppsList advancedList = new UCAppsList(Helper.GetWindowsApplications(), "Applications", Resources.Information,"Applications");
            panelWindowApps.Controls.Add(advancedList);
            
        }
        //private void AddWindowStoreApps()
        //{
        //    //PackageManager packageManager = new PackageManager();
        //    //IEnumerable<Windows.ApplicationModel.Package> packages = packageManager.FindPackagesForUser("");

        //    UCAppsList advancedList = new UCAppsList(Helper.GetAdvancedFeatures(), "Advanced", Resources.Information);
        //    panelWindowApps.Controls.Add(advancedList);
        //}
    }
}
