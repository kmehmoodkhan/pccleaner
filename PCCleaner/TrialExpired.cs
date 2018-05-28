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
    public partial class TrialExpired : Form
    {
        FrmMain ParentForm = null;
        public TrialExpired(Form frmMain)
        {
            InitializeComponent();
            this.ControlBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            ParentForm = (FrmMain)frmMain;
        }

        private void buttonSubscribe_Click(object sender, EventArgs e)
        {
            ParentForm.ShowOptionForm(true);
            this.Hide();
        }
    }
}
