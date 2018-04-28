using PCCleaner.Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        public static void AddSubscriptionInfo(string fullName,string emailAddress,string activationCode,string macAddress)
        {
            string createdOn = DateTime.Now.ToString();
            string query = "INSERT INTO Subscription(FullName,EmailAddress,ActivationCode,MacAddress,CreatedOn) VALUES('"+fullName+"','"+emailAddress+"','"+activationCode +"','"+macAddress+"','" + createdOn+"')";
            DBAccess access = new DBAccess();
            access.ExecuteNonQuery(query);
        }

        public static DataTable GetSubscriptionInfo()
        {
            string query = "Select FullName,EmailAddress,ActivationCode,MacAddress FROM Subscription";
            DBAccess access = new DBAccess();
            DataSet ds = access.GetDataSet(query);
            if(ds.Tables.Count > 0)
            {
                return ds.Tables[0];
            }
            return null;
        }

        public static async void IsSubscriptionValid(Form form) 
        {
            bool isValidSub = false;
            DataTable dataTable = GetSubscriptionInfo();

            string clientFullName = string.Empty;
            string clientEmailAddress = string.Empty;
            string clientActivationCode = string.Empty;
            string clientMacAddress = string.Empty;

            if (dataTable != null)
            {
                clientFullName = dataTable.Rows[0]["FullName"].ToString();
                clientEmailAddress = dataTable.Rows[0]["EmailAddress"].ToString();
                clientActivationCode = dataTable.Rows[0]["ActivationCode"].ToString();
                clientMacAddress = dataTable.Rows[0]["MacAddress"].ToString();
            }

            string currentMacId = Helper.GetMacId();

            HttpClientHandler handler = new HttpClientHandler()
            {
                UseDefaultCredentials = true
            };

            string subscriptionUrl = CleanerApplicationSettings.SubscriptionURL + "api/subscription/isvalidsubscription?";


            HttpClient httpClientSubApi = new HttpClient(handler);
            httpClientSubApi.BaseAddress = new Uri(CleanerApplicationSettings.SubscriptionURL);

            subscriptionUrl += "FullName=" + clientFullName;
            subscriptionUrl += "&EmailAddress=" + clientEmailAddress;
            subscriptionUrl += "&MacId=" + currentMacId;
            subscriptionUrl += "&activationCode=" + clientActivationCode;


            httpClientSubApi.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = await httpClientSubApi.GetAsync(subscriptionUrl);

            if (response.IsSuccessStatusCode)
            {
                string jsonResult = await response.Content.ReadAsStringAsync();

                if (jsonResult == "200")
                {
                    form.Controls.Find("labelProductActivation", true)[0].Visible = false;
                    isValidSub = true;
                }
            }
            if (!isValidSub)
            {
                var messageBox = new SubscriptionMessage();
                messageBox.ShowDialog();
            }
                
        }

        public static void AddSubscriptionRequest(string firstName,string lastName,string EmailAddress,string macId)
        {
            string query = "INSERT INTO UserSubscriptionRequest(FirstName,LastName,EmailAddress,MacId,CreatedOn) values('"+firstName+"','"+lastName+"','"+EmailAddress+"','"+macId+"','"+DateTime.Now.ToString()+"')";
            DBAccess access = new DBAccess();
            access.ExecuteNonQuery(query);
        }

        public static DataTable GetRequestUserInfo()
        {
            string fullName = string.Empty;
            string query = "Select FirstName,LastName,EmailAddress from UserSubscriptionRequest";
            DBAccess access = new DBAccess();
            DataSet ds = access.GetDataSet(query);
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count>0)
            {
                return ds.Tables[0];
            }
            return null;
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
