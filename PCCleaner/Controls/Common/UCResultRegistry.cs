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
using System.IO;

namespace PCCleaner.Controls.Common
{
    public partial class UCResultRegistry : UserControl
    {
        private List<string> FilesList = new List<string>();
        public UCResultRegistry()
        {
            InitializeComponent();
            selectedRegistryItems = new List<ResultDetail>();
        }

        private List<ResultDetail> selectedRegistryItems = null;

        public List<ResultDetail> SelectedRegistryItems
        {
            get
            {
                foreach(DataGridViewRow row in this.dataGridViewDetail.Rows )
                {
                    /*
                    DataGridViewCheckBoxCell cell = row.Cells[0] as DataGridViewCheckBoxCell;

                    //We don't want a null exception!
                    if (cell.Value != null)
                    {
                        if (Convert.ToBoolean(cell.Value)== true)
                        {
                            DataGridViewTextBoxCell data = row.Cells[2] as DataGridViewTextBoxCell;
                            DataGridViewTextBoxCell regKey = as DataGridViewTextBoxCell;

                            ///////////////////////////////////
                       

                            ResultDetail detail = new ResultDetail();

                            if(data.Value!=null)
                                detail.Data = data.Value.ToString();

                            if (regKey.Value != null)
                                detail.RegistryKey = regKey.Value.ToString();

                            selectedRegistryItems.Add(detail);
                        }
                    }
                    */

                    selectedRegistryItems = new List<ResultDetail>();
                    if (Convert.ToBoolean(row.Cells[0].Value) == true)
                    {
                        ResultDetail detail = new ResultDetail();
                        if(row.Cells[2].Value!=null && !string.IsNullOrEmpty(row.Cells[2].Value.ToString()))
                        {
                            detail.Data = row.Cells[2].Value.ToString();
                        }
                        if (row.Cells[3].Value != null && !string.IsNullOrEmpty(row.Cells[3].Value.ToString()))
                        {
                            detail.RegistryKey = row.Cells[3].Value.ToString();
                        }
                        selectedRegistryItems.Add(detail);
                    }

                }
                return selectedRegistryItems;
            }
        }
        public void ShowResult(ResultView view, ResultSummary summary)
        {
            var tempSummary = summary;

            if (view == ResultView.Detail)
            {
                //this.dataGridViewDetail.Rows.Clear();
                //this.dataGridViewDetail.DataBindings.Clear();
                

                this.dataGridViewDetail.AutoGenerateColumns = false;
                this.dataGridViewDetail.RowHeadersVisible = false;
                this.dataGridViewDetail.ColumnHeadersVisible = true;
                this.dataGridViewDetail.CellBorderStyle = DataGridViewCellBorderStyle.None;

                BindingList<ResultDetail> bindingList = new BindingList<ResultDetail>(summary.DetailResult);
                BindingSource source = new BindingSource(bindingList, null);

                this.dataGridViewDetail.DataSource = source;// tempSummary.DetailResult;

                //DataGridViewCheckBoxColumn colCB = new DataGridViewCheckBoxColumn();
                //DataGridViewCheckBoxHeaderCell cbHeader = new DatagridViewCheckBoxHeaderCell();
                //colCB.HeaderCell = cbHeader;
                //this.dataGridViewDetail.Columns.Add(colCB);
            }
        }

        private void openInRegistryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripMenuItemRegedit_Click(object sender, EventArgs e)
        {
            var item = this.dataGridViewDetail.SelectedCells[3].Value;
            
            string filename = Application.ExecutablePath.Replace("PCCleaner.exe","") +@"\regjump.exe";
            var proc = System.Diagnostics.Process.Start(filename, item.ToString());
        }

        private void toolStripMenuItemTextFile_Click(object sender, EventArgs e)
        {
            string filesData = this.dataGridViewDetail.Rows.ToString();
            //File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\registry.txt",filesData);

            string filePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\registry.txt";
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();
                fbd.SelectedPath = filePath;

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    File.WriteAllText(fbd.SelectedPath, filesData);
                }
            }
        }

        private void checkBoxCheckAll_CheckedChanged(object sender, EventArgs e)
        {
            foreach(DataGridViewRow row in this.dataGridViewDetail.Rows)
            {
                row.Cells[0].Value = checkBoxCheckAll.Checked;
            }
        }
    }
}
