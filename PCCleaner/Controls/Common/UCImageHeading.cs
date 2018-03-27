using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCCleaner.Controls
{
    public partial class UCImageHeading : UserControl
    {
        public UCImageHeading()
        {
            InitializeComponent();
        }

        public UCImageHeading(Image image, string title) : this()
        {
            this.pcEdge.Image = image;
            this.lblEdge.Text = title;
        }

        public Image HeadingImage
        {
            set
            {
                this.pcEdge.Image = value;
            }
        }

        public string HeadingLabel
        {
            set
            {
                this.lblEdge.Text = value;
            }
        }

        public event UserControlClickHandler IconClick;
        public delegate void UserControlClickHandler(object sender, EventArgs e);

        private void pcEdge_Click(object sender, EventArgs e)
        {
            if (this.IconClick != null)
            {
                this.IconClick(sender, e);
            }
        }
    }
}
