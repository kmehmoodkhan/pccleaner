using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PCCleaner.DataAccess;

namespace PCCleaner.Controls.Options
{
    public partial class UCSettings : UserControl
    {
        public UCSettings()
        {
            InitializeComponent();

            this.checkBoxRunOption.Checked = OptionsSetting.IsRunCleanerOnStartup;
            this.checkBoxAddRunToRecycleBin.Checked = OptionsSetting.IsAddRunCleanerToRecycleBinMenu;
            this.checkBoxAddOpenOption.Checked = OptionsSetting.AddOpenCleanerToRecycleBinMenu;

            this.checkBoxNormalDeletion.Checked = OptionsSetting.IsNormalFileDeletion;
            this.checkBoxSecureDeletion.Checked = OptionsSetting.IsSecureFileDeletion;
        }

        private void checkBoxRunOption_CheckedChanged(object sender, EventArgs e)
        {
            OptionsSetting.IsRunCleanerOnStartup = this.checkBoxRunOption.Checked;
        }

        private void checkBoxAddRunToRecycleBin_CheckedChanged(object sender, EventArgs e)
        {
            OptionsSetting.IsAddRunCleanerToRecycleBinMenu = this.checkBoxAddRunToRecycleBin.Checked;
        }

        private void checkBoxAddOpenOption_CheckedChanged(object sender, EventArgs e)
        {
            OptionsSetting.AddOpenCleanerToRecycleBinMenu = this.checkBoxAddOpenOption.Checked;
        }

        private void checkBoxNormalDeletion_CheckedChanged(object sender, EventArgs e)
        {
            OptionsSetting.IsNormalFileDeletion= this.checkBoxNormalDeletion.Checked;
        }

        private void checkBoxSecureDeletion_CheckedChanged(object sender, EventArgs e)
        {
            OptionsSetting.IsSecureFileDeletion = this.checkBoxSecureDeletion.Checked;
        }
    }
}
