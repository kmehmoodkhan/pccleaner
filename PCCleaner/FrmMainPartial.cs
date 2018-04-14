using PCCleaner.Controls;
using PCCleaner.Controls.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCCleaner
{
    public partial class FrmMain:System.Windows.Forms.Form
    {
        private UCAppsList Edge
        {
            get
            {
                var control = this.ucCleaner1.Controls[0].Controls[0].Controls[0].Controls["Edge"];
                return (UCAppsList)control;
            }
        }

        private UCAppsList IE
        {
            get
            {
                var control = this.ucCleaner1.Controls[0].Controls[0].Controls[0].Controls["IE"];
                return (UCAppsList)control;
            }
        }

        private UCAppsList Chrome
        {
            get
            {
                var control = this.ucCleaner1.Controls[0].Controls[1].Controls[0].Controls["Google_Chrome"];
                return (UCAppsList)control;
            }
        }

        private UCAppsList Firefox
        {
            get
            {
                var control = this.ucCleaner1.Controls[0].Controls[1].Controls[0].Controls["Mozilla_Firefox"];
                return (UCAppsList)control;
            }
        }

        private UCAppsList WindowExplorer
        {
            get
            {
                var control = this.ucCleaner1.Controls[0].Controls[0].Controls[0].Controls["Explorer"];
                return (UCAppsList)control;
            }
        }

        private UCAppsList SystemArea
        {
            get
            {
                var control = this.ucCleaner1.Controls[0].Controls[0].Controls[0].Controls["System"];
                return (UCAppsList)control;
            }
        }

        private UCAppsList Advanced
        {
            get
            {
                var control = this.ucCleaner1.Controls[0].Controls[0].Controls[0].Controls["Advanced"];
                return (UCAppsList)control;
            }
        }

        private UCAppsList WindowsStore
        {
            get
            {
                var control = this.ucCleaner1.Controls[0].Controls[1].Controls[0].Controls["WindowsStore"];
                return (UCAppsList)control;
            }
        }
        private UCAppsList Applications
        {
            get
            {
                var control = this.ucCleaner1.Controls[0].Controls[1].Controls[0].Controls["Applications"];
                return (UCAppsList)control;
            }
        }

        private UCAppsList Internet
        {
            get
            {
                var control = this.ucCleaner1.Controls[0].Controls[1].Controls[0].Controls["Internet"];
                return (UCAppsList)control;
            }
        }

        private UCAppsList Utilities
        {
            get
            {
                var control = this.ucCleaner1.Controls[0].Controls[1].Controls[0].Controls["Utilities"];
                return (UCAppsList)control;
            }
        }
        private UCAppsList Windows
        {
            get
            {
                var control = this.ucCleaner1.Controls[0].Controls[1].Controls[0].Controls["Windows"];
                return (UCAppsList)control;
            }
        }
        private UCRegistry Registry
        {
            get
            {
                var control = panelCleanerComponents.Controls.Find("Registry",false)[0];
                return (UCRegistry)control;
            }
        }
    }
}
