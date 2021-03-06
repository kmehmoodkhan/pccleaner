﻿using System;
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
            resultSummary = new ResultSummary();
            this.panelStatus.Show(); 
            //this.panelSearchComplete.Visible = true;
            this.panelSearchProgress.Show();
        }

        public void ResetView()
        {
            this.dataGridViewDetail.DataSource = null;
            this.dataGridViewOverall.DataSource = null;
        }

        public void ShowResult(ResultView view, ResultSummary summary,bool afterSearch=false)
        {
            if (this.panelSearchProgress.InvokeRequired)
            {
                this.panelSearchProgress.Invoke(new MethodInvoker(delegate
                {
                    this.panelSearchProgress.Show();
                }));
            }
            else
            {
                this.panelSearchProgress.Show();
            }

            if ( afterSearch)
            {
                if (this.labelResultHeading.InvokeRequired)
                {
                    this.labelResultHeading.Invoke(new MethodInvoker(delegate
                    {
                        labelResultHeading.Text = "Cleanup Completed";
                    }));
                }
                else
                {
                    labelResultHeading.Text = "Cleanup Completed";
                }
            }
            else
            {
                if (this.labelResultHeading.InvokeRequired)
                {
                    this.labelResultHeading.Invoke(new MethodInvoker(delegate
                    {
                        labelResultHeading.Text = "Analysis Complete";
                        panelSearchProgress.Hide();
                    }));
                }
                else
                {
                    labelResultHeading.Text = "Analysis Complete";
                    panelSearchProgress.Hide();
                }
            }
            var registryItemExists = false;

            if( summary.OverallResult.Exists(t=>t.SearchArea == PCCleaner.Common.SearchArea.Registry))
            {
                registryItemExists = true;
            }

            if (!registryItemExists)
            {
                if (view == ResultView.Detail)
                {
                    this.dataGridViewDetail.DataBindings.Clear();

                    this.dataGridViewDetail.Visible = true;
                    this.dataGridViewOverall.Visible = false;

                    var bindingList = new BindingList<ResultDetail>(summary.DetailResult);
                    var source = new BindingSource(bindingList, null);
                    this.dataGridViewDetail.AutoGenerateColumns = false;
                    this.dataGridViewDetail.DataSource = source;
                    this.dataGridViewDetail.RowHeadersVisible = false;
                    this.dataGridViewDetail.ColumnHeadersVisible = true;
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
                           ShowOverallResult(summary,afterSearch);
                       }));
                    }
                    else
                    {
                        ShowOverallResult(summary, afterSearch);
                    }
                }
            }
            else
            {

            }
        }

        private void ShowOverallResult(ResultSummary summary,bool afterSearch=false)
        {
            if (this.panelSearchProgress.InvokeRequired)
            {
                this.panelSearchProgress.Invoke(new MethodInvoker(delegate
                {
                    this.panelSearchProgress.Show();
                }));
            }
            else
            {
                this.panelSearchProgress.Show();
            }
            //this.panelSearchProgress.BackColor = Color.Green;

            if (afterSearch)
            {
                if (this.labelResultHeading.InvokeRequired)
                {
                    this.labelResultHeading.Invoke(new MethodInvoker(delegate
                    {
                        labelResultHeading.Text = "Cleanup Completed";
                    }));
                }
                else
                {
                    labelResultHeading.Text = "Cleanup Completed";
                }
            }
            else
            {
                if (this.panelSearchComplete.InvokeRequired)
                {
                    this.panelSearchComplete.Invoke(new MethodInvoker(delegate
                    {
                        panelSearchComplete.Visible = true;
                    }));
                }
                else
                {
                    panelSearchComplete.Visible = true;
                }

                if (this.panelSearchProgress.InvokeRequired)
                {
                    this.panelSearchProgress.Invoke(new MethodInvoker(delegate
                    {
                        panelSearchProgress.Visible = false;
                    }));
                }
                else
                {
                    panelSearchProgress.Visible = false;
                }

                if (this.labelResultHeading.InvokeRequired)
                {
                    this.labelResultHeading.Invoke(new MethodInvoker(delegate
                    {
                        labelResultHeading.Text = "Analysis Complete";
                    }));
                }
                else
                {
                    labelResultHeading.Text = "Analysis Complete";
                }
            }

            this.dataGridViewOverall.DataBindings.Clear();
            this.dataGridViewDetail.Visible = false;
            this.dataGridViewOverall.Visible = true;
            

            var bindingList = new BindingList<Result>(summary.OverallResult);
            var source = new BindingSource(bindingList, null);
            this.dataGridViewOverall.AutoGenerateColumns = false;
            this.dataGridViewOverall.DataSource = source;
            this.dataGridViewOverall.RowHeadersVisible = false;
            this.dataGridViewOverall.ColumnHeadersVisible = true;
            this.dataGridViewOverall.CellBorderStyle = DataGridViewCellBorderStyle.None;

            this.panelStatus.Visible = true;
            this.labelNotes.Visible = true;
            this.buttonBack.Visible = false;
            this.lineBottom.Visible = true;
            this.lineTop.Visible = true;
            panelSearchProgress.Hide();
        }


        private void toolStripMenuItemViewDetail_Click(object sender, EventArgs e)
        {
            if (this.dataGridViewOverall.Rows.Count > 0)
            {
                string searchArea = this.dataGridViewOverall.Rows[mouseLocation.RowIndex].Cells[5].Value.ToString();
                string featureArea = this.dataGridViewOverall.Rows[mouseLocation.RowIndex].Cells[6].Value.ToString();
                SearchArea SelectedSearchArea = (PCCleaner.Common.SearchArea)Enum.Parse(typeof(PCCleaner.Common.SearchArea), searchArea);
                FeatureArea SelectedFeature = (PCCleaner.Common.FeatureArea)Enum.Parse(typeof(PCCleaner.Common.FeatureArea), featureArea);


                var filteredData = CleanerApplicationContext.ResultSummary.DetailResult.Where(t => (int)t.SearchArea == (int)SelectedSearchArea && (int)t.FeatureArea == (int)SelectedFeature).ToList();

                this.ResultSummary.OverallResult = CleanerApplicationContext.ResultSummary.OverallResult;

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
