using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PCCleaner.Common;

namespace PCCleaner.Controls
{
    public partial class UCBrowserPlugins : UserControl
    {
        public UCBrowserPlugins()
        {
            InitializeComponent();

            var result = Navigators.GetIEPlugins();

            var bindingList = new BindingList<BrowserExtension>(result.ToList());
            var source = new BindingSource(bindingList, null);
            this.dataGridViewWindows.AutoGenerateColumns = false;
            this.dataGridViewWindows.DataSource = source;
            this.dataGridViewWindows.RowHeadersVisible = false;
            this.dataGridViewWindows.ColumnHeadersVisible = true;
            this.dataGridViewWindows.CellBorderStyle = DataGridViewCellBorderStyle.None;
        }

        private void tabControlStartup_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControlStartup.SelectedTab.Name == "tabPageChrome")
            {
                var result = Navigators.GetChromePlugins();


                var bindingList = new BindingList<BrowserExtension>(result.ToList());
                var source = new BindingSource(bindingList, null);
                this.dataGridViewChrome.AutoGenerateColumns = false;
                this.dataGridViewChrome.DataSource = source;
                this.dataGridViewChrome.RowHeadersVisible = false;
                this.dataGridViewChrome.ColumnHeadersVisible = true;
                this.dataGridViewChrome.CellBorderStyle = DataGridViewCellBorderStyle.None;
            }
            else if (tabControlStartup.SelectedTab.Name == "tabPageFirefox")
            {
                var result = Navigators.GetFirefoxExtensions();

                var bindingList = new BindingList<BrowserExtension>(result.ToList());
                var source = new BindingSource(bindingList, null);
                this.dataGridViewFirefox.AutoGenerateColumns = false;
                this.dataGridViewFirefox.DataSource = source;
                this.dataGridViewFirefox.RowHeadersVisible = false;
                this.dataGridViewFirefox.ColumnHeadersVisible = true;
                this.dataGridViewFirefox.CellBorderStyle = DataGridViewCellBorderStyle.None;
            }
            else if (tabControlStartup.SelectedTab.Name == "tabIE")
            {

                var result = Navigators.GetIEPlugins();

                var bindingList = new BindingList<BrowserExtension>(result.ToList());
                var source = new BindingSource(bindingList, null);
                this.dataGridViewWindows.AutoGenerateColumns = false;
                this.dataGridViewWindows.DataSource = source;
                this.dataGridViewWindows.RowHeadersVisible = false;
                this.dataGridViewWindows.ColumnHeadersVisible = true;
                this.dataGridViewWindows.CellBorderStyle = DataGridViewCellBorderStyle.None;
            }
        }
    }
}
