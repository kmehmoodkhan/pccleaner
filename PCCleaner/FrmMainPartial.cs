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
    }
}
