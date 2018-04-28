using PCCleaner.Common;
using PCCleaner.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCCleaner.Controls.Options
{
    public partial class FrmAddItem : Form
    {
        public FrmAddItem()
        {
            InitializeComponent();
            this.groupBoxMain.Text = this.Title;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;

            this.radioButtonFolder.Checked = true;
            this.textBoxFolderPath.Enabled = true;

            this.textBoxFilePath.Enabled = false;
            this.textBoxRegistryKey.Enabled = false;

            this.radioButtonAllFiles.Checked = true;
            this.textBoxFileTypeFilter.Enabled = false;
        }


        string title = string.Empty;
        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
            }
        }
        bool isInclude = false;
        public bool IsInclude
        {
            get
            {
                return isInclude;
            }
            set
            {
                isInclude = value;
                if (isInclude == true)
                {
                    this.Text = "Include";
                    this.Title = this.Text;
                    this.groupBoxMain.Text = this.Title;
                }
                else
                {
                    this.Text = "Exclude";
                    this.Title = this.Text;
                    this.groupBoxMain.Text = this.Title;
                }
            }
        }

        public string ItemPath
        {
            set{
                if (!string.IsNullOrEmpty(value))
                {
                    if (ItemType == 1)
                    {
                        this.textBoxFolderPath.Text = value;
                    }
                    else if( ItemType == 2)
                    {
                        this.textBoxFilePath.Text = value;
                    }
                    else if (ItemType == 3)
                    {
                        this.textBoxRegistryKey.Text = value;
                    }
                }
            }
        }


        private int _ItemType;
        public int ItemType
        {
            get
            {
                return _ItemType;
            }
            set
            {
                _ItemType = value;
                if ( value == 1)
                {
                    this.radioButtonFolder.Checked = true;
                }else if (value == 2)
                {
                    this.radioButtonFile.Checked = true;
                }
                else if (value == 3)
                {
                    this.radioButtonRegistry.Checked = true;
                }
            }
        }
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioButtonFolder_CheckedChanged(object sender, EventArgs e)
        {
            if(this.radioButtonFolder.Checked)
            {
                this.textBoxFolderPath.Enabled = true;
                this.buttonFolderBrowse.Enabled = true;
            }
            else
            {
                this.textBoxFolderPath.Enabled = false;
                this.buttonFolderBrowse.Enabled = false;
                this.textBoxFolderPath.Text = string.Empty;
            }
        }

        private void radioButtonFile_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButtonFile.Checked)
            {
                this.textBoxFilePath.Enabled = true;
                this.buttonFileBrowse.Enabled = true;
                this.textBoxFolderPath.Text = string.Empty;
            }
            else
            {
                this.textBoxFilePath.Enabled = false;
                this.buttonFileBrowse.Enabled = false;
                this.textBoxFilePath.Text = string.Empty;
            }
        }

        private void radioButtonRegistry_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButtonRegistry.Checked)
            {
                this.textBoxRegistryKey.Enabled = true;
            }
            else
            {
                this.textBoxRegistryKey.Enabled = false;
                this.textBoxRegistryKey.Text = string.Empty;
            }            
        }

        private void radioButtonAllFiles_CheckedChanged(object sender, EventArgs e)
        {
            if (!this.radioButtonAllFiles.Checked)
            {
                this.textBoxFileTypeFilter.Enabled = true;
            }
            else
            {
                this.textBoxFileTypeFilter.Enabled = false;
            }
            
        }

        private void radioButtonFileTypes_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButtonFileTypes.Checked)
            {
                this.textBoxFileTypeFilter.Enabled = true;
            }
            else
            {
                this.textBoxFileTypeFilter.Enabled = false;
            }
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            string path = "";
            string filterType = "";
            int itemType = 1;

            if (!string.IsNullOrEmpty(this.textBoxFolderPath.Text))
            {
                path = this.textBoxFolderPath.Text;
                itemType = 1;
            }
            else if (!string.IsNullOrEmpty(this.textBoxFilePath.Text))
            {
                path = this.textBoxFilePath.Text;
                itemType = 2;
            }
            else if (!string.IsNullOrEmpty(this.textBoxRegistryKey.Text))
            {
                path = this.textBoxRegistryKey.Text;
                itemType = 3;
            }


            if (!string.IsNullOrEmpty(this.textBoxFileTypeFilter.Text))
            {
                filterType = this.textBoxFileTypeFilter.Text;
            }



            var result = IncludeExcludeOptions.AddNewItem(path, itemType, filterType,isInclude);
            if(IsInclude)
            {
                var control = this.Owner.Controls.Find("Include", true)[0] as UCIncludeExclude;
                control.ShowListing();
                this.Close();
            }
            var parent = this.Parent;
        }

        private void buttonFolderBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            DialogResult result = dialog.ShowDialog();

            if( result == DialogResult.OK)
            {
                this.textBoxFolderPath.Text = dialog.SelectedPath;
            }
        }

        private void buttonFileBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            DialogResult result = dialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                this.textBoxFilePath.Text = dialog.FileName;
            }
        }
    }
}
