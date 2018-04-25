using Microsoft.Data.Sqlite;
using PCCleaner.Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCCleaner.DataAccess
{
    public static class CookiesSettings
    {
        static DataView DVOptionSettings = null;
        static CookiesSettings()
        {
            DataSet dataSet = CleanerApplicationSettings.GetSafeCookiesList();
            DataView defaultView = dataSet.Tables[0].DefaultView;
            defaultView.RowFilter = "IsDefault=0";
            DVOptionSettings = defaultView;
        }


        public static DataView GetCookiesList()
        {
            return DVOptionSettings;
        }

        public static List<string> GetAvailableCookies()
        {
            List<string> Cookies = new List<string>();
            //1. Edge Cookies
            string parentPath = Helper.GetBrowserInternetHistoryPath(SearchArea.Edge);
            try
            {
                var EdgeCookies = Directory.GetFiles(parentPath, "*.*", SearchOption.AllDirectories).ToList().Where(p => p.ToLower().Contains(".xml")).ToList();

                foreach(string cookie in EdgeCookies)
                {
                    if( !Cookies.Contains(cookie))
                        Cookies.Add(Path.GetFileName(cookie).Replace("[1].xml", ".com"));
                }
            }
            catch(Exception ex)
            {
                ;
            }

            //2. IE Cookies
            parentPath = Helper.GetBrowserInternetHistoryPath(SearchArea.IE);
            try
            {
                var IECookies = Directory.GetFiles(parentPath, "*.*", SearchOption.AllDirectories).ToList().Where(p => p.ToLower().Contains(".xml")).ToList();
                foreach( string cookie in IECookies)
                {
                    if(!Cookies.Contains(cookie))
                        Cookies.Add(cookie);
                }
            }
            catch (Exception ex)
            {
                ;
            }

            //3. Chrome Cookies
            parentPath = Helper.GetBrowserInternetHistoryPath(SearchArea.Chrome);
            parentPath += "\\user data\\default\\cookies";

            List<string> ChromeCookies = new List<string>();
            try
            {
                using (SqliteConnection conn = new SqliteConnection("Data Source=" + parentPath))
                {
                    String sql = "SELECT * FROM cookies";
                    conn.Open();
                    using (SqliteCommand cmd = new SqliteCommand(sql, conn))
                    {

                        using (SqliteDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                ChromeCookies.Add(reader.GetString(1));
                            }
                        }
                        conn.Close();
                    }
                }

                foreach (string cookie in ChromeCookies)
                {
                    if (!Cookies.Contains(cookie))
                        Cookies.Add(cookie);
                }
            }
            catch (Exception ex)
            {
                ;
            }
            //4. Firefox Cookies

            parentPath = Helper.GetBrowserInternetHistoryPath(SearchArea.Firefox);
            parentPath += "\\profiles\\kmzlampa.default\\";
            parentPath = parentPath.Replace("AppData\\Local\\Mozilla", "AppData\\roaming\\Mozilla");
            parentPath += "cookies.sqlite";


            List<string> FirefoxCookies = new List<string>();

            try
            {
                using (SqliteConnection conn = new SqliteConnection("Data Source=" + parentPath))
                {
                    String sql = "SELECT * FROM moz_cookies";
                    conn.Open();
                    using (SqliteCommand cmd = new SqliteCommand(sql, conn))
                    {

                        using (SqliteDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                FirefoxCookies.Add(reader.GetString(1));
                            }
                        }
                        conn.Close();
                    }
                }

                foreach (string cookie in FirefoxCookies)
                {
                    if (!Cookies.Contains(cookie))
                        Cookies.Add(cookie);
                }
            }
            catch (Exception ex)
            {
                ;
            }

            return Cookies;
        }

        public static void AddRemoveCookie(bool Add,string cookieName)
        {
            string query = string.Empty;
            if(Add)
            {
                query = "INSERT INTO CookiesToPreserve(Cookie,IsDefault) SELECT "+ cookieName + ",0;";
            }
            else
            {
                query = "Delete from CookiesToPreserve WHERE IsDefault=0 AND Cookie='"+cookieName+"';";
            }
            DBAccess access = new DBAccess();
            access.ExecuteNonQuery(query);
        }
    }
}
