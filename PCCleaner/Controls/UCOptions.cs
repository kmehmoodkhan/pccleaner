using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PCCleaner.Controls.Options;

namespace PCCleaner.Controls
{
    public partial class UCOptions : UserControl
    {
        public UCOptions()
        {
            InitializeComponent();
        }

        private void buttonCookies_Click(object sender, EventArgs e)
        {
            HideAllControls();
            UCCookies cookies = null;
            if (panelToolsMain.Controls.Find("Cookies",false).Count()<1)
            {
                cookies = new UCCookies();
                cookies.Name = "Cookies";
                cookies.Dock = DockStyle.Fill;
                panelToolsMain.Controls.Add(cookies);
            }
            else
            {
                cookies = panelToolsMain.Controls.Find("Cookies", false)[0] as UCCookies;
                cookies.Show();
            }
            
        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            HideAllControls();
            UCSettings settings = null;
            if (panelToolsMain.Controls.Find("Settings", false).Count() < 1)
            {
                settings = new UCSettings();
                settings.Name = "Settings";
                settings.Dock = DockStyle.Fill;
                panelToolsMain.Controls.Add(settings);
            }
            else
            {
                settings = panelToolsMain.Controls.Find("Settings", false)[0] as UCSettings;
                settings.Show();
            }
        }

        private void HideAllControls()
        {
            foreach( Control ctrl in panelToolsMain.Controls)
            {
                ctrl.Hide();
            }
        }

        private void buttonInclude_Click(object sender, EventArgs e)
        {
            HideAllControls();
            UCIncludeExclude Include = null;
            if (panelToolsMain.Controls.Find("Include", false).Count() < 1)
            {
                Include = new UCIncludeExclude();
                Include.Name = "Include";
                Include.Dock = DockStyle.Fill;
                panelToolsMain.Controls.Add(Include);
            }
            else
            {
                Include = panelToolsMain.Controls.Find("Include", false)[0] as UCIncludeExclude;
                Include.Show();
            }
        }

        private void buttonExclude_Click(object sender, EventArgs e)
        {
            HideAllControls();
            UCIncludeExclude Exclude = null;
            if (panelToolsMain.Controls.Find("Exclude", false).Count() < 1)
            {
                Exclude = new UCIncludeExclude();
                Exclude.Name = "Include";
                Exclude.Dock = DockStyle.Fill;
                panelToolsMain.Controls.Add(Exclude);
            }
            else
            {
                Exclude = panelToolsMain.Controls.Find("Exclude", false)[0] as UCIncludeExclude;
                Exclude.Show();
            }
        }

        private void buttonAdvanced_Click(object sender, EventArgs e)
        {
            HideAllControls();
            UCAdvanced Advanced = null;
            if (panelToolsMain.Controls.Find("Advanced", false).Count() < 1)
            {
                Advanced = new UCAdvanced();
                Advanced.Name = "Advanced";
                Advanced.Dock = DockStyle.Fill;
                panelToolsMain.Controls.Add(Advanced);
            }
            else
            {
                Advanced = panelToolsMain.Controls.Find("Advanced", false)[0] as UCAdvanced;
                Advanced.Show();
            }
        }
    }
}
