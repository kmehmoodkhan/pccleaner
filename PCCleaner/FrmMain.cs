using PCCleaner.Common;
using PCCleaner.Controls;
using PCCleaner.Controls.Common;
using PCCleaner.DataAccess;
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

        bool IsTrialExpired = false;

        private ref Label ProgressBarLabel
        {
            get
            {
                return ref this.ucResult.labelProgressBar;
            }
        }


        bool IsCleanerCall = false;
        public ApplicationItem SelectedItem
        {
            get;
            set;
        }
        private List<ResultDetail> FilesFound = null;

        private bool IsSubValid = false;
        private bool IsSubscriptionExists = false;
        public FrmMain()
        {
            InitializeComponent();

            FilesFound = new List<ResultDetail>();

            //this.panelCleanerComponents.Controls.Add(new UCCleaner());
            this.labelClientInfo.Text = ApplicationSettings.SystemInformation;

            this.panelCleanerComponents.HorizontalScroll.Maximum = 0;
            this.panelCleanerComponents.AutoScroll = false;
            this.panelCleanerComponents.VerticalScroll.Visible = false;
            this.panelCleanerComponents.AutoScroll = true;

            this.progressBar1.Width = this.panelProgress.Width - 100;

            this.backgroundWorkerSearch.WorkerReportsProgress = true;
            this.backgroundWorkerSearch.WorkerSupportsCancellation = true;

            SelectedItem = ApplicationItem.Cleaner;

            this.ucResult.Visible = false;

            try
            {
              IsSubValid= OptionsAdvanceSetting.IsSubscriptionValid(this);
                IsSubscriptionExists = true;
            }
            catch (Exception ex)
            {
                OptionsAdvanceSetting.StartTrialPeriod();
                
            }
        }

        public void ShowSubscriptionForm()
        {
            if (panelCleanerComponents.Controls.Find("ucCleaner1", false).Count() > 0)
            {
                UCCleaner registry = panelCleanerComponents.Controls.Find("ucCleaner1", false)[0] as UCCleaner;
                registry.Hide();
            }

            UCOptions tools = new UCOptions();
            tools.Name = "Options";
            tools.Dock = DockStyle.Fill;
            foreach (Control ctrl in this.gboxResult.Controls)
            {
                ctrl.Visible = false;
            }
            this.gboxResult.Controls.Add(tools);
            
        }

        private void buttonRegistry_Click(object sender, EventArgs e)
        {
            panelActionButtons.Show();
            this.panelProgress.Visible = true;
            buttonRegistry.BackColor = ApplicationSettings.SelectedButtonColor;
            buttonCleaner.BackColor = ApplicationSettings.NormalButtonColor;
            buttonTools.BackColor = ApplicationSettings.NormalButtonColor;
            buttonOptions.BackColor = ApplicationSettings.NormalButtonColor;

            this.ucCleaner1.Visible = false;
            this.ucResult.Visible = false;



            if (panelCleanerComponents.Controls.Find("Registry", false).Count() > 0)
            {
                UCRegistry registry = panelCleanerComponents.Controls.Find("Registry", false)[0] as UCRegistry;
                registry.Show();
            }
            else
            {
                UCRegistry uCRegistry = new UCRegistry();
                uCRegistry.Name = "Registry";
                panelCleanerComponents.Controls.Add(uCRegistry);
            }

            if (gboxResult.Controls.Find("Tools", false).Count() > 0)
            {
                UCTools registry = gboxResult.Controls.Find("Tools", false)[0] as UCTools;
                registry.Hide();
            }

            if (gboxResult.Controls.Find("Options", false).Count() > 0)
            {
                UCOptions result = this.gboxResult.Controls.Find("Options", true)[0] as UCOptions;
                result.Visible = false;
            }

            SelectedItem = ApplicationItem.Registry;
            ShowHideControls(ApplicationItem.Registry);
        }

        private void buttonCleaner_Click(object sender, EventArgs e)
        {
            panelActionButtons.Show();
            this.panelProgress.Visible = true;
            buttonCleaner.BackColor = ApplicationSettings.SelectedButtonColor;
            buttonRegistry.BackColor = ApplicationSettings.NormalButtonColor;
            buttonTools.BackColor = ApplicationSettings.NormalButtonColor;
            buttonOptions.BackColor = ApplicationSettings.NormalButtonColor;

            this.ucCleaner1.Visible = true;
            this.ucResult.Visible = false;
            this.panelCleanerComponents.Visible = true;
            this.gboxResult.Visible = true;
            this.panelProgress.Visible = true;

            if (panelCleanerComponents.Controls.Find("Registry", false).Count() > 0)
            {
                UCRegistry registry = panelCleanerComponents.Controls.Find("Registry", false)[0] as UCRegistry;
                registry.Hide();
            }


            if (panelCleanerComponents.Controls.Find("ucCleaner1", false).Count() > 0)
            {
                UCCleaner registry = panelCleanerComponents.Controls.Find("ucCleaner1", false)[0] as UCCleaner;
                registry.Show();

            }


            if (gboxResult.Controls.Find("Tools", false).Count() > 0)
            {
                UCTools registry = gboxResult.Controls.Find("Tools", false)[0] as UCTools;
                registry.Hide();
            }

            if (this.gboxResult.Controls.Find("UCResultRegistry", true).Count() > 0)
            {
                UCResultRegistry result = this.gboxResult.Controls.Find("UCResultRegistry", true)[0] as UCResultRegistry;
                result.Visible = false;
            }

            if (gboxResult.Controls.Find("Options", false).Count() > 0)
            {
                UCOptions result = this.gboxResult.Controls.Find("Options", true)[0] as UCOptions;
                result.Visible = false;
            }


            ShowHideControls(ApplicationItem.Cleaner);

            SelectedItem = ApplicationItem.Cleaner;

            //ucResult.ResetView();
        }

        private void buttonTools_Click(object sender, EventArgs e)
        {
            this.panelProgress.Visible = false;

            buttonTools.BackColor = ApplicationSettings.SelectedButtonColor;
            buttonCleaner.BackColor = ApplicationSettings.NormalButtonColor;
            buttonRegistry.BackColor = ApplicationSettings.NormalButtonColor;
            buttonOptions.BackColor = ApplicationSettings.NormalButtonColor;


            if (panelCleanerComponents.Controls.Find("Registry", false).Count() > 0)
            {
                UCRegistry registry = panelCleanerComponents.Controls.Find("Registry", false)[0] as UCRegistry;
                registry.Hide();
            }


            if (panelCleanerComponents.Controls.Find("ucCleaner1", false).Count() > 0)
            {
                UCCleaner registry = panelCleanerComponents.Controls.Find("ucCleaner1", false)[0] as UCCleaner;
                registry.Hide();
            }

            if (gboxResult.Controls.Find("Options", false).Count() > 0)
            {
                UCOptions result = this.gboxResult.Controls.Find("Options", true)[0] as UCOptions;
                result.Visible = false;
            }

            if (gboxResult.Controls.Find("Tools", false).Count() > 0)
            {
                foreach (Control ctrl in this.gboxResult.Controls)
                {
                    ctrl.Visible = false;
                }
                UCTools registry = gboxResult.Controls.Find("Tools", false)[0] as UCTools;
                registry.Visible = true;

            }
            else
            {
                UCTools tools = new UCTools();
                tools.Name = "Tools";
                tools.Dock = DockStyle.Fill;
                foreach (Control ctrl in this.gboxResult.Controls)
                {
                    ctrl.Visible = false;
                }
                this.gboxResult.Controls.Add(tools);

                Task.Delay(500);
                Task.Factory.StartNew(() => tools.LoadPrograms());
            }

            ShowHideControls(ApplicationItem.Tools);

            SelectedItem = ApplicationItem.Tools;

            this.panelActionButtons.Hide();
        }

        private void ShowHideControls(ApplicationItem item)
        {
            this.progressBar1.Value = 0;
            this.progressBar1.Equals(0);
            this.progressBar1.Visible = false;

            if (item == ApplicationItem.Tools)
            {
                this.panelCleanerComponents.Visible = false;
                this.ucCleaner1.Visible = false;
                this.panelActionButtons.Visible = true;
            }
            else if (item == ApplicationItem.Registry)
            {
                this.panelCleanerComponents.Visible = true;
                this.ucCleaner1.Visible = false;
                this.panelActionButtons.Visible = true;
            }
            else if (item == ApplicationItem.Options)
            {
                this.panelCleanerComponents.Visible = false;
                this.ucCleaner1.Visible = false;
                this.panelActionButtons.Visible = true;
            }
            else
            {
                this.panelCleanerComponents.Visible = true;
                this.ucCleaner1.Visible = true;
                this.panelActionButtons.Visible = true;
            }
        }

        private void buttonOptions_Click(object sender, EventArgs e)
        {
            ShowOptionForm();
        }


        public void ShowOptionForm(bool showSubscription=false, bool showAboutFormOnly=false)
        {
            

            this.panelProgress.Visible = false;
            this.panelActionButtons.Hide();
            buttonTools.BackColor = ApplicationSettings.NormalButtonColor;
            buttonCleaner.BackColor = ApplicationSettings.NormalButtonColor;
            buttonRegistry.BackColor = ApplicationSettings.NormalButtonColor;
            buttonOptions.BackColor = ApplicationSettings.SelectedButtonColor;


            if (panelCleanerComponents.Controls.Find("Registry", false).Count() > 0)
            {
                UCRegistry registry = panelCleanerComponents.Controls.Find("Registry", false)[0] as UCRegistry;
                registry.Hide();
            }


            if (panelCleanerComponents.Controls.Find("ucCleaner1", false).Count() > 0)
            {
                UCCleaner registry = panelCleanerComponents.Controls.Find("ucCleaner1", false)[0] as UCCleaner;
                registry.Hide();
            }

            if (gboxResult.Controls.Find("Tools", false).Count() > 0)
            {
                foreach (Control ctrl in this.gboxResult.Controls)
                {
                    ctrl.Hide();
                }
                UCTools registry = gboxResult.Controls.Find("Tools", false)[0] as UCTools;
                registry.Hide();

            }

            if (gboxResult.Controls.Find("Options", false).Count() > 0)
            {
                foreach (Control ctrl in this.gboxResult.Controls)
                {
                    ctrl.Hide();
                }
                UCOptions options = gboxResult.Controls.Find("Options", false)[0] as UCOptions;
                options.Show();
            }
            else
            {
                UCOptions tools = new UCOptions();
                tools.Name = "Options";
                tools.Dock = DockStyle.Fill;
                foreach (Control ctrl in this.gboxResult.Controls)
                {
                    ctrl.Visible = false;
                }
                this.gboxResult.Controls.Add(tools);

                if (showSubscription)
                {
                    tools.ShowSubscriptionForm(showSubscription);
                }

                if (showAboutFormOnly)
                {
                    tools.ShowAboutUs(true);
                }
            }

            ShowHideControls(ApplicationItem.Options);

            SelectedItem = ApplicationItem.Options;

            this.panelActionButtons.Hide();

            if(showSubscription || showAboutFormOnly)
            {
                if (this.OwnedForms.Count() > 0)
                {
                    this.OwnedForms[0].Hide();
                }
                
                buttonCleaner.Enabled = false;
                buttonRegistry.Enabled = false;
                buttonTools.Enabled = false;
            }
        }

        private void buttonAnalyze_Click(object sender, EventArgs e)
        {
            this.backgroundWorkerSearch.DoWork -= backgroundWorkerSearch_DoWork;
            this.backgroundWorkerSearch.ProgressChanged -= backgroundWorkerSearch_ProgressChanged;

            this.backgroundWorkerSearch.DoWork += backgroundWorkerSearch_DoWork;
            this.backgroundWorkerSearch.ProgressChanged += backgroundWorkerSearch_ProgressChanged;

            if (SearchResult!=null && SearchResult.Count > 0)
            {
                SearchResult.Clear();
            }
            this.progressBar1.Visible = true;
            IsCleanerCall = false;
            try
            {
                Stopwatch stopwatch = Stopwatch.StartNew();
                backgroundWorkerSearch.RunWorkerAsync();
                stopwatch.Stop();
                ucResult.ShowExecutionTimke(stopwatch.Elapsed.TotalMilliseconds);
            }
            catch (Exception ex)
            {
                this.backgroundWorkerSearch.DoWork -= backgroundWorkerSearch_DoWork;
                this.backgroundWorkerSearch.ProgressChanged -= backgroundWorkerSearch_ProgressChanged;

                Stopwatch stopwatch = Stopwatch.StartNew();
                backgroundWorkerSearch.CancelAsync();
                stopwatch.Stop();
                ucResult.ShowExecutionTimke(stopwatch.Elapsed.TotalMilliseconds);
            }
        }


        public List<ResultDetail> SearchResult = null;
        public void ProcessSearch(bool afterSearch=false)
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

            if (SelectedItem == ApplicationItem.Cleaner)
            {


                if (this.gboxResult.InvokeRequired)
                {
                    this.gboxResult.Invoke(new MethodInvoker(delegate
                    {
                        this.gboxResult.Visible = true;
                        if (this.gboxResult.Controls.Find("UCResultRegistry", true).Count() > 0)
                        {
                            this.gboxResult.Controls.Find("UCResultRegistry", true)[0].Visible = false;
                        }
                    }));
                }
                else
                {
                    this.gboxResult.Visible = true;
                    if (this.gboxResult.Controls.Find("UCResultRegistry", true).Count() > 0)
                    {
                        this.gboxResult.Controls.Find("UCResultRegistry", true)[0].Visible = false;
                    }
                }


                if (this.ucResult.InvokeRequired)
                {
                    this.ucResult.Invoke(new MethodInvoker(delegate
                    {
                        this.ucResult.Visible = true;
                    }));
                }
                else
                {
                    this.ucResult.Visible = true;
                }

               


                if (this.ucResult.panelSearchComplete.InvokeRequired)
                {
                    this.ucResult.panelSearchComplete.Invoke(new MethodInvoker(delegate
                    {
                        this.ucResult.panelSearchComplete.Hide();
                    }));
                }
                else
                {
                    this.ucResult.panelSearchComplete.Hide();
                }

                if (this.ucResult.panelStatus.InvokeRequired)
                {
                    this.ucResult.panelStatus.Invoke(new MethodInvoker(delegate
                    {
                        this.ucResult.panelStatus.Show();
                    }));
                }
                else
                {
                    this.ucResult.panelStatus.Show();
                }



                if (this.ucResult.panelSearchProgress.InvokeRequired)
                {
                    this.ucResult.panelSearchProgress.Invoke(new MethodInvoker(delegate
                    {
                        this.ucResult.panelSearchProgress.Dock = DockStyle.Fill;
                        this.ucResult.panelSearchProgress.Show();
                    }));
                }
                else
                {
                    this.ucResult.panelSearchProgress.Dock = DockStyle.Fill;
                    this.ucResult.panelSearchProgress.Show();
                }

                if (this.ucResult.labelProgressBar.InvokeRequired)
                {
                    this.ucResult.labelProgressBar.Invoke(new MethodInvoker(delegate
                    {
                        this.ucResult.labelProgressBar.Visible = true;
                    }));
                }
                else
                {
                    this.ucResult.labelProgressBar.Visible = true;
                }

                

                try
                {
                    List<SearchCriteria> searchCriteria = GetSearchCriteria();


                    SearchResult = Analyzer.GetSearchResults(searchCriteria, ref this.ProgressBarLabel, ref this.backgroundWorkerSearch);

                    var overAllResult = Analyzer.GetOverallResult(SearchResult);

                    CleanerApplicationContext.ResultSummary = overAllResult;

                    this.ucResult.ShowResult(ResultView.Overall, overAllResult,afterSearch);
                    this.FilesFound = SearchResult;
                }
                catch (Exception ex)
                {
                    ;
                }
            }
            else if (SelectedItem == ApplicationItem.Registry)
            {
                if (this.ucResult.InvokeRequired)
                {
                    this.ucResult.Invoke(new MethodInvoker(delegate
                    {
                        this.ucResult.Visible = false;
                    }));
                }
                else
                {
                    this.ucResult.Visible = false;
                }


                List<SearchCriteria> searchCriteria = GetSearchCriteria();
                SearchResult = Analyzer.GetSearchResults(searchCriteria,ref this.ProgressBarLabel, ref this.backgroundWorkerSearch);
                var overAllResult = Analyzer.GetOverallResult(SearchResult);

                UCResultRegistry registryControl = null;
                if (this.gboxResult.Controls.Find("UCResultRegistry", true).Count() < 1)
                {
                    registryControl = new UCResultRegistry();
                    registryControl.Name = "UCResultRegistry";
                    registryControl.Dock = DockStyle.Fill;
                    //registryControl.ShowResult(ResultView.Detail, overAllResult);
                }
                else
                {
                    registryControl = this.gboxResult.Controls.Find("UCResultRegistry", true)[0] as UCResultRegistry;


                    if (registryControl.InvokeRequired)
                    {
                        registryControl.Invoke(new MethodInvoker(delegate
                        {
                            registryControl.Visible = true;
                        }));
                    }
                    else
                    {
                        registryControl.Visible = false;
                    }
                }

                if (this.gboxResult.InvokeRequired)
                {
                    this.gboxResult.Invoke(new MethodInvoker(delegate
                    {
                        if (this.gboxResult.Controls.Find("UCResultRegistry", true).Count() < 1)
                            this.gboxResult.Controls.Add(registryControl);

                        registryControl.ShowResult(ResultView.Detail, overAllResult);
                    }));
                }
                else
                {
                    if (this.gboxResult.Controls.Find("UCResultRegistry", true).Count() < 1)
                        this.gboxResult.Controls.Add(registryControl);

                    registryControl.ShowResult(ResultView.Detail, overAllResult);
                }
            }

            this.backgroundWorkerSearch.DoWork -= backgroundWorkerSearch_DoWork;
            this.backgroundWorkerSearch.ProgressChanged -= backgroundWorkerSearch_ProgressChanged;
        }

        private void backgroundWorkerSearch_DoWork(object sender, DoWorkEventArgs e)
        {
            if (!IsCleanerCall)
                ProcessSearch();
            else
            {
                CleanupSystem();
            }
        }

        private List<SearchCriteria> GetSearchCriteria()
        {
            List<SearchCriteria> searchCriteria = new List<SearchCriteria>();


            if (SelectedItem == ApplicationItem.Cleaner)
            {
                searchCriteria.Clear();

                List<ListItem> edgeSelectedItems = null;
                try
                {
                    edgeSelectedItems = this.Edge.SelectedItems;
                }
                catch (Exception ex)
                {
                    ;
                }

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
            }
            if (SelectedItem == ApplicationItem.Registry)
            {
                List<ListItem> registrySelectedItems = null;
                try
                {
                    registrySelectedItems = this.Registry.SelectedItems;
                }
                catch
                {
                    ;
                }
                if (registrySelectedItems != null && registrySelectedItems.Count > 0)
                {
                    searchCriteria.Clear();
                    foreach (var item in registrySelectedItems)
                    {
                        SearchCriteria criteria = new SearchCriteria() { SearchArea = (int)SearchArea.Registry, FeatureId = item.ItemId };
                        searchCriteria.Add(criteria);
                    }
                }
            }
            return searchCriteria;
        }

        private void backgroundWorkerSearch_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (this.progressBar1.InvokeRequired)
            {
                this.progressBar1.Invoke(new MethodInvoker(delegate
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
                }));
            }
            else
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



        private void buttonCleaner1_Click(object sender, EventArgs e)
        {
            IsCleanerCall = true;


            ///////////////////////////////
            
            DialogResult result = MessageBox.Show("The selected files will be deleted from you PC.\n Do you wish to continue", "Confirmation", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                try
                {
                    ucResult.Visible = true;
                    Stopwatch stopwatch = Stopwatch.StartNew();
                    backgroundWorkerSearch.RunWorkerAsync();
                    

                    stopwatch.Stop();

                    ucResult.ShowExecutionTimke(stopwatch.Elapsed.TotalMilliseconds);
                }
                catch (Exception ex)
                {
                    this.backgroundWorkerSearch.DoWork -= backgroundWorkerSearch_DoWork;
                    this.backgroundWorkerSearch.ProgressChanged -= backgroundWorkerSearch_ProgressChanged;

                    ucResult.Visible = true;
                    Stopwatch stopwatch = Stopwatch.StartNew();
                    backgroundWorkerSearch.RunWorkerAsync();
                    stopwatch.Stop();
                    ucResult.ShowExecutionTimke(stopwatch.Elapsed.TotalMilliseconds);
                }
                finally
                {

                    if (SearchResult != null && SearchResult.Count > 0)
                    {
                        SearchResult.Clear();
                    }
                    
                }
            }

        }

        private void CleanupSystem()
        {
            if (this.progressBar1.InvokeRequired)
            {
                this.progressBar1.Invoke(new MethodInvoker(delegate
                {
                    this.progressBar1.Visible = true;
                }));
            };

            this.backgroundWorkerSearch = new BackgroundWorker();
            this.backgroundWorkerSearch.WorkerReportsProgress = true;
            this.backgroundWorkerSearch.WorkerSupportsCancellation = true;

            this.backgroundWorkerSearch.DoWork += backgroundWorkerSearch_DoWork;
            this.backgroundWorkerSearch.ProgressChanged += backgroundWorkerSearch_ProgressChanged;


            var searchCriteria = GetSearchCriteria();
            var filesFound = Analyzer.GetSearchResults(searchCriteria, ref ProgressBarLabel, ref this.backgroundWorkerSearch, true);


            if (SelectedItem == ApplicationItem.Registry)
            {
                var registryItems = filesFound;

                var gridItems = new List<ResultDetail>();

                UCResultRegistry result = this.gboxResult.Controls.Find("UCResultRegistry", true)[0] as UCResultRegistry;

                var items = result.SelectedRows;

                Cleaner.CleanUpSystem(searchCriteria, items, SelectedItem, ref this.backgroundWorkerSearch);

                Task.Factory.StartNew(() => ProcessSearch(true));
                MessageBox.Show($"{items.Count} registry items deleted successfully.");
                result.SelectedRows.Clear();
            }
            else
            {

                long totalSpaceCleanedUp = filesFound.Sum(t => t.FileSize);


                Cleaner.CleanUpSystem(searchCriteria, filesFound, SelectedItem, ref this.backgroundWorkerSearch);

                Task.Factory.StartNew(() => ProcessSearch(true));

                double mb = 0;

                if (totalSpaceCleanedUp > 0)
                {
                    mb = (totalSpaceCleanedUp * 1.0 / 1000);
                }

                MessageBox.Show("Total space wiped is " + Math.Round( mb,2) + " MB");
            }
            
            this.backgroundWorkerSearch.DoWork -= backgroundWorkerSearch_DoWork;
            this.backgroundWorkerSearch.ProgressChanged -= backgroundWorkerSearch_ProgressChanged;
        }

        private void backgroundWorkerSearch_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if(IsCleanerCall)
            {
                backgroundWorkerSearch.Dispose();
                IsCleanerCall = false;
                ProcessSearch();
            }
        }

        private void FrmMain_Shown(object sender, EventArgs e)
        {
            if (IsSubscriptionExists && !IsSubValid)
            {
                this.Controls.Find("labelProductActivation", true)[0].Visible = true;
                this.Controls.Find("labelTrialPeriodLeft", true)[0].Visible = false;
                (this.Controls.Find("labelProductActivation", true)[0] as Label).Text = "Subscription Expired";

                var messageBox = new SubscriptionMessage(this);

                Overlay.ShowOverlay(this, messageBox);//this: parent form

                messageBox.ShowDialog();
            }
            else if (!IsSubscriptionExists)
            {
                OptionsAdvanceSetting.ReloadSettings();
                string startDate = OptionsAdvanceSetting.GetTrialPeriodStartDate;
                if (!string.IsNullOrEmpty(startDate))
                {
                    DateTime startFrom = Convert.ToDateTime(startDate);
                    DateTime endDate = startFrom.AddDays(7);

                    // TimeSpan trialPeriod = endDate.Subtract(DateTime.Now);

                    //this.labelTrialPeriodLeft.Text = "[" + trialPeriod.Days + " Days Left]";

                    this.labelTrialPeriodLeft.Text = "[0 Days Left]";

                    //if (trialPeriod.Days == 0)
                    {
                        TrialExpired form = new TrialExpired(this);

                        Overlay.ShowOverlay(this, form);//this: parent form

                        form.ShowDialog();
                    }
                }
            }
        }
    }
}
