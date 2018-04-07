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

namespace PCCleaner.Controls.Common
{
    public partial class UCResult : UserControl
    {
        ResultView resultView = ResultView.Overall;
        public ResultView ResultView
        {
            set
            {
                resultView = value;
            }
            get
            {
                return resultView;
            }
        }
        public UCResult()
        {
            InitializeComponent();
        }



        public void ShowResult(ResultView view, ResultSummary summar)
        {

            if (view == ResultView.Detail)
            {
                if (this.dataGridViewDetail.InvokeRequired)
                {
                    this.dataGridViewDetail.Invoke(new MethodInvoker(delegate
                    {
                        this.dataGridViewDetail.Visible = true;
                        this.dataGridViewOverall.Visible = false;

                        var bindingList = new BindingList<ResultDetail>(summar.DetailResult);
                        var source = new BindingSource(bindingList, null);
                        this.dataGridViewDetail.AutoGenerateColumns = false;
                        this.dataGridViewDetail.DataSource = source;
                        this.dataGridViewDetail.RowHeadersVisible = false;
                        this.dataGridViewDetail.ColumnHeadersVisible = false;
                        this.dataGridViewDetail.CellBorderStyle = DataGridViewCellBorderStyle.None;
                    }));
                }

            }
            else
            {
                if (this.dataGridViewOverall.InvokeRequired)
                {
                    this.dataGridViewDetail.Invoke(new MethodInvoker(delegate
                   {
                       this.dataGridViewDetail.Visible = false;
                       this.dataGridViewOverall.Visible = true;

                       var bindingList = new BindingList<Result>(summar.OverallResult);
                       var source = new BindingSource(bindingList, null);
                       this.dataGridViewOverall.AutoGenerateColumns = false;
                       this.dataGridViewOverall.DataSource = source;
                       this.dataGridViewOverall.RowHeadersVisible = false;
                       this.dataGridViewOverall.ColumnHeadersVisible = false;
                       this.dataGridViewOverall.CellBorderStyle = DataGridViewCellBorderStyle.None;
                   }));             
                }
            }
        }


        private void toolStripMenuItemViewDetail_Click(object sender, EventArgs e)
        {

        }

        public void ShowExecutionTimke(double milliseconds)
        {
            double time = (milliseconds / 1000);
            this.labelTimeTaken.Text = " ( " + time + " seconds )";
        }
    }
}
