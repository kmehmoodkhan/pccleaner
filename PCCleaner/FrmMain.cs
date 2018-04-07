using PCCleaner.Common;
using PCCleaner.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCCleaner
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();

            var result = Helper.GetBrowserCachePath(SearchArea.Firefox);

            this.panelCleanerComponents.Controls.Add(new UCCleaner());
            this.labelClientInfo.Text = ApplicationSettings.SystemInformation;

            this.panelCleanerComponents.HorizontalScroll.Maximum = 0;
            this.panelCleanerComponents.AutoScroll = false;
            this.panelCleanerComponents.VerticalScroll.Visible = false;
            this.panelCleanerComponents.AutoScroll = true;

            this.progressBar1.Width = this.panelProgress.Width - 100;

            this.backgroundWorkerSearch.WorkerReportsProgress = true;
            this.backgroundWorkerSearch.WorkerSupportsCancellation = true;

            this.backgroundWorkerSearch.DoWork += backgroundWorkerSearch_DoWork;
            this.backgroundWorkerSearch.ProgressChanged += backgroundWorkerSearch_ProgressChanged;
            // this.progressBar1.Value = 80;

        }

        private void buttonRegistry_Click(object sender, EventArgs e)
        {
            buttonRegistry.BackColor = ApplicationSettings.SelectedButtonColor;
            buttonCleaner.BackColor = ApplicationSettings.NormalButtonColor;
            buttonTools.BackColor = ApplicationSettings.NormalButtonColor;
            buttonOptions.BackColor = ApplicationSettings.NormalButtonColor;
        }

        private void buttonCleaner_Click(object sender, EventArgs e)
        {
            buttonCleaner.BackColor = ApplicationSettings.SelectedButtonColor;
            buttonRegistry.BackColor = ApplicationSettings.NormalButtonColor;
            buttonTools.BackColor = ApplicationSettings.NormalButtonColor;
            buttonOptions.BackColor = ApplicationSettings.NormalButtonColor;
        }

        private void buttonTools_Click(object sender, EventArgs e)
        {
            buttonTools.BackColor = ApplicationSettings.SelectedButtonColor;
            buttonCleaner.BackColor = ApplicationSettings.NormalButtonColor;
            buttonRegistry.BackColor = ApplicationSettings.NormalButtonColor;
            buttonOptions.BackColor = ApplicationSettings.NormalButtonColor;
        }

        private void buttonOptions_Click(object sender, EventArgs e)
        {
            buttonOptions.BackColor = ApplicationSettings.SelectedButtonColor;
            buttonTools.BackColor = ApplicationSettings.NormalButtonColor;
            buttonCleaner.BackColor = ApplicationSettings.NormalButtonColor;
            buttonRegistry.BackColor = ApplicationSettings.NormalButtonColor;
        }

        private void buttonAnalyze_Click(object sender, EventArgs e)
        {
            backgroundWorkerSearch.RunWorkerAsync();
        }

        public void ProcessSearch()
        {
            if (this.progressBar1.InvokeRequired)
            {
                this.progressBar1.Invoke(new MethodInvoker(delegate
                {
                    this.progressBar1.Visible = true;
                }));
            };

            var edgeSelectedItems = this.Edge.SelectedItems;

            List<SearchCriteria> searchCriteria = new List<SearchCriteria>();



            if (edgeSelectedItems != null && edgeSelectedItems.Count > 0)
            {
                foreach (var item in edgeSelectedItems)
                {
                    SearchCriteria criteria = new SearchCriteria() { SearchArea = (int)SearchArea.Edge, FeatureId = item.ItemId };
                    searchCriteria.Add(criteria);
                }
            }

            var result = Analyzer.GetSearchResults(searchCriteria, ref this.backgroundWorkerSearch);
            var overAllResult = Analyzer.GetOverallResult(result);
            this.ucResult.ShowResult(ResultView.Overall, overAllResult);
        }

        private void backgroundWorkerSearch_DoWork(object sender, DoWorkEventArgs e)
        {
            ProcessSearch();
        }

        private void backgroundWorkerSearch_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
            if (e.ProgressPercentage == 100)
            {
                if (this.panelProgress.Controls.Find("lblCompletion", true).Count() < 1)
                {
                    int i = 2;
                    //this.panelProgress.Controls.Add(new Label() { Text = "100%", Name = "lblCompletion" });
                }
            }
        }

    }
}
