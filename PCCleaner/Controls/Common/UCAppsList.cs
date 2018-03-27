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
    public partial class UCAppsList : UserControl
    {
        private List<ListItem> ItemsList
        {
            get;
            set;
        }

       
        public UCAppsList()
        {
            InitializeComponent();
            this.EdgeHeading.IconClick += EdgeHeading_IconClick;

          
        }

        public UCAppsList(List<ListItem> list, string headingTitle, Image headingImage):this()
        {
            ItemsList = list;
            ((ListBox)this.chkListEdge).DataSource = list;
            ((ListBox)this.chkListEdge).DisplayMember = "ItemText";
            ((ListBox)this.chkListEdge).ValueMember = "ItemId";

            this.EdgeHeading.HeadingLabel = headingTitle;
            this.EdgeHeading.HeadingImage = headingImage;
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
