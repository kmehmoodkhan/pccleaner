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
using static PCCleaner.Common.Enum;

namespace PCCleaner.Controls
{
    public partial class UCCleaner : UserControl
    {
        public UCCleaner()
        {
            InitializeComponent();
           AddBrowsers();          

        }


        private void AddBrowsers()
        {
            var browsers = Navgiators.GetBrowsers();
            

            foreach ( Browser browser in browsers)
            {

                //List<ListItem> items = new List<ListItem>();
                //items.Add(new ListItem() { ItemId = 1, ItemText = "Bing News" });
                //items.Add(new ListItem() { ItemId = 2, ItemText = "Skype Metro App" });

                //string iconPath = browser.IconPath.Split(',')[0];
                //Icon icon = Icon.ExtractAssociatedIcon(iconPath);
                //Image image = icon.ToBitmap();

                if ( browser.BrowserType == BrowserType.Microsoft)
                {
                    if(browser.Name == "Internet Explorer")
                    {
                        this.ucie2.Visible = true;
                    }
                    //UCAppsList appsList = new UCAppsList(items, browser.Name, image);
                    //panelWindowApps.Controls.Add(appsList);
                }
                else
                {
                    //UCAppsList appsList = new UCAppsList(items, browser.Name, image);
                    //panelNonWindowsApps.Controls.Add(appsList);
                }
            }

            if(Navgiators.IsEdgeBrowserInstalled())
            {
                this.ucEdge1.Visible = true;
            }
            else
            {
                this.ucEdge1.Visible = false;
            }
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
