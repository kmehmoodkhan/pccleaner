using PCCleaner.Common;
using PCCleaner.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCCleaner
{
    public partial class FrmMain : Form
    {
        //
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
            var items = this.Edge.SelectedItems;
            var result = Analyzer.GetSearchResults(SearchArea.Edge, items);
            var overAllResult = Analyzer.GetOverallResult(result);
            this.ucResult.ShowResult(ResultView.Overall, overAllResult);
        }
    }
}
