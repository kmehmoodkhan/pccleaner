using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PCCleaner.Properties;

namespace PCCleaner.Controls
{
    public partial class UCIE : UserControl
    {
        bool _checkAll = false;
        public bool CheckedAll
        {
            get
            {
                return _checkAll;
            }
            set
            {
                _checkAll = value;
            }
        }
        public UCIE()
        {
            InitializeComponent();
            this.EdgeHeading.HeadingLabel = "Internet Explorer";
            this.EdgeHeading.HeadingImage = Resources.IE;

            this.EdgeHeading.IconClick += EdgeHeading_IconClick;
        }

        private void EdgeHeading_IconClick(object sender, EventArgs e)
        {
            if (CheckedAll == false)
            {
                CheckedAll = true;

                for (int i = 0; i < this.chkListEdge.Items.Count; i++)
                {
                    this.chkListEdge.SetItemChecked(i, true);
                }
            }
            else
            {
                CheckedAll = false;

                for (int i = 0; i < this.chkListEdge.Items.Count; i++)
                {
                    this.chkListEdge.SetItemChecked(i, false);
                }
            }
        }
    }
}
