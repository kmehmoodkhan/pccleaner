using PCCleaner.DataAccess;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace PCCleaner.Common
{
    public static class CleanerApplicationSettings
    {
        //public static string SubscriptionURL => System.Configuration.ConfigurationSettings.AppSettings["SubscriptionURL"];

        public static string SubscriptionURL
        {
            
            get
            {
                string apiUrl = string.Empty;
                string appBasePath = CleanerApplicationSettings.ApplicationBasePath;
                string url = $@"{appBasePath}DB\API.xml";

                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(url);

                apiUrl = xmlDoc.InnerText;
                if(!string.IsNullOrEmpty(apiUrl))
                {
                    apiUrl = apiUrl.Replace("\r\n", "").Trim();
                }

                return apiUrl;
            }
        }
        public static string ApplicationBasePath
        {
            get
            {
                string path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location).ToLower();

                path = path.Replace("\\bin\\debug", "\\");

                return path;
                //return @"C:\Users\kausar\source\repos\PCCleaner\PCCleaner\";
            }
        }
        public static DataSet GetApplicationSettings()
        {
            DBAccess dBAccess = new DBAccess();
            var DataSet = dBAccess.GetDataSet("Select * from ApplicationSettings;");
            return DataSet;
        }

        public static DataSet GetSafeCookiesList()
        {
            DBAccess dBAccess = new DBAccess();
            var DataSet = dBAccess.GetDataSet("Select * from CookiesToPreserve WHERE IsDefault=0;");
            return DataSet;
        }

        public static DataSet GetIncludedItems()
        {
            DBAccess dBAccess = new DBAccess();
            var DataSet = dBAccess.GetDataSet("Select * from ExcludedPath where IsInclude=1");
            return DataSet;
        }

        public static DataSet GetExcludedItems()
        {
            DBAccess dBAccess = new DBAccess();
            var DataSet = dBAccess.GetDataSet("Select * from ExcludedPath where IsInclude=0");
            return DataSet;
        }

        public static void AddNewItem(string query)
        {
            DBAccess dBAccess = new DBAccess();
            dBAccess.ExecuteNonQuery(query);
        }

        public static void RemoveItem(string Id)
        {
            string query = "Delete from ExcludedPath where Id=" + Id + "";
            DBAccess dBAccess = new DBAccess();
            dBAccess.ExecuteNonQuery(query);
        }
    }
}
