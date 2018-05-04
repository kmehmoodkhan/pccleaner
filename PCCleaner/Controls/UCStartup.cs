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
using Microsoft.Win32;

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
            if (tabControlStartup.SelectedTab.Name == "tabWindows")
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
                    var result = o["Name"];
                }
            }
            else if (tabControlStartup.SelectedTab.Name == "tabPageContextMenu")
            {

            }
        }


        bool _IsRowSelected = false;
        public bool IsRowSelected
        {
            get
            {
                return _IsRowSelected;
            }
        }


        private void dataGridViewWindows_SelectionChanged(object sender, EventArgs e)
        {
            if (this.dataGridViewWindows.SelectedRows.Count > 0)
            {
                _IsRowSelected = true;

                if (this.dataGridViewWindows.SelectedRows.Count > 0)
                {
                    object enabledString = this.dataGridViewWindows.SelectedRows[0].Cells[0].Value;
                    if (enabledString != null && !string.IsNullOrEmpty(enabledString.ToString()))
                    {
                        if (enabledString.Equals("Disabled"))
                        {
                            this.buttonEnable.Enabled = true;
                            this.buttonDisable.Enabled = false;
                        }
                        else
                        {
                            this.buttonEnable.Enabled = false;
                            this.buttonDisable.Enabled = true;
                        }
                    }
                }
            }
        }

        private string ProgramName
        {
            get
            {
                return this.dataGridViewWindows.SelectedRows[0].Cells[2].Value.ToString();
            }
        }

        private void buttonEnable_Click(object sender, EventArgs e)
        {
            OperationStartupProgram(ProgramName);
        }

        private void buttonDisable_Click(object sender, EventArgs e)
        {
            OperationStartupProgram(ProgramName);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            OperationStartupProgram(ProgramName, true);
        }

        private void OperationStartupProgram(string programName,bool isDelete = false)
        {

            byte[] enableArray = new byte[] { 3, 0, 0, 0, 166, 106, 216, 235, 221, 227, 211 };
            byte[] disableArray = new byte[] {2, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0};

            using (var keyUser = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Explorer\StartupApproved\Run",true))
            {
                var keyUserValues = keyUser.GetValueNames();
                bool isFound = false;
                foreach (var ky in keyUserValues)
                {
                    if (ky == programName)
                    {
                        isFound = true;
                        var currentValue = ((byte[])keyUser.GetValue(ky))[0];
                        var fullValue = ((byte[])keyUser.GetValue(ky));
                        if (!isDelete)
                        {
                            if (currentValue == 3)
                            {
                                fullValue[0] = 2;
                                keyUser.SetValue(ky, fullValue);
                            }
                            else if (currentValue == 2)
                            {
                                fullValue[0] = 3;
                                keyUser.SetValue(ky, fullValue);
                            }
                        }
                        else
                        {
                            keyUser.DeleteValue(ky);
                        }
                        LoadWindowsStartupInfo();
                        break;
                    }
                }

                if(!isFound)
                {
                    keyUser.SetValue(programName, disableArray);
                }
            }
        }
    }
}
