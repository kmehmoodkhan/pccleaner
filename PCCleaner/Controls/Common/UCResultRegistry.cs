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
        }

        public void ShowResult(ResultView view, ResultSummary summary)
        {

            if (view == ResultView.Detail)
            {
                this.dataGridViewDetail.Rows.Clear();

                this.dataGridViewDetail.Visible = true;

                var bindingList = new BindingList<ResultDetail>(summary.DetailResult);
                var source = new BindingSource(bindingList, null);
                this.dataGridViewDetail.AutoGenerateColumns = false;
                this.dataGridViewDetail.DataSource = source;
                this.dataGridViewDetail.RowHeadersVisible = false;
                this.dataGridViewDetail.ColumnHeadersVisible = true;
                this.dataGridViewDetail.CellBorderStyle = DataGridViewCellBorderStyle.None;
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
    }
}
