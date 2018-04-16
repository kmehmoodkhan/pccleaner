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
        }
    }
}
