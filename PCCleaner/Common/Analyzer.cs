using Microsoft.Data.Sqlite;
using Microsoft.Win32;
using PCCleaner.Controls.Common;
using PCCleaner.Properties;
using Shell32;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCCleaner.Common
{
    public static class Analyzer
    {
        public static List<ResultDetail> GetSearchResults(List<SearchCriteria> searchCriteria, ref BackgroundWorker backgroundWorker, bool isCleanerCall = false)
        {

            List<ResultDetail> result = new List<ResultDetail>();
            string[] files = null;
            string parentPath = string.Empty;

            int i = 0;
            int totalAreasToSearch = searchCriteria.Count;
            int areasCompleted = 0;

            foreach (SearchCriteria item in searchCriteria)
            {
                switch (item.SearchArea)
                {
                    #region Edge Browser
                    case (int)SearchArea.Edge:
                        BrowserFeatures feature = (BrowserFeatures)item.FeatureId;
                        switch (feature)
                        {
                            case BrowserFeatures.Cache:

                                parentPath = Helper.GetBrowserCachePath(SearchArea.Edge);

                                try
                                {
                                    string[] tempDirs = { "#!001", "#!002", "temp" };

                                    var tempFiles = Directory.GetFiles(parentPath, "*.*", SearchOption.AllDirectories).Where(t2 => tempDirs.Any(t1 => t2.Contains(t1)));
                                    files = tempFiles.Where(p => p.ToLower().Contains(@"cache")).ToArray();
                                    foreach (string fl in files)
                                    {
                                        if( !fl.ToLower().Contains("cryptnet"))
                                        result.Add(new ResultDetail() { FilePath = fl, FileSize = new FileInfo(fl).Length, SearchArea = SearchArea.Edge, FeatureArea = FeatureArea.Cache });
                                    }

                                }
                                catch (Exception ex)
                                {
                                    ;
                                }
                                break;
                            case BrowserFeatures.InternetHistory:

                                parentPath = Helper.GetBrowserInternetHistoryPath(SearchArea.Edge);
                                try
                                {
                                    files = Directory.GetFiles(parentPath, "*.*", SearchOption.AllDirectories).ToList().Where(p => p.ToLower().Contains("history")).ToArray();
                                }
                                catch (Exception ex)
                                {
                                    ;
                                }
                                foreach (string fl in files)
                                {
                                    result.Add(new ResultDetail() { FilePath = fl, FileSize = new FileInfo(fl).Length, SearchArea = SearchArea.Edge, FeatureArea = FeatureArea.InternetHistory });
                                }

                                break;
                            case BrowserFeatures.Cookies:
                                parentPath = Helper.GetBrowserInternetHistoryPath(SearchArea.Edge);
                                try
                                {
                                    files = Directory.GetFiles(parentPath, "*.*", SearchOption.AllDirectories).ToList().Where(p => p.ToLower().Contains(".xml")).ToArray();
                                }
                                catch (Exception ex)
                                {
                                    ;
                                }
                                foreach (string fl in files)
                                {
                                    result.Add(new ResultDetail() { FilePath = fl, FileSize = new FileInfo(fl).Length, SearchArea = SearchArea.Edge, FeatureArea = FeatureArea.Cookies });
                                }


                                break;
                            case BrowserFeatures.DownloadHistory:
                                parentPath = Helper.GetBrowserInternetHistoryPath(SearchArea.Edge);
                                try
                                {
                                    files = Directory.GetFiles(parentPath, "*.*", SearchOption.AllDirectories).ToList().Where(p => p.ToLower().Contains("downloadhistory")).ToArray();
                                }
                                catch (Exception ex)
                                {
                                    ;
                                }
                                foreach (string fl in files)
                                {
                                    result.Add(new ResultDetail() { FilePath = fl, FileSize = new FileInfo(fl).Length, SearchArea = SearchArea.Edge, FeatureArea = FeatureArea.DownloadHistory });
                                }


                                break;
                            case BrowserFeatures.LastDownloadLocation:
                                parentPath = KnownFolders.GetPath(KnownFolder.Downloads);
                                try
                                {
                                    files = Directory.GetFiles(parentPath, "*.*", SearchOption.AllDirectories).ToList().ToArray();
                                }
                                catch (Exception ex)
                                {
                                    ;
                                }
                                foreach (string fl in files)
                                {
                                    result.Add(new ResultDetail() { FilePath = fl, FileSize = new FileInfo(fl).Length, SearchArea = SearchArea.Edge, FeatureArea = FeatureArea.LastDownloadLocation });
                                }


                                break;
                            case BrowserFeatures.Session:
                                parentPath = Helper.GetBrowserInternetHistoryPath(SearchArea.Edge);
                                try
                                {
                                    files = Directory.GetFiles(parentPath, "*.*", SearchOption.AllDirectories).ToList().Where(p => p.ToLower().Contains("active")).ToArray();
                                }
                                catch (Exception ex)
                                {
                                    ;
                                }
                                foreach (string fl in files)
                                {
                                    result.Add(new ResultDetail() { FilePath = fl, FileSize = new FileInfo(fl).Length, SearchArea = SearchArea.Edge, FeatureArea = FeatureArea.Session });
                                }


                                break;

                        }
                        break;
                    #endregion

                    #region IE Browser
                    case (int)SearchArea.IE:
                        BrowserFeatures featureIE = (BrowserFeatures)item.FeatureId;
                        switch (featureIE)
                        {
                            case BrowserFeatures.Cache:
                                parentPath = Environment.GetFolderPath(Environment.SpecialFolder.InternetCache);
                                parentPath += "\\IE\\";
                                try
                                {
                                    files = Directory.GetFiles(parentPath, "*.*", SearchOption.AllDirectories).ToList().ToArray();
                                }
                                catch (Exception ex)
                                {
                                    ;
                                }
                                foreach (string fl in files)
                                {
                                    result.Add(new ResultDetail() { FilePath = fl, FileSize = new FileInfo(fl).Length, SearchArea = SearchArea.IE, FeatureArea = FeatureArea.Cache });
                                }


                                break;
                            case BrowserFeatures.InternetHistory:

                                parentPath = Helper.GetBrowserInternetHistoryPath(SearchArea.IE);
                                try
                                {
                                    files = Directory.GetFiles(parentPath, "*.*", SearchOption.AllDirectories).ToList().Where(p => p.ToLower().Contains("recovery")).ToArray();
                                }
                                catch (Exception ex)
                                {
                                    ;
                                }
                                foreach (string fl in files)
                                {
                                    result.Add(new ResultDetail() { FilePath = fl, FileSize = new FileInfo(fl).Length, SearchArea = SearchArea.IE, FeatureArea = FeatureArea.InternetHistory });
                                }


                                break;
                            case BrowserFeatures.Cookies:
                                parentPath = Helper.GetCookiesPath(SearchArea.IE);
                                try
                                {
                                    files = Directory.GetFiles(parentPath, "*.*", SearchOption.AllDirectories).ToList().Where(p => p.ToLower().Contains(".xml")).ToArray();
                                }
                                catch (Exception ex)
                                {
                                    ;
                                }
                                foreach (string fl in files)
                                {
                                    result.Add(new ResultDetail() { FilePath = fl, FileSize = new FileInfo(fl).Length, SearchArea = SearchArea.IE, FeatureArea = FeatureArea.Cookies });
                                }


                                break;
                            case BrowserFeatures.DownloadHistory:
                                parentPath = Helper.GetBrowserInternetHistoryPath(SearchArea.IE);
                                try
                                {
                                    files = Directory.GetFiles(parentPath, "*.*", SearchOption.AllDirectories).ToList().Where(p => p.ToLower().Contains("downloadhistory")).ToArray();
                                }
                                catch (Exception ex)
                                {
                                    ;
                                }
                                foreach (string fl in files)
                                {
                                    result.Add(new ResultDetail() { FilePath = fl, FileSize = new FileInfo(fl).Length, SearchArea = SearchArea.IE, FeatureArea = FeatureArea.DownloadHistory });
                                }


                                break;
                            case BrowserFeatures.LastDownloadLocation:
                                parentPath = KnownFolders.GetPath(KnownFolder.Downloads);
                                try
                                {
                                    files = Directory.GetFiles(parentPath, "*.*", SearchOption.AllDirectories).ToList().ToArray();
                                }
                                catch (Exception ex)
                                {
                                    ;
                                }
                                foreach (string fl in files)
                                {
                                    result.Add(new ResultDetail() { FilePath = fl, FileSize = new FileInfo(fl).Length, SearchArea = SearchArea.IE, FeatureArea = FeatureArea.LastDownloadLocation });
                                }


                                break;
                            case BrowserFeatures.Session:
                                parentPath = Helper.GetBrowserInternetHistoryPath(SearchArea.IE);
                                try
                                {
                                    files = Directory.GetFiles(parentPath, "*.*", SearchOption.AllDirectories).ToList().Where(p => p.ToLower().Contains("active")).ToArray();
                                }
                                catch (Exception ex)
                                {
                                    ;
                                }
                                foreach (string fl in files)
                                {
                                    result.Add(new ResultDetail() { FilePath = fl, FileSize = new FileInfo(fl).Length, SearchArea = SearchArea.IE, FeatureArea = FeatureArea.Session });
                                }


                                break;

                        }
                        break;
                    #endregion

                    #region Chrome Browser
                    case (int)SearchArea.Chrome:
                        BrowserFeatures featureChrome = (BrowserFeatures)item.FeatureId;
                        switch (featureChrome)
                        {
                            case BrowserFeatures.Cache:

                                parentPath = Helper.GetBrowserCachePath(SearchArea.Chrome);
                                parentPath += "\\user data\\";
                                try
                                {
                                    files = Directory.GetFiles(parentPath, "*.*", SearchOption.AllDirectories).ToList().ToArray();
                                }
                                catch (Exception ex)
                                {
                                    ;
                                }
                                foreach (string fl in files)
                                {
                                    result.Add(new ResultDetail() { FilePath = fl, FileSize = new FileInfo(fl).Length, SearchArea = SearchArea.Chrome, FeatureArea = FeatureArea.Cache });
                                }


                                break;
                            case BrowserFeatures.InternetHistory:
                                parentPath = Helper.GetBrowserInternetHistoryPath(SearchArea.Chrome);
                                parentPath += "\\user data\\default\\history";

                                try
                                {
                                    using (SqliteConnection conn = new SqliteConnection("Data Source=" + parentPath))
                                    {
                                        String sql = "Select * From urls";
                                        conn.Open();
                                        using (SqliteCommand cmd = new SqliteCommand(sql, conn))
                                        {

                                            using (SqliteDataReader reader = cmd.ExecuteReader())
                                            {
                                                while (reader.Read())
                                                {
                                                    result.Add(new ResultDetail() { FilePath = reader.GetString(1), FileSize = 1, SearchArea = SearchArea.Chrome, FeatureArea = FeatureArea.Cookies });
                                                }
                                            }
                                            conn.Close();
                                        }
                                    }

                                }
                                catch (Exception ex)
                                {
                                    ;
                                }
                                break;
                            case BrowserFeatures.Cookies:

                                parentPath = Helper.GetBrowserInternetHistoryPath(SearchArea.Chrome);
                                parentPath += "\\user data\\default\\cookies";

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
                                                    if (result.Where(t => t.FilePath == "Cookie: " + reader.GetString(1)).ToList().Count < 1)
                                                    {
                                                        result.Add(new ResultDetail() { FilePath = "Cookie: " + reader.GetString(1), FileSize = 1, SearchArea = SearchArea.Chrome, FeatureArea = FeatureArea.Cookies });
                                                    }
                                                }
                                            }
                                            conn.Close();
                                        }
                                    }

                                }
                                catch (Exception ex)
                                {
                                    ;
                                }

                                break;
                            case BrowserFeatures.DownloadHistory:
                                parentPath = Helper.GetBrowserInternetHistoryPath(SearchArea.Chrome);
                                parentPath += "\\user data\\default\\DownloadMetadata";

                                try
                                {
                                    result.Add(new ResultDetail() { FilePath = parentPath, FileSize = new FileInfo(parentPath).Length, SearchArea = SearchArea.Chrome, FeatureArea = FeatureArea.DownloadHistory });
                                }
                                catch (Exception ex)
                                {
                                    ;
                                }
                                break;
                            case BrowserFeatures.LastDownloadLocation:
                                parentPath = KnownFolders.GetPath(KnownFolder.Downloads);
                                try
                                {
                                    files = Directory.GetFiles(parentPath, "*.*", SearchOption.AllDirectories).ToList().ToArray();
                                    foreach (string fl in files)
                                    {
                                        result.Add(new ResultDetail() { FilePath = fl, FileSize = new FileInfo(fl).Length, SearchArea = SearchArea.Chrome, FeatureArea = FeatureArea.LastDownloadLocation });
                                    }

                                }
                                catch (Exception ex)
                                {
                                    ;
                                }
                                break;
                            case BrowserFeatures.Session:
                                parentPath = Helper.GetBrowserInternetHistoryPath(SearchArea.Chrome);
                                parentPath += "\\user data\\default\\Session Storage";

                                try
                                {
                                    files = Directory.GetFiles(parentPath, "*.*", SearchOption.AllDirectories).ToList().ToArray();
                                }
                                catch (Exception ex)
                                {
                                    ;
                                }
                                foreach (string fl in files)
                                {
                                    result.Add(new ResultDetail() { FilePath = fl, FileSize = new FileInfo(fl).Length, SearchArea = SearchArea.Chrome, FeatureArea = FeatureArea.Session });
                                }

                                parentPath = Helper.GetBrowserInternetHistoryPath(SearchArea.Chrome);
                                parentPath += "\\user data\\default\\Extension State";

                                try
                                {
                                    files = Directory.GetFiles(parentPath, "*.*", SearchOption.AllDirectories).ToList().ToArray();
                                }
                                catch (Exception ex)
                                {
                                    ;
                                }
                                foreach (string fl in files)
                                {
                                    result.Add(new ResultDetail() { FilePath = fl, FileSize = new FileInfo(fl).Length, SearchArea = SearchArea.Chrome, FeatureArea = FeatureArea.Session });
                                }




                                break;

                            case BrowserFeatures.SavedPassword:
                                parentPath = Helper.GetBrowserInternetHistoryPath(SearchArea.Chrome);
                                parentPath += "\\user data\\default\\Login Data";

                                try
                                {
                                    result.Add(new ResultDetail() { FilePath = parentPath, FileSize = new FileInfo(parentPath).Length, SearchArea = SearchArea.Chrome, FeatureArea = FeatureArea.SavedPassword });

                                }
                                catch (Exception ex)
                                {
                                    ;
                                }

                                break;

                        }
                        break;
                    #endregion

                    #region Firefox Browser
                    case (int)SearchArea.Firefox:
                        BrowserFeatures firefoxFeature = (BrowserFeatures)item.FeatureId;
                        switch (firefoxFeature)
                        {
                            case BrowserFeatures.Cache:

                                parentPath = Helper.GetBrowserCachePath(SearchArea.Firefox);
                                parentPath += "\\profiles\\";
                                try
                                {
                                    files = Directory.GetFiles(parentPath, "*.*", SearchOption.AllDirectories).ToList().Where(p => p.ToLower().Contains("cache")).ToArray();
                                }
                                catch (Exception ex)
                                {
                                    ;
                                }
                                foreach (string fl in files)
                                {
                                    result.Add(new ResultDetail() { FilePath = fl, FileSize = new FileInfo(fl).Length, SearchArea = SearchArea.Firefox, FeatureArea = FeatureArea.Cache });
                                }


                                break;
                            case BrowserFeatures.InternetHistory:
                                parentPath = Helper.GetBrowserInternetHistoryPath(SearchArea.Firefox);
                                parentPath += "\\profiles\\";

                                try
                                {
                                    files = Directory.GetFiles(parentPath, "*.*", SearchOption.AllDirectories).ToList().Where(p => p.ToLower().Contains("thumbnails")).ToArray();
                                }
                                catch (Exception ex)
                                {
                                    ;
                                }
                                foreach (string fl in files)
                                {
                                    result.Add(new ResultDetail() { FilePath = fl, FileSize = new FileInfo(fl).Length, SearchArea = SearchArea.Firefox, FeatureArea = FeatureArea.Cache });
                                }


                                break;
                            case BrowserFeatures.Cookies:


                                parentPath = Helper.GetBrowserInternetHistoryPath(SearchArea.Firefox);
                                parentPath += "\\profiles\\kmzlampa.default\\";
                                parentPath = parentPath.Replace("AppData\\Local\\Mozilla", "AppData\\roaming\\Mozilla");
                                parentPath += "cookies.sqlite";


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
                                                    if (result.Where(t => t.FilePath == "Cookie: " + reader.GetString(1)).ToList().Count < 1)
                                                    {
                                                        result.Add(new ResultDetail() { FilePath = "Cookie: " + reader.GetString(1), FileSize = 1, SearchArea = SearchArea.Firefox, FeatureArea = FeatureArea.Cookies });
                                                    }
                                                }
                                            }
                                            conn.Close();
                                        }
                                    }

                                }
                                catch (Exception ex)
                                {
                                    ;
                                }

                                break;
                            case BrowserFeatures.DownloadHistory:
                                try
                                {
                                    parentPath = Helper.GetBrowserInternetHistoryPath(SearchArea.Firefox);
                                    parentPath += "\\user data\\default\\DownloadMetadata";

                                    result.Add(new ResultDetail() { FilePath = parentPath, FileSize = new FileInfo(parentPath).Length, SearchArea = SearchArea.Firefox, FeatureArea = FeatureArea.DownloadHistory });
                                }
                                catch (Exception ex)
                                {
                                    ;
                                }
                                break;
                            case BrowserFeatures.LastDownloadLocation:
                                parentPath = KnownFolders.GetPath(KnownFolder.Downloads);
                                try
                                {
                                    files = Directory.GetFiles(parentPath, "*.*", SearchOption.AllDirectories).ToList().ToArray();
                                    foreach (string fl in files)
                                    {
                                        result.Add(new ResultDetail() { FilePath = fl, FileSize = new FileInfo(fl).Length, SearchArea = SearchArea.Firefox, FeatureArea = FeatureArea.LastDownloadLocation });
                                    }
                                }
                                catch (Exception ex)
                                {
                                    ;
                                }
                                break;
                            case BrowserFeatures.Session:
                                parentPath = Helper.GetBrowserInternetHistoryPath(SearchArea.Firefox);
                                parentPath += "\\profiles\\";

                                parentPath = parentPath.Replace("AppData\\Local\\Mozilla", "AppData\\roaming\\Mozilla");

                                try
                                {
                                    files = Directory.GetFiles(parentPath, "*.*", SearchOption.AllDirectories).Where(p => p.ToLower().Contains("session")).ToList().ToArray();
                                    foreach (string fl in files)
                                    {
                                        result.Add(new ResultDetail() { FilePath = fl, FileSize = new FileInfo(fl).Length, SearchArea = SearchArea.Firefox, FeatureArea = FeatureArea.Session });
                                    }

                                }
                                catch (Exception ex)
                                {
                                    ;
                                }

                                break;

                            case BrowserFeatures.SavedFormInformation:
                                parentPath = Helper.GetBrowserInternetHistoryPath(SearchArea.Firefox);
                                parentPath += "\\profiles\\kmzlampa.default\\";
                                parentPath = parentPath.Replace("AppData\\Local\\Mozilla", "AppData\\roaming\\Mozilla");

                                parentPath += "\\permissions.sqlite";

                                try
                                {
                                    result.Add(new ResultDetail() { FilePath = parentPath, FileSize = new FileInfo(parentPath).Length, SearchArea = SearchArea.Firefox, FeatureArea = FeatureArea.SavedPassword });

                                }
                                catch (Exception ex)
                                {
                                    ;
                                }

                                break;

                            case BrowserFeatures.SavedPassword:
                                try
                                {
                                    parentPath = Helper.GetBrowserInternetHistoryPath(SearchArea.Firefox);
                                    parentPath += "\\user data\\default\\Login Data";

                                    result.Add(new ResultDetail() { FilePath = parentPath, FileSize = new FileInfo(parentPath).Length, SearchArea = SearchArea.Firefox, FeatureArea = FeatureArea.SavedPassword });
                                }
                                catch
                                {
                                    ;
                                }

                                break;
                        }
                        break;
                    #endregion

                    #region Window Explorer
                    case (int)SearchArea.WindowExplorer:
                        ExplorerFeatures recentDocs = (ExplorerFeatures)item.FeatureId;
                        switch (recentDocs)
                        {
                            case ExplorerFeatures.RecentDocuments:
                                parentPath = Environment.GetFolderPath(Environment.SpecialFolder.Recent);
                                files = Directory.GetFiles(parentPath, "*.*", SearchOption.AllDirectories).Where(p => !p.Contains(@"\AutomaticDestinations") && !p.Contains(@"\CustomDestinations")).ToArray();
                                foreach (string fl in files)
                                {
                                    result.Add(new ResultDetail() { FilePath = fl, FileSize = new FileInfo(fl).Length, SearchArea = SearchArea.WindowExplorer, FeatureArea = FeatureArea.RecentDocuments });
                                }


                                break;
                        }
                        break;
                    #endregion

                    #region System
                    case (int)SearchArea.System:
                        SystemFeatures systemFeatures = (SystemFeatures)item.FeatureId;
                        switch (systemFeatures)
                        {
                            case SystemFeatures.EmptyRecycleBin:
                                Type t = Type.GetTypeFromProgID("Shell.Application");

                                dynamic shell = Activator.CreateInstance(t);

                                Folder recycleBin = shell.NameSpace(10);

                               

                                try
                                {                                   
                                    var items = recycleBin.Items();
                                    foreach (FolderItem2 recfile in recycleBin.Items())
                                    {
                                        result.Add(new ResultDetail() { FilePath = recfile.Name, FileSize = 1, SearchArea = SearchArea.System, FeatureArea = FeatureArea.EmptyRecycleBin });
                                    }

                                    Marshal.FinalReleaseComObject(shell);
                                }
                                catch (Exception ex)
                                {
                                    ;
                                }


                                break;

                            case SystemFeatures.TemporaryFiles:
                                parentPath = @"C:\Windows\Temp";
                                try
                                {
                                    files = Directory.GetFiles(parentPath, "*.*", SearchOption.AllDirectories);

                                }
                                catch (Exception ex)
                                {
                                    ;
                                }

                                foreach (string fl in files)
                                {
                                    result.Add(new ResultDetail() { FilePath = fl, FileSize = new FileInfo(fl).Length, SearchArea = SearchArea.System, FeatureArea = FeatureArea.TemporaryFiles });
                                }

                                try
                                {
                                    parentPath = Path.GetTempPath();
                                    files = Directory.GetFiles(parentPath, "*.*", SearchOption.AllDirectories);

                                }
                                catch (Exception ex)
                                {
                                    ;
                                }

                                foreach (string fl in files)
                                {
                                    result.Add(new ResultDetail() { FilePath = fl, FileSize = new FileInfo(fl).Length, SearchArea = SearchArea.System, FeatureArea = FeatureArea.TemporaryFiles });
                                }


                                break;

                            case SystemFeatures.MemoryDumps:
                                parentPath = @"C:\Windows\LiveKernelReports\";
                                try
                                {
                                    files = Directory.GetFiles(parentPath, "*.*", SearchOption.AllDirectories).Where(dm => dm.ToLower().Contains(".dmp")).ToArray();

                                }
                                catch (Exception ex)
                                {
                                    ;
                                }
                                foreach (string fl in files)
                                {
                                    result.Add(new ResultDetail() { FilePath = fl, FileSize = new FileInfo(fl).Length, SearchArea = SearchArea.System, FeatureArea = FeatureArea.MemoryDumps });
                                }


                                break;
                            case SystemFeatures.WindowsLogFiles:
                                parentPath = @"C:\windows\";
                                try
                                {
                                    files = Directory.GetFiles(parentPath, "*.log", SearchOption.AllDirectories);
                                }
                                catch (Exception ex)
                                {
                                    ;
                                }
                                foreach (string fl in files)
                                {
                                    try
                                    {
                                        result.Add(new ResultDetail() { FilePath = fl, FileSize = new FileInfo(fl).Length, SearchArea = SearchArea.System, FeatureArea = FeatureArea.WindowsLogFiles });
                                    }
                                    catch (Exception ex)
                                    {
                                        ;
                                    }
                                }

                                break;

                            case SystemFeatures.WindowErrorReporting:
                                parentPath = @"C:\ProgramData\Microsoft\Windows\WER\ReportArchive\";
                                try
                                {
                                    files = Directory.GetFiles(parentPath, "*.*", SearchOption.AllDirectories);
                                }
                                catch (Exception ex)
                                {
                                    ;
                                }
                                foreach (string fl in files)
                                {
                                    try
                                    {
                                        result.Add(new ResultDetail() { FilePath = fl, FileSize = new FileInfo(fl).Length, SearchArea = SearchArea.System, FeatureArea = FeatureArea.WindowErrorReporting });
                                    }
                                    catch (Exception ex)
                                    {
                                        ;
                                    }
                                }


                                break;

                            case SystemFeatures.FontCache:
                                try
                                {
                                    parentPath = @"C:\Windows\System32\FNTCACHE.DAT";
                                    result.Add(new ResultDetail() { FilePath = parentPath, FileSize = new FileInfo(parentPath).Length, SearchArea = SearchArea.System, FeatureArea = FeatureArea.FontCache });
                                }
                                catch (Exception ex)
                                {
                                    ;
                                }

                                break;

                            case SystemFeatures.StartMenuShortCuts:
                                parentPath = Environment.GetFolderPath(Environment.SpecialFolder.StartMenu);

                                try
                                {
                                    files = Directory.GetFiles(parentPath, "*.*", SearchOption.AllDirectories);
                                }
                                catch (Exception ex)
                                {
                                    ;
                                }
                                foreach (string fl in files)
                                {
                                    try
                                    {
                                        result.Add(new ResultDetail() { FilePath = fl, FileSize = new FileInfo(fl).Length, SearchArea = SearchArea.System, FeatureArea = FeatureArea.StartMenuShortCuts });
                                    }
                                    catch (Exception ex)
                                    {
                                        ;
                                    }
                                }


                                break;
                            case SystemFeatures.DesktopShortCuts:
                                parentPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                                try
                                {
                                    files = Directory.GetFiles(parentPath, "*.*", SearchOption.AllDirectories);
                                }
                                catch (Exception ex)
                                {
                                    ;
                                }
                                foreach (string fl in files)
                                {
                                    try
                                    {
                                        result.Add(new ResultDetail() { FilePath = fl, FileSize = new FileInfo(fl).Length, SearchArea = SearchArea.System, FeatureArea = FeatureArea.DesktopShortCuts });
                                    }
                                    catch (Exception ex)
                                    {
                                        ;
                                    }
                                }


                                break;
                        }
                        break;
                    #endregion

                    #region Advanced
                    case (int)SearchArea.Advanced:
                        AdvancedFeatures advancedFeatures = (AdvancedFeatures)item.FeatureId;
                        switch (advancedFeatures)
                        {
                            case AdvancedFeatures.WindowsEventLogs:
                                parentPath = @"C:\Windows\event";
                                try
                                {
                                    try
                                    {
                                        files = Directory.GetFiles(parentPath, "*.*", SearchOption.AllDirectories);
                                    }
                                    catch (Exception ex)
                                    {
                                        ;
                                    }
                                    foreach (string fl in files)
                                    {
                                        result.Add(new ResultDetail() { FilePath = fl, FileSize = new FileInfo(fl).Length, SearchArea = SearchArea.Advanced, FeatureArea = FeatureArea.WindowsEventLogs });
                                    }

                                }
                                catch
                                {
                                    ;
                                }

                                break;

                            case AdvancedFeatures.OldPrefetchedData:
                                parentPath = @"C:\Windows\prefetch\";
                                try
                                {
                                    files = Directory.GetFiles(parentPath, "*.*", SearchOption.AllDirectories);
                                }
                                catch (Exception ex)
                                {
                                    ;
                                }
                                foreach (string fl in files)
                                {
                                    result.Add(new ResultDetail() { FilePath = fl, FileSize = new FileInfo(fl).Length, SearchArea = SearchArea.Advanced, FeatureArea = FeatureArea.OldPrefetchedData });
                                }



                                break;

                            case AdvancedFeatures.IISLogFiles:
                                parentPath = @"C:\inetpub\logs\LogFiles\W3SVC2\";
                                try
                                {
                                    files = Directory.GetFiles(parentPath, "*.*", SearchOption.AllDirectories);
                                }
                                catch (Exception ex)
                                {
                                    ;
                                }
                                foreach (string fl in files)
                                {
                                    result.Add(new ResultDetail() { FilePath = fl, FileSize = new FileInfo(fl).Length, SearchArea = SearchArea.Advanced, FeatureArea = FeatureArea.IISLogFiles });
                                }



                                break;

                            case AdvancedFeatures.OldWindowsInstallation:
                                parentPath = "C:\\Windows.old";
                                try
                                {
                                    files = Directory.GetFiles(parentPath, "*.*", SearchOption.AllDirectories);
                                }
                                catch (Exception ex)
                                {
                                    ;
                                }
                                foreach (string fl in files)
                                {
                                    result.Add(new ResultDetail() { FilePath = fl, FileSize = new FileInfo(fl).Length, SearchArea = SearchArea.Advanced, FeatureArea = FeatureArea.OldWindowsInstallation });
                                }



                                break;
                        }
                        break;
                    #endregion

                    #region WindowsStore
                    case (int)SearchArea.WindowsStore:
                        WindowStore windowsStore = (WindowStore)item.FeatureId;
                        switch (windowsStore)
                        {
                            case WindowStore.BingNews:
                                try
                                {
                                    parentPath = @"C:\Windows\bing";
                                    try
                                    {
                                        files = Directory.GetFiles(parentPath, "*.*", SearchOption.AllDirectories);
                                    }
                                    catch (Exception ex)
                                    {
                                        ;
                                    }
                                    foreach (string fl in files)
                                    {
                                        result.Add(new ResultDetail() { FilePath = fl, FileSize = new FileInfo(fl).Length, SearchArea = SearchArea.WindowsStore, FeatureArea = FeatureArea.WindowsEventLogs });
                                    }
                                }
                                catch (Exception ex)
                                {
                                    ;
                                }
                                break;

                            case WindowStore.SkypeMetro:
                                parentPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);

                                parentPath += "\\packages\\";

                                try
                                {
                                    var dirFound = Directory.GetDirectories(parentPath, "*.*", SearchOption.AllDirectories).Where(t => t.ToLower().Contains("microsoft.skypeapp")).ToArray();

                                    var contentDir = dirFound.Where(t => t.ToLower().Contains(@"content")).ToList();

                                    foreach (var dir in contentDir)
                                    {
                                        files = Directory.GetFiles(dir, "*.*", SearchOption.AllDirectories);
                                        foreach (string fl in files)
                                        {
                                            result.Add(new ResultDetail() { FilePath = fl, FileSize = new FileInfo(fl).Length, SearchArea = SearchArea.WindowsStore, FeatureArea = FeatureArea.WindowsEventLogs });
                                        }
                                    }

                                }
                                catch (Exception ex)
                                {
                                    ;
                                }


                                break;
                        }
                        break;

                    #endregion

                    #region Applications
                    case (int)SearchArea.Applications:
                        Applications applications = (Applications)item.FeatureId;
                        switch (applications)
                        {
                            case Applications.AdobeReader:
                                parentPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);

                                try
                                {
                                    Helper.DirSearch(parentPath, "adobe");
                                    files = Helper.FilesFound.ToArray();

                                    foreach (string fl in files)
                                    {
                                        result.Add(new ResultDetail() { FilePath = fl, FileSize = new FileInfo(fl).Length, SearchArea = SearchArea.Applications, FeatureArea = FeatureArea.AdobeReader });

                                    }
                                    Helper.FilesFound.Clear();

                                }
                                catch (Exception ex)
                                {
                                    ;
                                }
                                break;

                            case Applications.McAFee:
                                parentPath = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);

                                try
                                {
                                    Helper.DirSearch(parentPath, "mcafee");
                                    files = Helper.FilesFound.ToArray();

                                    foreach (string fl in files)
                                    {
                                        result.Add(new ResultDetail() { FilePath = fl, FileSize = new FileInfo(fl).Length, SearchArea = SearchArea.Applications, FeatureArea = FeatureArea.McAFee });

                                    }
                                    Helper.FilesFound.Clear();
                                }
                                catch (Exception ex)
                                {
                                    ;
                                }

                                break;
                            case Applications.NotepadPlus:
                                parentPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                                parentPath += "\\notepad++\\session.xml";

                                try
                                {
                                    result.Add(new ResultDetail() { FilePath = parentPath, FileSize = new FileInfo(parentPath).Length, SearchArea = SearchArea.Applications, FeatureArea = FeatureArea.NotepadPlus });

                                }
                                catch (Exception ex)
                                {
                                    ;
                                }
                                break;

                            case Applications.Office:
                                parentPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                                parentPath += "\\notepad++\\session.xml";

                                try
                                {
                                    result.Add(new ResultDetail() { FilePath = parentPath, FileSize = new FileInfo(parentPath).Length, SearchArea = SearchArea.Applications, FeatureArea = FeatureArea.Office });
                                }
                                catch (Exception ex)
                                {
                                    ;
                                }


                                break;
                        }
                        break;
                    #endregion

                    #region Internet
                    case (int)SearchArea.Internet:
                        Internet internet = (Internet)item.FeatureId;
                        switch (internet)
                        {
                            case Internet.UTorrent:
                                parentPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                                parentPath += "\\utorrent\\";

                                try
                                {
                                    files = Directory.GetFiles(parentPath, "*.*", SearchOption.AllDirectories);
                                    foreach (string fl in files)
                                    {
                                        try
                                        {
                                            if (fl.Contains(".old"))
                                                result.Add(new ResultDetail() { FilePath = fl, FileSize = new FileInfo(fl).Length, SearchArea = SearchArea.Internet, FeatureArea = FeatureArea.UTorrent });
                                        }
                                        catch
                                        {
                                            ;
                                        }
                                    }
                                }
                                catch (Exception ex)
                                {
                                    ;
                                }


                                break;
                        }
                        break;
                    #endregion

                    #region Utilities
                    case (int)SearchArea.Utilities:
                        Utilities utilities = (Utilities)item.FeatureId;
                        switch (utilities)
                        {
                            case Utilities.Teamviewer:
                                parentPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                                parentPath += "\\teamviewer\\";

                                try
                                {
                                    files = Directory.GetFiles(parentPath, "*.*", SearchOption.AllDirectories);
                                }
                                catch (Exception ex)
                                {
                                    ;
                                }
                                foreach (string fl in files)
                                {
                                    try
                                    {
                                        if (fl.Contains(".tvc"))
                                            result.Add(new ResultDetail() { FilePath = fl, FileSize = new FileInfo(fl).Length, SearchArea = SearchArea.Utilities, FeatureArea = FeatureArea.Teamviewer });
                                    }
                                    catch
                                    {
                                        ;
                                    }
                                }



                                break;

                            case Utilities.WindowsDefender:
                                parentPath = @"C:\ProgramData\Microsoft\Windows Defender\Scans\History\Results\";

                                try
                                {
                                    files = Directory.GetFiles(parentPath, "*.*", SearchOption.AllDirectories);
                                }
                                catch (Exception ex)
                                {
                                    ;
                                }
                                foreach (string fl in files)
                                {
                                    try
                                    {
                                        result.Add(new ResultDetail() { FilePath = fl, FileSize = new FileInfo(fl).Length, SearchArea = SearchArea.Utilities, FeatureArea = FeatureArea.WindowsDefender });

                                    }
                                    catch
                                    {
                                        ;
                                    }
                                }



                                break;
                        }
                        break;
                    #endregion

                    #region Internet
                    case (int)SearchArea.Windows:
                        Windows windows = (Windows)item.FeatureId;
                        switch (windows)
                        {
                            case Windows.RemoteDesktop:
                                parentPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                                parentPath += "\\Microsoft\\Terminal Server Client\\Cache\\";

                                try
                                {
                                    files = Directory.GetFiles(parentPath, "*.*", SearchOption.AllDirectories);
                                }
                                catch (Exception ex)
                                {
                                    ;
                                }
                                foreach (string fl in files)
                                {
                                    try
                                    {
                                        result.Add(new ResultDetail() { FilePath = fl, FileSize = new FileInfo(fl).Length, SearchArea = SearchArea.Windows, FeatureArea = FeatureArea.RemoteDesktop });
                                    }
                                    catch
                                    {
                                        ;
                                    }
                                }



                                break;
                        }
                        break;
                    #endregion

                    #region Registry
                    case (int)SearchArea.Registry:
                        RegistryOptions registry = (RegistryOptions)item.FeatureId;
                        switch (registry)
                        {
                            case RegistryOptions.MissingSharedDlls:

                                RegistryKey key = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\SharedDLLs");
                                foreach (var v in key.GetValueNames())
                                {
                                    try
                                    {
                                        FileInfo file = new FileInfo(v);
                                        if (!file.Exists)
                                        {
                                            result.Add(new ResultDetail() { FilePath = v, FileSize = 0, SearchArea = SearchArea.Registry, FeatureArea = FeatureArea.MissingSharedDlls, RegistryKey = @"HKLM\SOFTWARE\Microsoft\Windows\CurrentVersion\SharedDLLs" });
                                        }
                                    }
                                    catch (Exception ex)
                                    {
                                        ;
                                    }
                                }
                                break;

                            case RegistryOptions.UnUsedFileExtensions:
                                RegistryKey unused = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Explorer\FileExts");
                                var subkeysFileExtensions = unused.GetSubKeyNames();

                                foreach (string subkey in subkeysFileExtensions)
                                {
                                    int length = 0;
                                    RegistryKey fileKey = unused.OpenSubKey(subkey);
                                    string[] subKeyNames = fileKey.GetSubKeyNames();
                                    string[] temp = fileKey.GetValueNames();

                                    foreach (string subKey in subKeyNames)
                                    {
                                        string[] names = fileKey.OpenSubKey(subKey).GetValueNames();
                                        if (names.Length > 0)
                                        {
                                            length += 1;
                                        }
                                    }

                                    if (length < 1)
                                    {
                                        result.Add(new ResultDetail() { FilePath = subkey, FileSize = 0, SearchArea = SearchArea.Registry, FeatureArea = FeatureArea.UnUsedFileExtensions, RegistryKey = @"HKCU\Software\Microsoft\Windows\CurrentVersion\Explorer\FileExts" });
                                    }
                                }
                                break;
                            case RegistryOptions.ActivexAndClassIssues:
                                {
                                    string[] subKeyNames = Registry.ClassesRoot.GetSubKeyNames();
                                    //string[] fontsAvailable = Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "*.*");
                                    //var keys1 = key1.GetValueNames();
                                    //Parallel.ForEach(keys1, v =>
                                    //{
                                    //    try
                                    //    {

                                    //        string fontfile = key1.GetValue(v).ToString();

                                    //        if (fontsAvailable.Where(t => Path.GetFileName(t.ToLower()) == fontfile.ToLower()).Count() < 1)
                                    //        {
                                    //            if (!new FileInfo(fontfile).Exists)
                                    //                result.Add(new ResultDetail() { FilePath = v, FileSize = 0, SearchArea = SearchArea.Registry, FeatureArea = FeatureArea.Fonts, RegistryKey = @"HKLM\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Fonts" });
                                    //        }
                                    //    }
                                    //    catch (Exception ex)
                                    //    {
                                    //        ;
                                    //    }
                                    //});
                                }
                                break;
                            case RegistryOptions.TypeLibraries:
                                {
                                    RegistryKey key1 = Registry.ClassesRoot.OpenSubKey("TypeLib");
                                    var keys1 = key1.GetSubKeyNames();
                                    Parallel.ForEach(keys1, v =>
                                    {
                                        try
                                        {
                                            RegistryKey regkey;
                                            string tempPath = string.Format(@"TypeLib\{0}", v);
                                            regkey = Registry.ClassesRoot.OpenSubKey(tempPath);
                                            var subKeys = regkey.GetSubKeyNames();

                                            tempPath += "\\" + subKeys[0];

                                            RegistryKey MyReg = Registry.ClassesRoot.OpenSubKey(tempPath);

                                            subKeys = MyReg.GetSubKeyNames();

                                            tempPath += "\\" + subKeys[0];

                                            MyReg = Registry.ClassesRoot.OpenSubKey(tempPath);

                                            subKeys = MyReg.GetSubKeyNames();

                                            tempPath += "\\" + subKeys[1];

                                            MyReg = Registry.ClassesRoot.OpenSubKey(tempPath);

                                            string filePath = MyReg.GetValue("").ToString();


                                            if (!string.IsNullOrEmpty(filePath))
                                            {
                                                bool isFileExists = false;
                                                bool isDirectoryExists = false;
                                                try
                                                {
                                                    if (Path.HasExtension(filePath))
                                                    {
                                                        FileInfo file = new FileInfo(filePath);
                                                        if (file.Exists)
                                                        {
                                                            isFileExists = true;
                                                        }
                                                    }
                                                }
                                                catch (Exception ex)
                                                {
                                                    ;
                                                }

                                                try
                                                {
                                                    if (!Path.HasExtension(filePath))
                                                    {
                                                        DirectoryInfo dirInfo = new DirectoryInfo(filePath);
                                                        if (dirInfo.Exists)
                                                        {
                                                            isDirectoryExists = true;
                                                        }
                                                    }
                                                }
                                                catch (Exception ex)
                                                {
                                                    ;
                                                }

                                                if (!isFileExists && isDirectoryExists)
                                                {
                                                    result.Add(new ResultDetail() { FilePath = tempPath, FileSize = 0, SearchArea = SearchArea.Registry, FeatureArea = FeatureArea.TypeLibraries, RegistryKey = filePath });
                                                }
                                            }
                                        }
                                        catch (Exception ex)
                                        {
                                            ;
                                        }
                                    }
                                    );
                                }
                                break;
                            case RegistryOptions.Fonts:
                                {
                                    RegistryKey key1 = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows NT\CurrentVersion\Fonts");
                                    string[] fontsAvailable = Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "*.*");
                                    var keys1 = key1.GetValueNames();
                                    Parallel.ForEach(keys1, v =>
                                    {
                                        try
                                        {

                                            string fontfile = key1.GetValue(v).ToString();

                                            if (fontsAvailable.Where(t => Path.GetFileName(t.ToLower()) == fontfile.ToLower()).Count() < 1)
                                            {
                                                if (!new FileInfo(fontfile).Exists)
                                                    result.Add(new ResultDetail() { FilePath = v, FileSize = 0, SearchArea = SearchArea.Registry, FeatureArea = FeatureArea.Fonts, RegistryKey = @"HKLM\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Fonts" });
                                            }
                                        }
                                        catch (Exception ex)
                                        {
                                            ;
                                        }
                                    });
                                }
                                break;
                            case RegistryOptions.ApplicationPaths:
                                {
                                    RegistryKey key1 = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows NT\CurrentVersion\AppCompatFlags\Compatibility Assistant\Store");
                                    var keys1 = key1.GetValueNames();
                                    Parallel.ForEach(keys1, v =>
                                    {
                                        try
                                        {
                                            if (!v.StartsWith("\\"))
                                            {
                                                FileInfo file = new FileInfo(v);
                                                if (!file.Exists)
                                                {
                                                    result.Add(new ResultDetail() { FilePath = v, FileSize = 0, SearchArea = SearchArea.Registry, FeatureArea = FeatureArea.ApplicationPaths, RegistryKey = @"HKCU\Software\Microsoft\Windows NT\CurrentVersion\AppCompatFlags\Compatibility Assistant\Store" });
                                                }
                                            }
                                        }
                                        catch (Exception ex)
                                        {
                                            ;
                                        }
                                    }
                                    );
                                }
                                break;
                           
                            case RegistryOptions.Installer:
                                {
                                    RegistryKey key1 = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\Folders");
                                    var keys1 = key1.GetValueNames();
                                    Parallel.ForEach(keys1, v =>
                                    {
                                        try
                                        {
                                            if (!v.StartsWith("\\"))
                                            {
                                                DirectoryInfo file = new DirectoryInfo(v);
                                                if (!file.Exists)
                                                {
                                                    result.Add(new ResultDetail() { FilePath = v, FileSize = 0, SearchArea = SearchArea.Registry, FeatureArea = FeatureArea.Installer, RegistryKey = @"HKLM\SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\Folders" });
                                                }
                                            }
                                        }
                                        catch (Exception ex)
                                        {
                                            ;
                                        }
                                    }
                                    );
                                }
                                break;
                            case RegistryOptions.SoundEvents:
                                {
                                    RegistryKey key1 = Registry.CurrentUser.OpenSubKey(@"AppEvents\Schemes\Apps\.Default");
                                    var keys1 = key1.GetSubKeyNames();
                                    Parallel.ForEach(keys1, v =>
                                    {
                                        try
                                        {
                                            RegistryKey regkey;
                                            regkey = Registry.CurrentUser.OpenSubKey(string.Format(@"AppEvents\Schemes\Apps\.Default\{0}", v));

                                            string[] subKeys = regkey.GetSubKeyNames();

                                            string filePath = regkey.OpenSubKey(".Current").GetValue("").ToString();

                                            if (!string.IsNullOrEmpty(filePath))
                                            {
                                                FileInfo file = new FileInfo(filePath);
                                                if (!file.Exists)
                                                {
                                                    result.Add(new ResultDetail() { FilePath = filePath, FileSize = 0, SearchArea = SearchArea.Registry, FeatureArea = FeatureArea.SoundEvents, RegistryKey = @"HKCU\AppEvents\Schemes\Apps\.Default" });
                                                }
                                            }
                                        }
                                        catch (Exception ex)
                                        {
                                            ;
                                        }
                                    }
                                    );
                                }
                                break;

                            case RegistryOptions.WindowsServices:
                                {
                                    RegistryKey key1 = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\services");
                                    var keys1 = key1.GetSubKeyNames();
                                    Parallel.ForEach(keys1, v =>
                                    {
                                        try
                                        {
                                            RegistryKey regkey;
                                            regkey = Registry.LocalMachine.OpenSubKey(string.Format(@"SYSTEM\CurrentControlSet\services\{0}", v));

                                            string[] subKeys = regkey.GetSubKeyNames();

                                            if (subKeys.Contains("ImagePath") && regkey != null && regkey.GetValue("ImagePath") == null)
                                            {
                                                DirectoryInfo file = new DirectoryInfo(v);
                                                if (!file.Exists)
                                                {
                                                    result.Add(new ResultDetail() { FilePath = v, FileSize = 0, SearchArea = SearchArea.Registry, FeatureArea = FeatureArea.Installer, RegistryKey = @"HKLM\SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\Folders" });
                                                }
                                            }
                                        }
                                        catch (Exception ex)
                                        {
                                            ;
                                        }
                                    }
                                    );
                                }
                                break;


                        }
                        break;
                        #endregion
                }

                if (!isCleanerCall)
                {
                    if (areasCompleted < totalAreasToSearch)
                    {
                        areasCompleted += 1;
                    }
                    backgroundWorker.ReportProgress(Helper.CompletionPercentage(areasCompleted, totalAreasToSearch));
                }
            }



            return result;
        }

        public static long GetOverallSize(string[] files)
        {
            long size = 0;
            Parallel.ForEach(files, file =>
            {
                size += new FileInfo(file).Length;
            });
            return size;
        }

        public static ResultSummary GetOverallResult(List<ResultDetail> selectedFilters)
        {
            ResultSummary summary = new ResultSummary();
            List<Result> result = new List<Result>();

            var results = from line in selectedFilters
                          group line by new { line.SearchArea, line.FeatureArea } into g
                          select new Result
                          {
                              SearchArea = g.First().SearchArea,
                              FeatureName = g.First().FeatureArea.ToString(),
                              FilesSize = Helper.ToKb(g.Sum(_ => _.FileSize)).ToString() + " KB",
                              TotalFiles = g.Count().ToString() + " files",
                              Icon = Helper.GetSearchAreaIcon(g.First().SearchArea)
                          };

            summary.DetailResult = selectedFilters;
            summary.OverallResult = results.ToList();

            return summary;
        }

        public static List<ResultDetail> GetRegistryResult(List<ListItem> searchCriteria, ref BackgroundWorker backgroundWorker)
        {
            List<ResultDetail> searchResult = new List<ResultDetail>();

            foreach (ListItem critiera in searchCriteria)
            {
                RegistryOptions option = (RegistryOptions)critiera.ItemId;
                switch (option)
                {
                    case RegistryOptions.MissingSharedDlls:
                        break;
                    case RegistryOptions.UnUsedFileExtensions:
                        break;
                    case RegistryOptions.ActivexAndClassIssues:
                        break;
                    case RegistryOptions.TypeLibraries:
                        break;
                    case RegistryOptions.Applications:
                        break;
                    case RegistryOptions.Fonts:
                        break;
                    case RegistryOptions.ApplicationPaths:
                        break;
                    case RegistryOptions.HelpFiles:
                        break;
                    case RegistryOptions.Installer:
                        break;
                    case RegistryOptions.ObsoleteSoftware:
                        break;
                    case RegistryOptions.RunAtStartup:
                        break;
                    case RegistryOptions.StartMenuOrdering:
                        break;
                    case RegistryOptions.MUICache:
                        break;
                    case RegistryOptions.SoundEvents:
                        break;
                    case RegistryOptions.WindowsServices:
                        break;
                }
            }
            return searchResult;
        }
    }
}
