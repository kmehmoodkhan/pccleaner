using PCCleaner.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCCleaner
{
    public partial class SubscriptionMessage : Form
    {
        FrmMain ParentForm = null;
        public SubscriptionMessage(FrmMain frmMain)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.Fixed3D;
            ParentForm = (FrmMain)frmMain;
        }

        private const int CP_NOCLOSE_BUTTON = 0x200;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams myCp = base.CreateParams;
                myCp.ClassStyle = myCp.ClassStyle | CP_NOCLOSE_BUTTON;
                return myCp;
            }
        }

        private void buttonAbout_Click(object sender, EventArgs e)
        {
            ParentForm.ShowOptionForm(false,true);
            this.Hide();
        }
    }
}
