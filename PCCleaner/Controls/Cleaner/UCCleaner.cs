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

namespace PCCleaner.Controls
{
    public partial class UCCleaner : UserControl
    {
        public UCCleaner()
        {
            InitializeComponent();
            AddFirefox();

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
