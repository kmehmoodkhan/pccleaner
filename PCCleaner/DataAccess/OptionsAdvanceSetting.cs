using PCCleaner.Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCCleaner.DataAccess
{
    public static class OptionsAdvanceSetting
    {
        static DataView DVOptionSettings = null;
        static OptionsAdvanceSetting()
        {
            DataSet dataSet = CleanerApplicationSettings.GetApplicationSettings();
            DataView defaultView = dataSet.Tables[0].DefaultView;
            defaultView.RowFilter = "IsDefault=0";
            DVOptionSettings = defaultView;

        }

        private static string GetAttributeValue(string attribute)
        {
            string value = string.Empty;

            foreach( DataRow dr in DVOptionSettings.Table.Rows)
            {
                if( dr["Setting"].ToString() == attribute)
                {
                    value = dr["value"].ToString();
                }
            }
            return value;
        }
        private static void SetAttributeValue(string attributeName,bool value)
        {
            int newValue = 0;
            if( value == true)
            {
                newValue = 1;
            }
            string query = "UPDATE ApplicationSettings SET value='" + newValue + "' where isDefault=0 AND setting='" + attributeName + "'";
            DBAccess access = new DBAccess();
            access.ExecuteNonQuery(query);
        }

        public static bool ShowInitialResultsView
        {
            get
            {

                return GetAttributeValue("Opt_Adv_ShowResultDetailView").Equals("1");
            }
            set
            {
                SetAttributeValue("Opt_Adv_ShowResultDetailView", value);
            }
        }

        public static bool IsDeleteTempFilesAfter24Hours
        {
            get
            {
                return GetAttributeValue("Opt_Adv_DeleteTempFiles24Hours").Equals("1");
            }
            set
            {
                SetAttributeValue("Opt_Adv_DeleteTempFiles24Hours", value);
            }
        }

        public static bool IsDeleteRecycleBinFilesAfter24Hours
        {
            get
            {
                return GetAttributeValue("Opt_Adv_DeleteRecycleBin24Hours").Equals("1");
            }
            set
            {
                SetAttributeValue("Opt_Adv_DeleteRecycleBin24Hours", value);
            }
        }

        public static bool IsHideWarningMessages
        {
            get
            {
                return GetAttributeValue("Opt_Adv_HideWarningMsg").Equals("1");
            }
            set
            {
                SetAttributeValue("Opt_Adv_HideWarningMsg", value);
            }
        }

        public static bool IsCloseProgramAfterCleaning
        {
            get
            {
                return GetAttributeValue("Opt_Adv_CloseProgramAfterCleaning").Equals("1");
            }
            set
            {
                SetAttributeValue("Opt_Adv_CloseProgramAfterCleaning", value);
            }
        }

        public static bool IsShutDownAfterCleaning
        {
            get
            {
                return GetAttributeValue("Opt_Adv_ShutDownAfterCleaning").Equals("1");
            }
            set
            {
                SetAttributeValue("Opt_Adv_ShutDownAfterCleaning", value);
            }
        }

        public static bool IsShowPromptBackupRegistry
        {
            get
            {
                return GetAttributeValue("Opt_Adv_ShowPromptBakcupRegistry").Equals("1");
            }
            set
            {
                SetAttributeValue("Opt_Adv_ShowPromptBakcupRegistry", value);
            }
        }

        public static bool IsMinimizeToSystemTray
        {
            get
            {
                return GetAttributeValue("Opt_Adv_MinimizeToSystemTray").Equals("1");
            }
            set
            {
                SetAttributeValue("Opt_Adv_MinimizeToSystemTray", value);
            }
        }

        public static bool IsSaveSettingsToINIFile
        {
            get
            {
                return GetAttributeValue("Opt_Adv_SaveSettingsToINI").Equals("1");
            }
            set
            {
                SetAttributeValue("Opt_Adv_SaveSettingsToINI", value);
            }
        }

        public static bool IsSkipUserAccountControlWarning
        {
            get
            {
                return GetAttributeValue("Opt_Adv_SkipUserControlWarning").Equals("1");
            }
            set
            {
                SetAttributeValue("Opt_Adv_SkipUserControlWarning", value);
            }
        }

        public static bool IsEnableWindowsJumpListTasks
        {
            get
            {
                return GetAttributeValue("Opt_Adv_EnableWindowJumpListTak").Equals("1");
            }
            set
            {
                SetAttributeValue("Opt_Adv_EnableWindowJumpListTak", value);
            }
        }
    }
}
