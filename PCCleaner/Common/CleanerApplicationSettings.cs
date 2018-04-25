using PCCleaner.DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCCleaner.Common
{
    public static class CleanerApplicationSettings
    {
        public static string ApplicationBasePath
        {
            get
            {
                return @"C:\Users\kausar\source\repos\PCCleaner\PCCleaner\";
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
    }
}
