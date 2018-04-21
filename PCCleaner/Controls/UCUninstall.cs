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
            using (Microsoft.Win32.RegistryKey key = Registry.LocalMachine.OpenSubKey(registry_key))
            {
                foreach (string subkey_name in key.GetSubKeyNames())
                {
                    using (RegistryKey subkey = key.OpenSubKey(subkey_name))
                    {
                        if (subkey.GetValue("DisplayIcon") != null) { 
                        PCCleaner.Common.Program program = new PCCleaner.Common.Program();

                            if (subkey.GetValue("DisplayName") != null)
                            {
                                try
                                {
                                    program.ProgramName = subkey.GetValue("DisplayName").ToString();
                                }
                                catch (Exception ex)
                                {
                                    ;
                                }

                                try
                                {
                                    program.Version = subkey.GetValue("DisplayVersion").ToString();
                                }
                                catch (Exception ex)
                                {
                                    ;
                                }

                                try
                                {
                                    program.Publisher = subkey.GetValue("Publisher").ToString();
                                }
                                catch (Exception ex)
                                {
                                    ;
                                }


                                try
                                {
                                    var tempSize = subkey.GetValue("EstimatedSize").ToString();

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
                                catch (Exception ex)
                                {
                                    ;
                                }

                                try
                                {
                                    program.Version = subkey.GetValue("DisplayVersion").ToString();
                                }
                                catch (Exception ex)
                                {
                                    ;
                                }

                                try
                                {

                                    program.LauncherPath = subkey.GetValue("DisplayIcon").ToString();

                                    try
                                    {
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
                                }
                                catch (Exception ex)
                                {
                                    ;
                                }

                                try
                                {
                                    program.UninstallString = subkey.GetValue("UninstallString").ToString();
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
                    }
                }
            }

            var bindingList = new BindingList<PCCleaner.Common.Program>(prog.OrderBy(t=>t.ProgramName).ToList());
            var source = new BindingSource(bindingList, null);
            this.dataGridViewDetail.AutoGenerateColumns = false;
            this.dataGridViewDetail.DataSource = source;
            this.dataGridViewDetail.RowHeadersVisible = false;
            this.dataGridViewDetail.ColumnHeadersVisible = true;
            this.dataGridViewDetail.CellBorderStyle = DataGridViewCellBorderStyle.None;
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
            if(dataGridViewDetail.SelectedRows.Count > 0)
            {
                _IsRowSelected = true;
            }
        }

    }
}
