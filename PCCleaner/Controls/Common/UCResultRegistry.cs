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
using System.Diagnostics;

namespace PCCleaner.Controls.Common
{
    public partial class UCResultRegistry : UserControl
    {
        private List<string> FilesList = new List<string>();
        public UCResultRegistry()
        {
            InitializeComponent();
            _RegistryResult = new List<ResultDetail>();
            _SelectedRows = new List<ResultDetail>();

            Point headerCellLocation = this.dataGridViewDetail.GetCellDisplayRectangle(0, -1, true).Location;

            //Place the Header CheckBox in the Location of the Header Cell.
            //checkBoxCheckAll.Location = new Point(headerCellLocation.X + 8, headerCellLocation.Y + 2);
            checkBoxCheckAll.BackColor = Color.White;
            checkBoxCheckAll.Size = new Size(18, 18);

            //Assign Click event to the Header CheckBox.
            this.dataGridViewDetail.Controls.Add(checkBoxCheckAll);
        }

        private List<ResultDetail> _RegistryResult = null;
        private List<ResultDetail> RegistryResult
        {
            get
            {
                return _RegistryResult;
            }
            set
            {
                _RegistryResult = value;
            }
        }

        private List<ResultDetail> _SelectedRows = null;
        public List<ResultDetail> SelectedRows
        {
            get
            {
                return _SelectedRows;
            }
            set
            {
                _SelectedRows = value;
            }
        }

        private void BindGrid()
        {
            ProcessThreadCollection currentThreads = Process.GetCurrentProcess().Threads;
            

            if (dataGridViewDetail.InvokeRequired)
            {
                this.dataGridViewDetail.Invoke(new MethodInvoker(delegate
                {
                    this.dataGridViewDetail.DataSource = null;

                    this.dataGridViewDetail.AutoGenerateColumns = false;
                    this.dataGridViewDetail.RowHeadersVisible = false;
                    this.dataGridViewDetail.ColumnHeadersVisible = true;
                    this.dataGridViewDetail.CellBorderStyle = DataGridViewCellBorderStyle.None;

                    //BindingList<ResultDetail> bindingList = new BindingList<ResultDetail>(RegistryResult);
                    //BindingSource source = new BindingSource(bindingList, null);

                    this.dataGridViewDetail.DataSource = RegistryResult;
                }));
            }
            else
            {
                this.dataGridViewDetail.DataSource = null;

                this.dataGridViewDetail.AutoGenerateColumns = false;
                this.dataGridViewDetail.RowHeadersVisible = false;
                this.dataGridViewDetail.ColumnHeadersVisible = true;
                this.dataGridViewDetail.CellBorderStyle = DataGridViewCellBorderStyle.None;

                //BindingList<ResultDetail> bindingList = new BindingList<ResultDetail>(RegistryResult);
                //BindingSource source = new BindingSource(bindingList, null);

                //source.CurrencyManager.Refresh();

                try
                {
                    this.dataGridViewDetail.DataSource = RegistryResult;
                    this.dataGridViewDetail.EndEdit();
                    this.dataGridViewDetail.Refresh();
                }
                catch(Exception ex)
                {
                    ;
                }
            }
        }


        public void ShowResult(ResultView view, ResultSummary summary)
        {
            _RegistryResult = summary.DetailResult;

            if (view == ResultView.Detail)
            {
                BindGrid();
            }
        }

        private void openInRegistryToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItemRegedit_Click(object sender, EventArgs e)
        {
            var item = this.dataGridViewDetail.SelectedCells[3].Value;

            string filename = Application.ExecutablePath.Replace("PCOptimizer.exe", "") + @"\regjump.exe";
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
            try
            {

                if (checkBoxCheckAll.Checked)
                {
                    _SelectedRows = this._RegistryResult;
                }
                else
                {
                    _SelectedRows.Clear();
                }

                if (this.dataGridViewDetail.Rows.Count > 0)
                {

                    foreach (DataGridViewRow row in this.dataGridViewDetail.Rows)
                    {
                        if (row != null && row.Cells.Count > 0)
                        {
                            if (row.Cells.Count > 0)
                            {
                                row.Cells[0].Value = checkBoxCheckAll.Checked;
                            }
                        }
                    }
                    dataGridViewDetail.EndEdit();
                }

            }

            catch (System.IndexOutOfRangeException ex)  // CS0168)
            {
                ;
            }
            catch (Exception ex)
            {
                ;
            }
        }


        private void dataGridViewDetail_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dataGridViewDetail.IsCurrentCellDirty)
            {
                dataGridViewDetail.CommitEdit(DataGridViewDataErrorContexts.Commit);
                // BindGrid();
            }
        }

        private void dataGridViewDetail_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            this.dataGridViewDetail.EndEdit();

            if (e.ColumnIndex == 0)
            {
                var temp = Convert.ToBoolean(this.dataGridViewDetail[0, e.RowIndex].Value);
                var trueValue = ((DataGridViewCheckBoxColumn)dataGridViewDetail.Columns["checkBoxSelect"]).TrueValue;
                var falseValue = ((DataGridViewCheckBoxColumn)dataGridViewDetail.Columns["checkBoxSelect"]).FalseValue;

                var cbxCell = (DataGridViewCheckBoxCell)dataGridViewDetail.Rows[e.RowIndex].Cells["checkBoxSelect"];
                var result = ((bool)cbxCell.Value);

                DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)dataGridViewDetail.Rows[e.RowIndex].Cells[0];

                var dataGridView = sender as DataGridView;

                if ((Convert.ToBoolean(chk.Value )== Convert.ToBoolean(chk.FalseValue)) || (chk.Value == null))
                {
                    chk.Value = chk.TrueValue;
                }
                else
                {
                    chk.Value = chk.FalseValue;
                   
                }




                var isChecked = this.dataGridViewDetail.Rows[e.RowIndex].Cells[0].Value;
                if (Convert.ToBoolean(isChecked))
                {
                    ResultDetail detail = new ResultDetail();
                    if (this.dataGridViewDetail.Rows[e.RowIndex].Cells[2].Value != null && !string.IsNullOrEmpty(this.dataGridViewDetail.Rows[e.RowIndex].Cells[2].Value.ToString()))
                    {
                        detail.Data = this.dataGridViewDetail.Rows[e.RowIndex].Cells[2].Value.ToString();
                    }
                    if (this.dataGridViewDetail.Rows[e.RowIndex].Cells[3].Value != null && !string.IsNullOrEmpty(this.dataGridViewDetail.Rows[e.RowIndex].Cells[3].Value.ToString()))
                    {
                        detail.RegistryKey = this.dataGridViewDetail.Rows[e.RowIndex].Cells[3].Value.ToString();
                    }
                    SelectedRows.Add(detail);
                }
                else
                {
                    var data = this.dataGridViewDetail.Rows[e.RowIndex].Cells[2].Value.ToString();
                    var registryKey = this.dataGridViewDetail.Rows[e.RowIndex].Cells[3].Value.ToString();
                    registryKey = registryKey.Replace("HKCU\\", "");

                    registryKey = registryKey.Replace("HKLM\\", "");

                    int index = SelectedRows.FindIndex(t => t.RegistryKey == registryKey && t.Data == data);
                    if (index > 0)
                        SelectedRows.RemoveAt(index);
                }
            }

            //Loop and check and uncheck all row CheckBoxes based on Header Cell CheckBox.
            //foreach (DataGridViewRow row in dataGridViewDetail.Rows)
            //{
            //    DataGridViewCheckBoxCell checkBox = (row.Cells["checkBoxSelect"] as DataGridViewCheckBoxCell);
            //    checkBox.Value = this.checkBoxCheckAll.Checked;
            //}

           
        }


        private void dataGridViewDetail_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (e.Exception != null)
            {
                BindGrid();
            }
        }

        private void dataGridViewDetail_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == checkBoxSelect.Index && e.RowIndex != -1)
            {
                //this.dataGridViewDetail.EndEdit();
            }
        }

        private void dataGridViewDetail_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex == 0)
            {

            }
        }

        private void checkBoxCheckAll_Click(object sender, EventArgs e)
        {
            this.dataGridViewDetail.EndEdit();


            //Loop and check and uncheck all row CheckBoxes based on Header Cell CheckBox.
            foreach (DataGridViewRow row in dataGridViewDetail.Rows)
            {
                DataGridViewCheckBoxCell checkBox = (row.Cells["checkBoxSelect"] as DataGridViewCheckBoxCell);
                checkBox.Value = this.checkBoxCheckAll.Checked;
            }
        }

        private void dataGridViewDetail_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                DataGridViewCheckBoxCell cell = (sender as DataGridView).Rows[e.RowIndex].Cells[e.ColumnIndex] as DataGridViewCheckBoxCell;

                //if (cell != null)
                //{
                //    //if (cell.Value == cell.TrueValue)
                    //    //{                   //    //    MessageBox.Show("Cell checked.");
                //    //}
                //    //else
                //    //{
                //    //    MessageBox.Show("Cell unchecked.");
                //    //}
                //}
            }
        }

       
    }
}

