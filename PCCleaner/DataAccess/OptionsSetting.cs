using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PCCleaner.Common;
using System.Windows.Forms;

namespace PCCleaner.DataAccess
{
    public static class OptionsSetting
    {
        static DataView DVOptionSettings = null;
        static OptionsSetting()
        {
            try
            {
                DataSet dataSet = CleanerApplicationSettings.GetApplicationSettings();
                DataView defaultView = dataSet.Tables[0].DefaultView;
                defaultView.RowFilter = "IsDefault=0";
                DVOptionSettings = defaultView;
            }
            catch(Exception ex)
            {
                ;
            }

        }

        private static string GetAttributeValue(string attribute)
        {
            string value = string.Empty;

            foreach (DataRow dr in DVOptionSettings.Table.Rows)
            {
                if (dr["Setting"].ToString() == attribute)
                {
                    value = dr["value"].ToString();
                }
            }
            return value;
        }
        private static void SetAttributeValue(string attributeName, bool value)
        {
            int newValue = 0;
            if (value == true)
            {
                newValue = 1;
            }
            string query = "UPDATE ApplicationSettings SET value='" + newValue + "' where isDefault=0 AND setting='" + attributeName + "'";
            DBAccess access = new DBAccess();
            access.ExecuteNonQuery(query);
        }

        public static bool IsRunCleanerOnStartup
        {
            get
            {

                return GetAttributeValue("Opt_Settings_RunCleanerOnStartup").Equals("1");
            }
            set
            {
                SetAttributeValue("Opt_Settings_RunCleanerOnStartup", value);
            }
        }

        public static bool IsAddRunCleanerToRecycleBinMenu
        {
            get
            {
                return GetAttributeValue("Opt_Settings_AddRunCleanerToRecycleBinMenu").Equals("1");
            }
            set
            {
                SetAttributeValue("Opt_Settings_AddRunCleanerToRecycleBinMenu", value);
            }
        }

        public static bool AddOpenCleanerToRecycleBinMenu
        {
            get
            {
                return GetAttributeValue("Opt_Settings_AddOpenCleanerToRecycleBinMenu").Equals("1");
            }
            set
            {
                SetAttributeValue("Opt_Settings_AddOpenCleanerToRecycleBinMenu", value);
            }
        }

        public static bool IsNormalFileDeletion
        {
            get
            {
                return GetAttributeValue("Opt_Settings_IsNormalFileDeletion").Equals("1");
            }
            set
            {
                SetAttributeValue("Opt_Settings_IsNormalFileDeletion", value);
            }
        }

        public static bool IsSecureFileDeletion
        {
            get
            {
                return GetAttributeValue("Opt_Settings_IsSecureFileDeletion").Equals("1");
            }
            set
            {
                SetAttributeValue("Opt_Settings_IsSecureFileDeletion", value);
            }
        }
    }
}
