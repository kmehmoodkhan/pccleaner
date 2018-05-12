using System;
using System.Collections.Generic;
using System.ComponentModel;
using WinTaskScheduler = Microsoft.Win32.TaskScheduler;
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

        private void LoadScheduledTasks()
        {
            CleanerRegistry registry = new CleanerRegistry();
            List<ComputerProgram> list = registry.GetScheduledTasks();

            var bindingList = new BindingList<ComputerProgram>(list);
            var source = new BindingSource(bindingList, null);

            this.dataGridViewScheduledTasks.AutoGenerateColumns = false;
            this.dataGridViewScheduledTasks.DataSource = source;
            this.dataGridViewScheduledTasks.RowHeadersVisible = false;
            this.dataGridViewScheduledTasks.ColumnHeadersVisible = true;
            this.dataGridViewScheduledTasks.CellBorderStyle = DataGridViewCellBorderStyle.None;
        }

        private void LoadContextMenuItems()
        {
            CleanerRegistry registry = new CleanerRegistry();
            List<ComputerProgram> list = registry.GetContextMenuItems();

            var bindingList = new BindingList<ComputerProgram>(list);
            var source = new BindingSource(bindingList, null);

            this.dataGridViewContextMenu.AutoGenerateColumns = false;
            this.dataGridViewContextMenu.DataSource = source;
            this.dataGridViewContextMenu.RowHeadersVisible = false;
            this.dataGridViewContextMenu.ColumnHeadersVisible = true;
            this.dataGridViewContextMenu.CellBorderStyle = DataGridViewCellBorderStyle.None;
        }

        private void tabControlStartup_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControlStartup.SelectedTab.Name == "tabWindows")
            {
                LoadWindowsStartupInfo();
            }
            else if (tabControlStartup.SelectedTab.Name == "tabPageScheduledTasks")
            {
                LoadScheduledTasks();
            }
            else if (tabControlStartup.SelectedTab.Name == "tabPageContextMenu")
            {
                LoadContextMenuItems();
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
                            this.buttonEnable.Focus();
                        }
                        else
                        {
                            this.buttonEnable.Enabled = false;
                            this.buttonDisable.Enabled = true;
                            this.buttonDisable.Focus();
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
            if (tabControlStartup.SelectedTab.Name == "tabWindows")
            {
                OperationStartupProgram(ProgramName);
            }
            else if (tabControlStartup.SelectedTab.Name == "tabPageScheduledTasks")
            {
                EnableDisableTask();
            }
            else if (tabControlStartup.SelectedTab.Name == "tabPageContextMenu")
            {
                EnableDisableContextMenu();
            }
        }

        private void buttonDisable_Click(object sender, EventArgs e)
        {
            if (tabControlStartup.SelectedTab.Name == "tabWindows")
            {
                OperationStartupProgram(ProgramName);
            }
            else if (tabControlStartup.SelectedTab.Name == "tabPageScheduledTasks")
            {
                EnableDisableTask();
            }
            else if (tabControlStartup.SelectedTab.Name == "tabPageContextMenu")
            {
                EnableDisableContextMenu();
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            var showDialog = MessageBox.Show("This will delete registry key, are you sure you want to proceed?", "Warning", MessageBoxButtons.OKCancel);
            if (showDialog == DialogResult.Yes)
            {
                if (tabControlStartup.SelectedTab.Name == "tabWindows")
                {
                    OperationStartupProgram(ProgramName, true);
                }
                else if (tabControlStartup.SelectedTab.Name == "tabPageScheduledTasks")
                {
                    EnableDisableTask(true);
                }
                else if (tabControlStartup.SelectedTab.Name == "tabPageContextMenu")
                {
                    EnableDisableContextMenu(true);
                }
            }
        }

        private void OperationStartupProgram(string programName, bool isDelete = false)
        {

            byte[] enableArray = new byte[] { 3, 0, 0, 0, 166, 106, 216, 235, 221, 227, 211 };
            byte[] disableArray = new byte[] { 2, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

            using (var keyUser = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Explorer\StartupApproved\Run", true))
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

                if (!isFound)
                {
                    keyUser.SetValue(programName, disableArray);
                }
            }
        }

        private void dataGridViewScheduledTasks_SelectionChanged(object sender, EventArgs e)
        {
            if (this.dataGridViewScheduledTasks.SelectedRows.Count > 0)
            {
                if (this.dataGridViewWindows.SelectedRows.Count > 0)
                {
                    object enabledString = this.dataGridViewScheduledTasks.SelectedRows[0].Cells[0].Value;
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

        private bool EnableDisableScheduleTask(string taskName, bool isDelete = false)
        {
            bool isCompleted = false;
            using (WinTaskScheduler.TaskService ts = new WinTaskScheduler.TaskService())
            {
                foreach (WinTaskScheduler.Task task in ts.RootFolder.Tasks)
                {
                    if (task.Name == taskName)
                    {
                        if (!isDelete)
                        {
                            task.Enabled = !task.Enabled;
                        }
                        else
                        {
                            ts.RootFolder.DeleteTask(taskName, false);
                        }
                        isCompleted = true;
                        break;
                    }
                }
            }
            return isCompleted;
        }

        private void EnableDisableTask(bool isDelete = false)
        {
            string selectedTask = this.dataGridViewScheduledTasks.SelectedRows[0].Cells[2].Value.ToString();
            string status = this.dataGridViewScheduledTasks.SelectedRows[0].Cells[0].Value.ToString();

            bool isDone = EnableDisableScheduleTask(selectedTask, isDelete);
            if (isDone)
            {
                string newStatus = string.Empty;
                if (status == "Enabled")
                {
                    newStatus = "Disabled";
                    this.buttonEnable.Enabled = true;
                    this.buttonDisable.Enabled = false;
                    this.buttonEnable.Focus();
                }
                else
                {
                    newStatus = "Enabled";
                    this.buttonEnable.Enabled = false;
                    this.buttonDisable.Enabled = true;
                    this.buttonDisable.Focus();
                }
                this.dataGridViewScheduledTasks.SelectedRows[0].Cells[0].Value = newStatus;
            }
        }

        private void EnableDisableContextMenu(bool isDelete = false)
        {
            string registryKey = this.dataGridViewContextMenu.SelectedRows[0].Cells[5].Value.ToString();
            string subKey = this.dataGridViewContextMenu.SelectedRows[0].Cells[2].Value.ToString();
            if (!string.IsNullOrEmpty(registryKey))
            {
                using (var regKey = Registry.ClassesRoot.OpenSubKey(registryKey,true))
                {
                    bool isEnabled = false;
                    var childSubKey = regKey.OpenSubKey(subKey,true);
                    string currentValue = childSubKey.GetValue("").ToString();

                    if (!isDelete)
                    {
                        
                        if (!childSubKey.GetValue("").ToString().StartsWith("[CC]"))
                        {
                            isEnabled = false;
                            currentValue = "[CC]" + currentValue;
                        }
                        else
                        {
                            isEnabled = true;
                            currentValue = currentValue.Replace("[CC]", "");
                        }
                        childSubKey.SetValue(subKey, currentValue);

                        if (isEnabled)
                        {
                            this.buttonDisable.Enabled = true;
                            this.buttonEnable.Enabled = false;
                            this.dataGridViewContextMenu.SelectedRows[0].Cells[0].Value = "Enabled";
                        }
                        else
                        {
                            this.buttonDisable.Enabled = false;
                            this.buttonEnable.Enabled = true;
                            this.dataGridViewContextMenu.SelectedRows[0].Cells[0].Value = "Disabled";
                        }
                    }
                    else
                    {
                        childSubKey.DeleteValue(currentValue);
                    }
                }
                /////////////////////////////
            }
        }
    }
}
