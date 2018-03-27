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

namespace PCCleaner.Controls.Cleaner.Windows
{
    public partial class UCAdvanced : UserControl
    {
        public UCAdvanced()
        {
            InitializeComponent();

            this.EdgeHeading.HeadingLabel = "Advanced";
            this.EdgeHeading.HeadingImage = Resources.Information;

            this.EdgeHeading.IconClick += EdgeHeading_IconClick;
        }

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
