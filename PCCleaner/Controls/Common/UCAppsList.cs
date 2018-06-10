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

        public List<ListItem> SelectedItems
        {
            get
            {
                List<ListItem> selectedItems = new List<ListItem>();
                foreach (var item in this.chkListEdge.CheckedItems)
                {
                    ListItem drv = item as ListItem;
                    ListItem select = item as ListItem;
                    
                    select.ItemId = select.ItemId;
                    select.ItemText = select.ItemText;
                    selectedItems.Add(select);
                }

                return selectedItems;
            }
        }

       
        public UCAppsList()
        {
            InitializeComponent();
            this.EdgeHeading.IconClick += EdgeHeading_IconClick;            
        }


        public UCAppsList(List<ListItem> list, string headingTitle, Image headingImage,string controlName):this()
        {
            controlName = controlName.Replace(" ", "_");
            this.Name = controlName;
            ItemsList = list;
            ((ListBox)this.chkListEdge).DataSource = list;
            ((ListBox)this.chkListEdge).DisplayMember = "ItemText";
            ((ListBox)this.chkListEdge).ValueMember = "ItemId";

            this.EdgeHeading.HeadingLabel = headingTitle;
            this.EdgeHeading.HeadingImage = headingImage;

            if( headingTitle == "Edge")
            {
                this.chkListEdge.Height = this.chkListEdge.PreferredHeight+20;
            }
            else if (headingTitle == "Internet Explorer")
            {
                this.chkListEdge.Height = this.chkListEdge.PreferredHeight + 20;
                //this.Height = this.chkListEdge.PreferredHeight + this.EdgeHeading.Height + 20;
            }
            else if (headingTitle == "Google Chrome")
            {
                this.chkListEdge.Height = this.chkListEdge.PreferredHeight + 20;
                //this.Height = this.chkListEdge.PreferredHeight + this.EdgeHeading.Height + 20;
            }
            else if (headingTitle == "Mozilla Firefox")
            {
                this.chkListEdge.Height = this.chkListEdge.PreferredHeight + 20;
                //this.Height = this.chkListEdge.PreferredHeight + this.EdgeHeading.Height + 20;
            }
            else  if (headingTitle == "Explorer")
            {
                this.chkListEdge.Height = this.chkListEdge.PreferredHeight+20;
                //this.Height = this.chkListEdge.PreferredHeight + this.EdgeHeading.Height + 20;
            }
            else if ( headingTitle == "System")
            {
                this.chkListEdge.Height = this.chkListEdge.PreferredHeight + 30;
                //this.Height = this.chkListEdge.PreferredHeight + this.EdgeHeading.Height + 40;
            }
            else if (headingTitle == "Advanced")
            {
                this.chkListEdge.Height = this.chkListEdge.PreferredHeight + 30;
                //this.Height = this.chkListEdge.PreferredHeight + this.EdgeHeading.Height + 40;
            }
            else if (headingTitle == "WindowsStore")
            {
                this.chkListEdge.Height = this.chkListEdge.PreferredHeight + 13;
            }
            else if (headingTitle == "Applications")
            {
                this.chkListEdge.Height = this.chkListEdge.PreferredHeight + 13;
            }
            else if (headingTitle == "Multimedia")
            {
                this.chkListEdge.Height = this.chkListEdge.PreferredHeight + 13;
            }
            else if (headingTitle == "Internet")
            {
                this.chkListEdge.Height = this.chkListEdge.PreferredHeight + 13;
            }
            else if (headingTitle == "Utilities")
            {
                this.chkListEdge.Height = this.chkListEdge.PreferredHeight + 13;
            }
            else if (headingTitle == "Windows")
            {
                this.chkListEdge.Height = this.chkListEdge.PreferredHeight + 13;
            }
            else if (controlName == "Registry")
            {
                this.Height = this.Height + 200;
                this.chkListEdge.Height = this.chkListEdge.PreferredHeight + 400;
            }
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
