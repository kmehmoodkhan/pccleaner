using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCCleaner.Controls.Common
{
    public partial class UCTools : UserControl
    {
        private UCUninstall _Uninstall = null;
        public UCUninstall Uninstall
        {
            get
            {
                return _Uninstall;
            }
        }


        private UCStartup _UCStartup = null;
        public UCStartup UCStartup
        {
            get
            {
                return _UCStartup;
            }
        }



        private UCBrowserPlugins _UCBrowserPlugins = null;
        public UCBrowserPlugins UCBrowserPlugins
        {
            get
            {
                return _UCBrowserPlugins;
            }
        }


        private UCDiskResult _UCDiskResult = null;
        public UCDiskResult UCDiskResult
        {
            get
            {
                return _UCDiskResult;
            }
        }


        private UCDiskAnalyzer _UCDiskAnalyzer = null;
        public UCDiskAnalyzer UCDiskAnalyzer
        {
            get
            {
                return _UCDiskAnalyzer;
            }
        }
        


        private UCSystemRestore _UCSystemRestore = null;
        public UCSystemRestore UCSystemRestore
        {
            get
            {
                return _UCSystemRestore;
            }
        }




        private UCDriveWiper _UCDriveWiper = null;
        public UCDriveWiper UCDriveWiper
        {
            get
            {
                return _UCDriveWiper;
            }
        }

        public UCTools()
        {
            InitializeComponent();

            _Uninstall = new UCUninstall();
            _Uninstall.Dock = DockStyle.Fill;
            panelToolsMain.Controls.Add(_Uninstall);
            this.labelInformation.Text = "Select a program from the list you want to remove from the computer";
        }

        private void buttonUninstall_Click(object sender, EventArgs e)
        {
           
            Uninstall.ShowInstalledPrograms();

            ShowHideControls(Uninstall);
        }

        private void buttonStartup_Click(object sender, EventArgs e)
        {
            _UCStartup = new UCStartup();
            _UCStartup.Dock = DockStyle.Fill;
            panelToolsMain.Controls.Add(UCStartup);

            ShowHideControls(UCStartup);

        }

        private void buttonPlugins_Click(object sender, EventArgs e)
        {
            _UCBrowserPlugins = new UCBrowserPlugins();
            _UCBrowserPlugins.Dock = DockStyle.Fill;
            panelToolsMain.Controls.Add(UCBrowserPlugins);

            ShowHideControls(UCBrowserPlugins);
        }

        private void buttonDisk_Click(object sender, EventArgs e)
        {


            _UCDiskAnalyzer = new UCDiskAnalyzer();
            _UCDiskAnalyzer.Dock = DockStyle.Fill;
            panelToolsMain.Controls.Add(_UCDiskAnalyzer);

            ShowHideControls(_UCDiskAnalyzer);
        }

        private void buttonSystemRestore_Click(object sender, EventArgs e)
        {
           

            _UCSystemRestore = new UCSystemRestore();
            _UCSystemRestore.Dock = DockStyle.Fill;
            panelToolsMain.Controls.Add(_UCSystemRestore);

            ShowHideControls(_UCSystemRestore);

        }

        private void buttonDriveWiper_Click(object sender, EventArgs e)
        {
            

            _UCDriveWiper = new UCDriveWiper();
            _UCDriveWiper.Dock = DockStyle.Fill;
            panelToolsMain.Controls.Add(_UCDriveWiper);

            ShowHideControls(_UCDriveWiper);
        }

        private void ShowHideControls(UserControl control)
        {
            control.Show();
            if (control != null)
            {
                foreach (Control cntrl in panelToolsMain.Controls)
                {
                    if (cntrl.Name != control.Name)
                    {
                        cntrl.Visible = false;
                    }
                }
            }
        }

        public void ShowDiskAnalyzerResult(List<string> drives, List<int> fileFilter )
        {
            _UCDiskAnalyzer.Hide();

            if (_UCDiskResult == null || _UCDiskResult.IsDisposed)
            {
                _UCDiskResult = new UCDiskResult(drives, fileFilter);

                _UCDiskResult.Dock = DockStyle.Fill;

                panelToolsMain.Controls.Add(_UCDiskResult);
            }
            ShowHideControls(_UCDiskResult);
        }


        public void ShowDiskAnalyzer()
        {
            _UCDiskAnalyzer.Show();
            

            ShowHideControls(_UCDiskAnalyzer);
        }
    }
}
