using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PCCleaner.Common;
using PCCleaner.DataAccess;

namespace PCCleaner.Controls.Options
{
    public partial class UCAdvanced : UserControl
    {
        public UCAdvanced()
        {
            InitializeComponent();

            this.checkBoxShowResultDetail.Checked = OptionsAdvanceSetting.ShowInitialResultsView;
            this.checkBoxDeleteTempFiles.Checked = OptionsAdvanceSetting.IsDeleteTempFilesAfter24Hours;
            this.checkBoxDeleteRecycleBin.Checked = OptionsAdvanceSetting.IsDeleteRecycleBinFilesAfter24Hours;
            this.checkBoxHideWarning.Checked = OptionsAdvanceSetting.IsHideWarningMessages;
            this.checkBoxCloseProgramOnCleaning.Checked = OptionsAdvanceSetting.IsCloseProgramAfterCleaning;
            this.checkBoxShutdowAfterCleaning.Checked = OptionsAdvanceSetting.IsShutDownAfterCleaning;
            this.checkBoxShowPromptBackupRegistry.Checked = OptionsAdvanceSetting.IsShowPromptBackupRegistry;
            this.checkBoxMinimizeToSystemTray.Checked = OptionsAdvanceSetting.IsMinimizeToSystemTray;
            this.checkBoxSaveToINIFile.Checked = OptionsAdvanceSetting.IsSaveSettingsToINIFile;
            this.checkBoxSkipUserControlWarning.Checked = OptionsAdvanceSetting.IsSkipUserAccountControlWarning;
            this.checkBoxEnableWindowJumpList.Checked = OptionsAdvanceSetting.IsEnableWindowsJumpListTasks;

        }

        private void checkBoxShowResultDetail_CheckedChanged(object sender, EventArgs e)
        {
            OptionsAdvanceSetting.ShowInitialResultsView = this.checkBoxShowResultDetail.Checked;
        }

        private void checkBoxDeleteTempFiles_CheckedChanged(object sender, EventArgs e)
        {
            OptionsAdvanceSetting.IsDeleteTempFilesAfter24Hours = checkBoxDeleteTempFiles.Checked;
        }

        private void checkBoxDeleteRecycleBin_CheckedChanged(object sender, EventArgs e)
        {
            OptionsAdvanceSetting.IsDeleteRecycleBinFilesAfter24Hours = checkBoxDeleteRecycleBin.Checked;
        }

        private void checkBoxHideWarning_CheckedChanged(object sender, EventArgs e)
        {
            OptionsAdvanceSetting.IsHideWarningMessages = checkBoxHideWarning.Checked;
        }

        private void checkBoxCloseProgramOnCleaning_CheckedChanged(object sender, EventArgs e)
        {
            OptionsAdvanceSetting.IsCloseProgramAfterCleaning = checkBoxCloseProgramOnCleaning.Checked;
        }

        private void checkBoxShutdowAfterCleaning_CheckedChanged(object sender, EventArgs e)
        {
            OptionsAdvanceSetting.IsShutDownAfterCleaning = checkBoxShutdowAfterCleaning.Checked;
        }

        private void checkBoxShowPromptBackupRegistry_CheckedChanged(object sender, EventArgs e)
        {
            OptionsAdvanceSetting.IsShowPromptBackupRegistry = checkBoxShowPromptBackupRegistry.Checked;
        }

        private void checkBoxMinimizeToSystemTray_CheckedChanged(object sender, EventArgs e)
        {
            OptionsAdvanceSetting.IsMinimizeToSystemTray = checkBoxMinimizeToSystemTray.Checked;
        }

        private void checkBoxSaveToINIFile_CheckedChanged(object sender, EventArgs e)
        {
            OptionsAdvanceSetting.IsSaveSettingsToINIFile = checkBoxSaveToINIFile.Checked;
        }

        private void checkBoxSkipUserControlWarning_CheckedChanged(object sender, EventArgs e)
        {
            OptionsAdvanceSetting.IsSkipUserAccountControlWarning = checkBoxSkipUserControlWarning.Checked;
        }

        private void checkBoxEnableWindowJumpList_CheckedChanged(object sender, EventArgs e)
        {
            OptionsAdvanceSetting.IsEnableWindowsJumpListTasks = checkBoxEnableWindowJumpList.Checked;
        }
    }
}
