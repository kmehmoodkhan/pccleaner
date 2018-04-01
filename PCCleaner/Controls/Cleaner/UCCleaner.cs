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
        }


        private void AddBrowsers()
        {

            if (Navigators.IsEdgeBrowserInstalled())
            {
                UCAppsList appsList = new UCAppsList(Navigators.GetBrowserFeatures(), "Edge", Resources.Edge);
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
                    UCAppsList appsList = new UCAppsList(Navigators.GetBrowserFeatures(), browser.Name, image);
                    panelWindowApps.Controls.Add(appsList);
                }
                else if (browser.BrowserType == BrowserType.Others)
                {
                    UCAppsList appsList = new UCAppsList(Navigators.GetBrowserFeatures(), browser.Name, image);
                    panelNonWindowsApps.Controls.Add(appsList);
                }
            }

           

        }

        private void AddExplorerFeature()
        {
            UCAppsList explorerList = new UCAppsList(Helper.GetExplorerFeatures(), "Explorer", Resources.Explorer);
            panelWindowApps.Controls.Add(explorerList);
        }
        private void AddSystemFeature()
        {
            UCAppsList explorerList = new UCAppsList(Helper.GetSystemFeatures(), "System", Resources.System);
            panelWindowApps.Controls.Add(explorerList);
        }

        private void AddAdvancedFeature()
        {
            UCAppsList advancedList = new UCAppsList(Helper.GetAdvancedFeatures(), "Advanced", Resources.Information);
            panelWindowApps.Controls.Add(advancedList);

        }

        public void AddFirefox()
        {


            List<ListItem> items = new List<ListItem>();
            items.Add(new ListItem() { ItemId = 1, ItemText = "Bing News" });
            items.Add(new ListItem() { ItemId = 2, ItemText = "Skype Metro App" });


            UCAppsList appsList = new UCAppsList(items, "Windows Store", Resources.IE);

            //appsList.HeadingLabel = "Windows Store";
            //appsList.HeadingImage = Resources.Edge;

            panelNonWindowsApps.Controls.Add(appsList);

        }
    }
}
