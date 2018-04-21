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
using System.Management;

namespace PCCleaner.Controls
{
    public partial class UCStartup : UserControl
    {
        public UCStartup()
        {
            InitializeComponent();
            LoadWindowsStartupInfo();

        }

        private void LoadWindowsStartupInfo()
        {
            CleanerRegistry registry = new CleanerRegistry();
            List<ComputerProgram> list = registry.GetStartupPrograms();

            var bindingList = new BindingList<ComputerProgram>(list);
            var source = new BindingSource(bindingList, null);

            this.dataGridViewWindows.AutoGenerateColumns = false;
            this.dataGridViewWindows.DataSource = source;
            this.dataGridViewWindows.RowHeadersVisible = false;
            this.dataGridViewWindows.ColumnHeadersVisible = true;
            this.dataGridViewWindows.CellBorderStyle = DataGridViewCellBorderStyle.None;
        }

        private void tabControlStartup_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tabControlStartup.SelectedTab.Name == "tabWindows")
            {
                LoadWindowsStartupInfo();
            }
            else if (tabControlStartup.SelectedTab.Name == "tabPageScheduledTasks")
            {
                //ManagementObjectSearcher searcher = new ManagementObjectSearcher(@"\kausar\root\SELECT * FROM Win32_ScheduledJob");
                ManagementPath mp = new ManagementPath(@"\kausar\root\SELECT * FROM Win32_ScheduledJob");

                ManagementClass mc = new ManagementClass(mp);
                var obj = mc.GetInstances();

                foreach (ManagementObject o in obj)
                {
                    var result =o["Name"];
                    //listBox1.Items.Add( o["Name"]);
                    //if (o["Name"] == "Caclulator")
                    //{
                    //    MessageBox.Show("Job status: " + o["Status"]);
                    //}
                }


               // var list =searcher.Get();
                //Helper.GetScheduledTasks();
            }
            else if (tabControlStartup.SelectedTab.Name == "tabPageContextMenu")
            {

            }
        }
    }
}
