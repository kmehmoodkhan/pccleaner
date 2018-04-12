using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PCCleaner.Controls.Common;
using PCCleaner.Common;
using PCCleaner.Properties;

namespace PCCleaner.Controls
{
    public partial class UCRegistry : UserControl
    {
        public UCRegistry()
        {
            InitializeComponent();
            AddRegistryOptions();
        }

        public List<ListItem> SelectedItems
        {
            get
            {
                UCAppsList appsList = flowLayoutPanelRegistry.Controls.Find("Registry",false)[0] as UCAppsList;
                return appsList.SelectedItems;
            }
        }
        private void AddRegistryOptions()
        {
            UCAppsList registryOptions = new UCAppsList(Helper.GetRegistryFeaturesList(), "Registry Cleaner", Resources.Explorer, "Registry");
            flowLayoutPanelRegistry.Controls.Add(registryOptions);

        }
    }
}
