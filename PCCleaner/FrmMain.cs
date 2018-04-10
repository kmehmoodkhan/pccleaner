using PCCleaner.Common;
using PCCleaner.Controls;
using PCCleaner.Controls.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCCleaner
{
    public partial class FrmMain : Form
    {

        private List<ResultDetail> FilesFound = null;
        public FrmMain()
        {
            InitializeComponent();
            FilesFound = new List<ResultDetail>();

            this.panelCleanerComponents.Controls.Add(new UCCleaner());
            this.labelClientInfo.Text = ApplicationSettings.SystemInformation;

            this.panelCleanerComponents.HorizontalScroll.Maximum = 0;
            this.panelCleanerComponents.AutoScroll = false;
            this.panelCleanerComponents.VerticalScroll.Visible = false;
            this.panelCleanerComponents.AutoScroll = true;

            this.progressBar1.Width = this.panelProgress.Width - 100;

            this.backgroundWorkerSearch.WorkerReportsProgress = true;
            this.backgroundWorkerSearch.WorkerSupportsCancellation = true;


            this.ucResult.Visible = false;

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
            try
            {
                ucResult.Visible = true;
                Stopwatch stopwatch = Stopwatch.StartNew();
                backgroundWorkerSearch.RunWorkerAsync();
                stopwatch.Stop();
                ucResult.ShowExecutionTimke(stopwatch.Elapsed.TotalMilliseconds);
            }
            catch(Exception ex)
            {
                this.backgroundWorkerSearch.DoWork -= backgroundWorkerSearch_DoWork;
                this.backgroundWorkerSearch.ProgressChanged -= backgroundWorkerSearch_ProgressChanged;

                ucResult.Visible = true;
                Stopwatch stopwatch = Stopwatch.StartNew();
                backgroundWorkerSearch.RunWorkerAsync();
                stopwatch.Stop();
                ucResult.ShowExecutionTimke(stopwatch.Elapsed.TotalMilliseconds);
            }
        }

        public void ProcessSearch()
        {
            this.backgroundWorkerSearch.DoWork += backgroundWorkerSearch_DoWork;
            this.backgroundWorkerSearch.ProgressChanged += backgroundWorkerSearch_ProgressChanged;
            

            if (this.progressBar1.InvokeRequired)
            {
                this.progressBar1.Invoke(new MethodInvoker(delegate
                {
                    this.progressBar1.Visible = true;
                }));
            };

            List<SearchCriteria> searchCriteria = GetSearchCriteria();

            var result = Analyzer.GetSearchResults(searchCriteria, ref this.backgroundWorkerSearch);
            var overAllResult = Analyzer.GetOverallResult(result);
            this.ucResult.ShowResult(ResultView.Overall, overAllResult);
            this.FilesFound = result;

            this.backgroundWorkerSearch.DoWork -= backgroundWorkerSearch_DoWork;
            this.backgroundWorkerSearch.ProgressChanged -= backgroundWorkerSearch_ProgressChanged;
        }

        private void backgroundWorkerSearch_DoWork(object sender, DoWorkEventArgs e)
        {
            ProcessSearch();
        }

        private List<SearchCriteria> GetSearchCriteria()
        {
            var edgeSelectedItems = this.Edge.SelectedItems;

            List<ListItem> ieSelectedItems = null;
            try
            {
                ieSelectedItems = this.IE.SelectedItems;
            }
            catch
            {
                ;
            }

            List<ListItem> chromeSelectedItems = null;
            try
            {
                chromeSelectedItems = this.Chrome.SelectedItems;
            }
            catch
            {
                ;
            }


            List<ListItem> firefoxSelectedItems = null;
            try
            {
                firefoxSelectedItems = this.Firefox.SelectedItems;
            }
            catch
            {
                ;
            }

            List<ListItem> windowExplorerSelectedItems = null;
            try
            {
                windowExplorerSelectedItems = this.WindowExplorer.SelectedItems;
            }
            catch
            {
                ;
            }


            List<ListItem> systemSelectedItems = null;
            try
            {
                systemSelectedItems = this.SystemArea.SelectedItems;
            }
            catch
            {
                ;
            }


            List<ListItem> advancedSelectedItems = null;
            try
            {
                advancedSelectedItems = this.Advanced.SelectedItems;
            }
            catch
            {
                ;
            }


            List<ListItem> windowStoreItems = null;
            try
            {
                windowStoreItems = this.WindowsStore.SelectedItems;
            }
            catch
            {
                ;
            }


            List<ListItem> applicationItems = null;
            try
            {
                applicationItems = this.Applications.SelectedItems;
            }
            catch
            {
                ;
            }


            List<ListItem> internetItems = null;
            try
            {
                internetItems = this.Internet.SelectedItems;
            }
            catch
            {
                ;
            }


            List<ListItem> teamViewerItems = null;
            try
            {
                teamViewerItems = this.Utilities.SelectedItems;
            }
            catch
            {
                ;
            }


            List<ListItem> windowsItems = null;
            try
            {
                windowsItems = this.Windows.SelectedItems;
            }
            catch
            {
                ;
            }
            

            List<SearchCriteria> searchCriteria = new List<SearchCriteria>();

            
            if (edgeSelectedItems != null && edgeSelectedItems.Count > 0)
            {
                foreach (var item in edgeSelectedItems)
                {
                    SearchCriteria criteria = new SearchCriteria() { SearchArea = (int)SearchArea.Edge, FeatureId = item.ItemId };
                    searchCriteria.Add(criteria);
                }
            }

            if (ieSelectedItems != null && ieSelectedItems.Count > 0)
            {
                foreach (var item in ieSelectedItems)
                {
                    SearchCriteria criteria = new SearchCriteria() { SearchArea = (int)SearchArea.IE, FeatureId = item.ItemId };
                    searchCriteria.Add(criteria);
                }
            }

            if (chromeSelectedItems != null && chromeSelectedItems.Count > 0)
            {
                foreach (var item in chromeSelectedItems)
                {
                    SearchCriteria criteria = new SearchCriteria() { SearchArea = (int)SearchArea.Chrome, FeatureId = item.ItemId };
                    searchCriteria.Add(criteria);
                }
            }

            if (firefoxSelectedItems != null && firefoxSelectedItems.Count > 0)
            {
                foreach (var item in firefoxSelectedItems)
                {
                    SearchCriteria criteria = new SearchCriteria() { SearchArea = (int)SearchArea.Firefox, FeatureId = item.ItemId };
                    searchCriteria.Add(criteria);
                }
            }

            if (windowExplorerSelectedItems != null && windowExplorerSelectedItems.Count > 0)
            {
                foreach (var item in windowExplorerSelectedItems)
                {
                    SearchCriteria criteria = new SearchCriteria() { SearchArea = (int)SearchArea.WindowExplorer, FeatureId = item.ItemId };
                    searchCriteria.Add(criteria);
                }
            }

            if (systemSelectedItems != null && systemSelectedItems.Count > 0)
            {
                foreach (var item in systemSelectedItems)
                {
                    SearchCriteria criteria = new SearchCriteria() { SearchArea = (int)SearchArea.System, FeatureId = item.ItemId };
                    searchCriteria.Add(criteria);
                }
            }

            if (advancedSelectedItems != null && advancedSelectedItems.Count > 0)
            {
                foreach (var item in advancedSelectedItems)
                {
                    SearchCriteria criteria = new SearchCriteria() { SearchArea = (int)SearchArea.Advanced, FeatureId = item.ItemId };
                    searchCriteria.Add(criteria);
                }
            }

            if (windowStoreItems != null && windowStoreItems.Count > 0)
            {
                foreach (var item in windowStoreItems)
                {
                    SearchCriteria criteria = new SearchCriteria() { SearchArea = (int)SearchArea.WindowsStore, FeatureId = item.ItemId };
                    searchCriteria.Add(criteria);
                }
            }

            if (applicationItems != null && applicationItems.Count > 0)
            {
                foreach (var item in applicationItems)
                {
                    SearchCriteria criteria = new SearchCriteria() { SearchArea = (int)SearchArea.Applications, FeatureId = item.ItemId };
                    searchCriteria.Add(criteria);
                }
            }

            if (internetItems != null && internetItems.Count > 0)
            {
                foreach (var item in internetItems)
                {
                    SearchCriteria criteria = new SearchCriteria() { SearchArea = (int)SearchArea.Internet, FeatureId = item.ItemId };
                    searchCriteria.Add(criteria);
                }
            }


            if (teamViewerItems != null && teamViewerItems.Count > 0)
            {
                foreach (var item in teamViewerItems)
                {
                    SearchCriteria criteria = new SearchCriteria() { SearchArea = (int)SearchArea.Utilities, FeatureId = item.ItemId };
                    searchCriteria.Add(criteria);
                }
            }

            if (windowsItems != null && windowsItems.Count > 0)
            {
                foreach (var item in windowsItems)
                {
                    SearchCriteria criteria = new SearchCriteria() { SearchArea = (int)SearchArea.Windows, FeatureId = item.ItemId };
                    searchCriteria.Add(criteria);
                }
            }
            return searchCriteria;
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



        private void buttonCleaner1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("The selected files will be deleted from you PC.\n Do you wish to continue", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                try
                {
                    var searchCriteria = GetSearchCriteria();
                    var filesFound = Analyzer.GetSearchResults(searchCriteria, ref this.backgroundWorkerSearch);
                    Cleaner.CleanUpSystem(searchCriteria, filesFound, ref this.backgroundWorkerSearch);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
