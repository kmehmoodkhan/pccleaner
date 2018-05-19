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
using PCCleaner.Tools;
using System.IO;

namespace PCCleaner.Controls
{
    public partial class UCDiskResult : UserControl
    {

        List<string> drives = null;
        public List<string> Drives
        {
            get
            {
                return drives;
            }
        }

        List<int> fileFilter = null;
        public List<int> FilesFilters
        {
            get
            {
                return fileFilter;
            }
        }
        public UCDiskResult()
        {
            InitializeComponent();
            panelGrid.Hide();
            //panelSpaceCategories.Hide();
            labelAllCategories.Hide();
        }

        public UCDiskResult(List<string> drives, List<int> fileFilter) :this()
        {
            this.drives = drives;
            this.fileFilter = fileFilter;



            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.WorkerSupportsCancellation = true;

            backgroundWorker1.DoWork += new DoWorkEventHandler(backgroundWorker1_DoWork);
            backgroundWorker1.RunWorkerCompleted += new RunWorkerCompletedEventHandler(backgroundWorker1_RunWorkerCompleted);


            backgroundWorker1.RunWorkerAsync();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            var toolsControl = this.ParentForm.Controls.Find("Tools", true);
            if (toolsControl.Length > 0)
            {
                var parent = toolsControl[0] as UCTools;
                parent.ShowDiskAnalyzer();
                this.Dispose();
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            ToolsLibrary tools = new ToolsLibrary();

            if (this.pictureBoxLoader.InvokeRequired)
            {
                this.pictureBoxLoader.Invoke(new MethodInvoker(delegate
                {
                    this.pictureBoxLoader.Show();
                }));
            }
            else
            {
                this.pictureBoxLoader.Show();
            }

            if (this.labelProgressBar.InvokeRequired)
            {
                this.labelProgressBar.Invoke(new MethodInvoker(delegate
                {
                    this.labelProgressBar.Show();
                }));
            }
            else
            {
                this.labelProgressBar.Show();
            }
            

            var result = tools.SearchFiles(FilesFilters, Drives,ref labelProgressBar);

            var bindingList = new BindingList<DiskFileInfo>(result.ToList());
            var source = new BindingSource(bindingList, null);

            if (this.dataGridViewResult.InvokeRequired)
            {
                this.dataGridViewResult.Invoke(new MethodInvoker(delegate
                {
                    this.dataGridViewResult.AutoGenerateColumns = false;
                    this.dataGridViewResult.DataSource = source;
                    this.dataGridViewResult.RowHeadersVisible = false;
                    this.dataGridViewResult.ColumnHeadersVisible = true;
                    this.dataGridViewResult.CellBorderStyle = DataGridViewCellBorderStyle.None;
                }));
            }
            else
            {
                this.dataGridViewResult.AutoGenerateColumns = false;
                this.dataGridViewResult.DataSource = source;
                this.dataGridViewResult.RowHeadersVisible = false;
                this.dataGridViewResult.ColumnHeadersVisible = true;
                this.dataGridViewResult.CellBorderStyle = DataGridViewCellBorderStyle.None;
            }

            if (this.pictureBoxLoader.InvokeRequired)
            {
                this.pictureBoxLoader.Invoke(new MethodInvoker(delegate
                {
                    this.pictureBoxLoader.Hide();
                }));
            }
            else
            {
                this.pictureBoxLoader.Hide();
            }

            if (this.labelProgressBar.InvokeRequired)
            {
                this.labelProgressBar.Invoke(new MethodInvoker(delegate
                {
                    this.labelProgressBar.Hide();
                }));
            }
            else
            {
                this.labelProgressBar.Hide();
            }
        }



        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            panelMain.Show();
            panelGrid.Show();
            this.buttonBack.Show();
            this.panelLoader.Hide();
           // this.panelSpaceCategories.Show();
            labelAllCategories.Show();
        }
    }
}
