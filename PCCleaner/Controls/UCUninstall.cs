using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using PCCleaner.Common;
using PCCleaner.Properties;
using System.IO;
using System.Diagnostics;

namespace PCCleaner.Controls
{
    public partial class UCUninstall : UserControl
    {
        public UCUninstall()
        {
            InitializeComponent();
        }


        public void ShowInstalledPrograms()
        {
            List<PCCleaner.Common.Program> prog = new List<PCCleaner.Common.Program>();
            string registry_key = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall";
            using (var baseKey = Microsoft.Win32.RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64))
            {
                using (var key = baseKey.OpenSubKey(registry_key))
                {
                    foreach (string subkey_name in key.GetSubKeyNames())
                    {
                        using (var subKey = key.OpenSubKey(subkey_name))
                        {
                            {
                                PCCleaner.Common.Program program = new PCCleaner.Common.Program();


                                if (subKey.GetValue("DisplayName") != null)
                                {
                                    try
                                    {
                                        program.ProgramName = subKey.GetValue("DisplayName").ToString();

                                        program.RegistryEntry = Path.GetFileName(subKey.Name);
                                    }
                                    catch (Exception ex)
                                    {
                                        ;
                                    }

                                    try
                                    {
                                        program.Version = subKey.GetValue("DisplayVersion").ToString();
                                    }
                                    catch (Exception ex)
                                    {
                                        ;
                                    }

                                    try
                                    {
                                        program.Publisher = subKey.GetValue("Publisher").ToString();
                                    }
                                    catch (Exception ex)
                                    {
                                        ;
                                    }


                                    try
                                    {
                                        if (subKey.GetValue("EstimatedSize") != null)
                                        {
                                            var tempSize = subKey.GetValue("EstimatedSize").ToString();

                                            if (!string.IsNullOrEmpty(tempSize))
                                            {
                                                if (Convert.ToInt32(tempSize) > 1000)
                                                {
                                                    tempSize = Math.Round((Convert.ToDouble(tempSize) / 1000), 2).ToString();
                                                }
                                                else
                                                {
                                                    tempSize = Convert.ToInt32(tempSize).ToString();
                                                }
                                            }
                                            program.Size = tempSize;
                                        }
                                    }
                                    catch (Exception ex)
                                    {
                                        ;
                                    }

                                    try
                                    {
                                        program.Version = subKey.GetValue("DisplayVersion").ToString();
                                    }
                                    catch (Exception ex)
                                    {
                                        ;
                                    }

                                    try
                                    {
                                        program.LauncherPath = subKey.GetValue("ProductIcon").ToString();
                                        program.Icon = System.Drawing.Icon.ExtractAssociatedIcon(program.LauncherPath).ToBitmap();

                                        MemoryStream ms = new MemoryStream();
                                        program.Icon.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
                                        var imageArray = ms.ToArray();

                                        if (program.Icon == null || !Helper.IsValidImage(imageArray))
                                        {
                                            program.Icon = Resources.Exe;
                                        }
                                        else
                                        {
                                            program.Icon = Helper.ResizeImage(program.Icon, 20, 20);
                                        }
                                    }
                                    catch (Exception ex)
                                    {
                                        program.Icon = Resources.Exe;
                                    }

                                    try
                                    {
                                        program.UninstallString = subKey.GetValue("UninstallString").ToString();
                                    }
                                    catch (Exception ex)
                                    {
                                        ;
                                    }

                                    try
                                    {
                                        if (Helper.IsApplictionInstalled(program.ProgramName) && prog.Where(t => t.ProgramName.ToLower() == program.ProgramName.ToLower()).Count() < 1)
                                        {
                                            prog.Add(program);
                                        }
                                    }
                                    catch (Exception ex)
                                    {
                                        ;
                                    }
                                }
                            }
                            subKey.Close();
                        }
                    }
                }
            }

            var bindingList = new BindingList<PCCleaner.Common.Program>(prog.OrderBy(t=>t.ProgramName).ToList());
            var source = new BindingSource(bindingList, null);

            if (this.dataGridViewDetail.InvokeRequired)
            {
                this.dataGridViewDetail.Invoke(new MethodInvoker(delegate
                {
                    this.dataGridViewDetail.AutoGenerateColumns = false;
                    this.dataGridViewDetail.DataSource = source;
                    this.dataGridViewDetail.RowHeadersVisible = false;
                    this.dataGridViewDetail.ColumnHeadersVisible = true;
                    this.dataGridViewDetail.CellBorderStyle = DataGridViewCellBorderStyle.None;
                }));
            }
            else
            {
                this.dataGridViewDetail.AutoGenerateColumns = false;
                this.dataGridViewDetail.DataSource = source;
                this.dataGridViewDetail.RowHeadersVisible = false;
                this.dataGridViewDetail.ColumnHeadersVisible = true;
                this.dataGridViewDetail.CellBorderStyle = DataGridViewCellBorderStyle.None;
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

        private void dataGridViewDetail_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewDetail.SelectedRows.Count > 0)
            {
                _IsRowSelected = true;

                if (this.dataGridViewDetail.SelectedRows.Count > 0)
                {
                    object uninstallString = this.dataGridViewDetail.SelectedRows[0].Cells[6].Value;
                    if (uninstallString != null && !string.IsNullOrEmpty(uninstallString.ToString()))
                    {
                        this.buttonUinstall.Enabled = true;
                        if (!string.IsNullOrEmpty(uninstallString.ToString()) && uninstallString.ToString().Contains("MsiExec.exe"))
                        {
                            this.buttonRepair.Enabled = true;
                        }
                        else
                        {
                            this.buttonRepair.Enabled = false;
                        }
                    }
                    else
                    {
                        this.buttonUinstall.Enabled = false;
                        this.buttonRepair.Enabled = false;
                    }
                }
            }
        }

        private void buttonUinstall_Click(object sender, EventArgs e)
        {
            string UninstallCommandString = string.Empty;
            if (!string.IsNullOrEmpty(this.dataGridViewDetail.SelectedRows[0].Cells[6].Value.ToString()))
            {
                UninstallCommandString = this.dataGridViewDetail.SelectedRows[0].Cells[6].Value.ToString();
            }



            string guid = UninstallCommandString.Replace("MsiExec.exe /I", "");

            Process p = new Process();
            if (UninstallCommandString.EndsWith(".exe"))
            {
                p.StartInfo.FileName = UninstallCommandString;
            }
            else
            {
                p.StartInfo.FileName = "msiexec.exe";
                p.StartInfo.Arguments = "/x " + guid;
            }
            p.Start();
        }

        private void buttonRepair_Click(object sender, EventArgs e)
        {
            ///fvomusa
            string UninstallCommandString = string.Empty;
            if (!string.IsNullOrEmpty(this.dataGridViewDetail.SelectedRows[0].Cells[6].Value.ToString()))
            {
                UninstallCommandString = this.dataGridViewDetail.SelectedRows[0].Cells[6].Value.ToString();
            }



            string guid = UninstallCommandString.Replace("MsiExec.exe /I", "");

            Process p = new Process();
            if (UninstallCommandString.EndsWith(".exe"))
            {
                p.StartInfo.FileName = UninstallCommandString;
            }
            else
            {
                p.StartInfo.FileName = "msiexec.exe";
                p.StartInfo.Arguments = "/fvomusa " + guid;
            }
            p.Start();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete Registry entry for this Program?", "Confirmation", MessageBoxButtons.YesNo);
            if( result == DialogResult.Yes)
            {
                string subKey = this.dataGridViewDetail.SelectedRows[0].Cells[this.dataGridViewDetail.SelectedRows[0].Cells.Count - 1].Value.ToString();
                using (var key = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall",true))
                {
                    try
                    {
                        key.DeleteSubKey(subKey);
                        MessageBox.Show("Program key is deleted from registry.");
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }
    }
}
