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
using PCCleaner.Tools;
using PCCleaner.Controls.Common;
using System.IO;

namespace PCCleaner.Controls
{
    public partial class UCDiskAnalyzer : UserControl
    {
        public UCDiskAnalyzer()
        {
            InitializeComponent();

            var disks = Helper.GetSystemDrives();
            //this.checkedListBoxDrives.dat

            ((ListBox)this.checkedListBoxDrives).DataSource = disks;
            ((ListBox)this.checkedListBoxDrives).DisplayMember = "Name";
            ((ListBox)this.checkedListBoxDrives).ValueMember = "Name";
        }

        private void buttonAnalyze_Click(object sender, EventArgs e)
        {
            List<string> drives = new List<string>();
            List<int> fileFilter = new List<int>();

            foreach( DriveInfo str in this.checkedListBoxDrives.CheckedItems)
            {
                drives.Add(str.Name);
            }


            fileFilter.Add((int)FileTypes.Pictures);
            var toolsControl = this.ParentForm.Controls.Find("Tools", true);
            if( toolsControl.Length > 0)
            {
                var parent = toolsControl[0] as UCTools;
                parent.ShowDiskAnalyzerResult(drives, fileFilter);
            }
        }
    }
}
