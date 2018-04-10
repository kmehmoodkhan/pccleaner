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
        private DataGridViewCellEventArgs mouseLocation;
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

        ResultSummary resultSummary = null;
        private ResultSummary ResultSummary
        {
            get
            {
                return resultSummary;
            }
            set
            {
                resultSummary = value;
            }
        }
        public UCResult()
        {
            InitializeComponent();
        }



        public void ShowResult(ResultView view, ResultSummary summary)
        {
            if (resultSummary == null)
            {
                resultSummary = summary;
            }
            if (view == ResultView.Detail)
            {
                this.dataGridViewDetail.Visible = true;
                this.dataGridViewOverall.Visible = false;

                var bindingList = new BindingList<ResultDetail>(summary.DetailResult);
                var source = new BindingSource(bindingList, null);
                this.dataGridViewDetail.AutoGenerateColumns = false;
                this.dataGridViewDetail.DataSource = source;
                this.dataGridViewDetail.RowHeadersVisible = false;
                this.dataGridViewDetail.ColumnHeadersVisible = false;
                this.dataGridViewDetail.CellBorderStyle = DataGridViewCellBorderStyle.None;

                this.panelStatus.Visible = false;
                this.labelNotes.Visible = false;
                this.buttonBack.Visible = true;
                this.lineBottom.Visible = false;
                this.lineTop.Visible = false;

            }
            else
            {
                if (this.dataGridViewOverall.InvokeRequired)
                {
                    this.dataGridViewOverall.Invoke(new MethodInvoker(delegate
                   {
                       ShowOverallResult(summary);
                   }));
                }
                else
                {
                    ShowOverallResult(summary);
                }
            }
        }

        private void ShowOverallResult(ResultSummary summary)
        {
            this.dataGridViewDetail.Visible = false;
            this.dataGridViewOverall.Visible = true;

            var bindingList = new BindingList<Result>(summary.OverallResult);
            var source = new BindingSource(bindingList, null);
            this.dataGridViewOverall.AutoGenerateColumns = false;
            this.dataGridViewOverall.DataSource = source;
            this.dataGridViewOverall.RowHeadersVisible = false;
            this.dataGridViewOverall.ColumnHeadersVisible = false;
            this.dataGridViewOverall.CellBorderStyle = DataGridViewCellBorderStyle.None;

            this.panelStatus.Visible = true;
            this.labelNotes.Visible = true;
            this.buttonBack.Visible = false;
            this.lineBottom.Visible = true;
            this.lineTop.Visible = true;
        }


        private void toolStripMenuItemViewDetail_Click(object sender, EventArgs e)
        {
            if (this.dataGridViewOverall.Rows.Count > 0)
            {
                string searchArea = this.dataGridViewOverall.Rows[mouseLocation.RowIndex].Cells[5].Value.ToString();
                string featureArea = this.dataGridViewOverall.Rows[mouseLocation.RowIndex].Cells[6].Value.ToString();
                SearchArea SelectedSearchArea = (PCCleaner.Common.SearchArea)Enum.Parse(typeof(PCCleaner.Common.SearchArea), searchArea);
                FeatureArea SelectedFeature = (PCCleaner.Common.FeatureArea)Enum.Parse(typeof(PCCleaner.Common.FeatureArea), featureArea);


                var filteredData = this.ResultSummary.DetailResult.Where(t => (int)t.SearchArea == (int)SelectedSearchArea && (int)t.FeatureArea == (int)SelectedFeature).ToList();
                

                ResultSummary summary = new ResultSummary(this.ResultSummary.OverallResult, filteredData);

                summary.DetailResult = filteredData;

                ShowResult(ResultView.Detail, summary);
            }
        }

        public void ShowExecutionTimke(double milliseconds)
        {
            double time = (milliseconds);
            this.labelTimeTaken.Text = " ( " + time + " seconds )";
        }

        private void dataGridViewOverall_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            mouseLocation = e;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            ShowResult(ResultView.Overall, this.ResultSummary);
        }
    }
}
