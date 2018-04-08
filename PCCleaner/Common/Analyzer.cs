using Microsoft.Data.Sqlite;
using PCCleaner.Properties;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace PCCleaner.Common
{
    public static class Analyzer
    {
        public static List<ResultDetail> GetSearchResults(List<SearchCriteria> searchCriteria, ref BackgroundWorker backgroundWorker)
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
                                files = Directory.GetFiles(parentPath, "*.*", SearchOption.AllDirectories).ToList().Where(p => p.ToLower().Contains(@"cache")).ToArray();
                                foreach (string fl in files)
                                {
                                    result.Add(new ResultDetail() { FilePath = fl, FileSize = new FileInfo(fl).Length, SearchArea = SearchArea.Edge, FeatureArea = FeatureArea.Cache });
                                }
                                areasCompleted += 1;
                                backgroundWorker.ReportProgress((areasCompleted / totalAreasToSearch) * 100);
                                break;
                            case BrowserFeatures.InternetHistory:

                                parentPath = Helper.GetBrowserInternetHistoryPath(SearchArea.Edge);
                                files = Directory.GetFiles(parentPath, "*.*", SearchOption.AllDirectories).ToList().Where(p => p.ToLower().Contains("history")).ToArray();
                                foreach (string fl in files)
                                {
                                    result.Add(new ResultDetail() { FilePath = fl, FileSize = new FileInfo(fl).Length, SearchArea = SearchArea.Edge, FeatureArea = FeatureArea.InternetHistory });
                                }
                                areasCompleted += 1;
                                backgroundWorker.ReportProgress((areasCompleted / totalAreasToSearch) * 100);
                                break;
                            case BrowserFeatures.Cookies:
                                parentPath = Helper.GetBrowserInternetHistoryPath(SearchArea.Edge);
                                files = Directory.GetFiles(parentPath, "*.*", SearchOption.AllDirectories).ToList().Where(p => p.ToLower().Contains(".xml")).ToArray();
                                foreach (string fl in files)
                                {
                                    result.Add(new ResultDetail() { FilePath = fl, FileSize = new FileInfo(fl).Length, SearchArea = SearchArea.Edge, FeatureArea = FeatureArea.Cookies });
                                }
                                areasCompleted += 1;
                                backgroundWorker.ReportProgress((areasCompleted / totalAreasToSearch) * 100);
                                break;
                            case BrowserFeatures.DownloadHistory:
                                parentPath = Helper.GetBrowserInternetHistoryPath(SearchArea.Edge);
                                files = Directory.GetFiles(parentPath, "*.*", SearchOption.AllDirectories).ToList().Where(p => p.ToLower().Contains("downloadhistory")).ToArray();
                                foreach (string fl in files)
                                {
                                    result.Add(new ResultDetail() { FilePath = fl, FileSize = new FileInfo(fl).Length, SearchArea = SearchArea.Edge, FeatureArea = FeatureArea.DownloadHistory });
                                }
                                areasCompleted += 1;
                                backgroundWorker.ReportProgress((areasCompleted / totalAreasToSearch) * 100);
                                break;
                            case BrowserFeatures.LastDownloadLocation:
                                parentPath = KnownFolders.GetPath(KnownFolder.Downloads);
                                files = Directory.GetFiles(parentPath, "*.*", SearchOption.AllDirectories).ToList().ToArray();
                                foreach (string fl in files)
                                {
                                    result.Add(new ResultDetail() { FilePath = fl, FileSize = new FileInfo(fl).Length, SearchArea = SearchArea.Edge, FeatureArea = FeatureArea.LastDownloadLocation });
                                }
                                areasCompleted += 1;
                                backgroundWorker.ReportProgress((areasCompleted / totalAreasToSearch) * 100);
                                break;
                            case BrowserFeatures.Session:
                                parentPath = Helper.GetBrowserInternetHistoryPath(SearchArea.Edge);
                                files = Directory.GetFiles(parentPath, "*.*", SearchOption.AllDirectories).ToList().Where(p => p.ToLower().Contains("active")).ToArray();
                                foreach (string fl in files)
                                {
                                    result.Add(new ResultDetail() { FilePath = fl, FileSize = new FileInfo(fl).Length, SearchArea = SearchArea.Edge, FeatureArea = FeatureArea.Session });
                                }
                                areasCompleted += 1;
                                backgroundWorker.ReportProgress((areasCompleted / totalAreasToSearch) * 100);
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
                                files = Directory.GetFiles(parentPath, "*.*", SearchOption.AllDirectories).ToList().ToArray();
                                foreach (string fl in files)
                                {
                                    result.Add(new ResultDetail() { FilePath = fl, FileSize = new FileInfo(fl).Length, SearchArea = SearchArea.Chrome, FeatureArea = FeatureArea.Cache });
                                }
                                areasCompleted += 1;
                                backgroundWorker.ReportProgress((areasCompleted / totalAreasToSearch) * 100);
                                break;
                            case BrowserFeatures.InternetHistory:

                                parentPath = Helper.GetBrowserInternetHistoryPath(SearchArea.Chrome);
                                files = Directory.GetFiles(parentPath, "*.*", SearchOption.AllDirectories).ToList().Where(p => p.ToLower().Contains("recovery")).ToArray();
                                foreach (string fl in files)
                                {
                                    result.Add(new ResultDetail() { FilePath = fl, FileSize = new FileInfo(fl).Length, SearchArea = SearchArea.Chrome, FeatureArea = FeatureArea.InternetHistory });
                                }
                                areasCompleted += 1;
                                backgroundWorker.ReportProgress((areasCompleted / totalAreasToSearch) * 100);
                                break;
                            case BrowserFeatures.Cookies:
                                parentPath = Helper.GetBrowserInternetHistoryPath(SearchArea.Chrome);
                                files = Directory.GetFiles(parentPath, "*.*", SearchOption.AllDirectories).ToList().Where(p => p.ToLower().Contains(".xml")).ToArray();
                                foreach (string fl in files)
                                {
                                    result.Add(new ResultDetail() { FilePath = fl, FileSize = new FileInfo(fl).Length, SearchArea = SearchArea.Chrome, FeatureArea = FeatureArea.Cookies });
                                }
                                areasCompleted += 1;
                                backgroundWorker.ReportProgress((areasCompleted / totalAreasToSearch) * 100);
                                break;
                            case BrowserFeatures.DownloadHistory:
                                parentPath = Helper.GetBrowserInternetHistoryPath(SearchArea.Chrome);
                                files = Directory.GetFiles(parentPath, "*.*", SearchOption.AllDirectories).ToList().Where(p => p.ToLower().Contains("downloadhistory")).ToArray();
                                foreach (string fl in files)
                                {
                                    result.Add(new ResultDetail() { FilePath = fl, FileSize = new FileInfo(fl).Length, SearchArea = SearchArea.Chrome, FeatureArea = FeatureArea.DownloadHistory });
                                }
                                areasCompleted += 1;
                                backgroundWorker.ReportProgress((areasCompleted / totalAreasToSearch) * 100);
                                break;
                            case BrowserFeatures.LastDownloadLocation:
                                parentPath = KnownFolders.GetPath(KnownFolder.Downloads);
                                files = Directory.GetFiles(parentPath, "*.*", SearchOption.AllDirectories).ToList().ToArray();
                                foreach (string fl in files)
                                {
                                    result.Add(new ResultDetail() { FilePath = fl, FileSize = new FileInfo(fl).Length, SearchArea = SearchArea.Chrome, FeatureArea = FeatureArea.LastDownloadLocation });
                                }
                                areasCompleted += 1;
                                backgroundWorker.ReportProgress((areasCompleted / totalAreasToSearch) * 100);
                                break;
                            case BrowserFeatures.Session:
                                parentPath = Helper.GetBrowserInternetHistoryPath(SearchArea.Chrome);
                                files = Directory.GetFiles(parentPath, "*.*", SearchOption.AllDirectories).ToList().Where(p => p.ToLower().Contains("active")).ToArray();
                                foreach (string fl in files)
                                {
                                    result.Add(new ResultDetail() { FilePath = fl, FileSize = new FileInfo(fl).Length, SearchArea = SearchArea.Chrome, FeatureArea = FeatureArea.Session });
                                }
                                areasCompleted += 1;
                                backgroundWorker.ReportProgress((areasCompleted / totalAreasToSearch) * 100);
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
                                files = Directory.GetFiles(parentPath, "*.*", SearchOption.AllDirectories).ToList().ToArray();
                                foreach (string fl in files)
                                {
                                    result.Add(new ResultDetail() { FilePath = fl, FileSize = new FileInfo(fl).Length, SearchArea = SearchArea.Chrome, FeatureArea = FeatureArea.Cache });
                                }
                                areasCompleted += 1;
                                backgroundWorker.ReportProgress((areasCompleted / totalAreasToSearch) * 100);
                                break;
                            case BrowserFeatures.InternetHistory:
                                parentPath = Helper.GetBrowserInternetHistoryPath(SearchArea.Chrome);
                                parentPath += "\\user data\\default\\history";

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
                                                //if (result.Where(t => t.FilePath == reader.GetString(1)).ToList().Count < 1)
                                                {
                                                    result.Add(new ResultDetail() { FilePath = reader.GetString(1), FileSize = 1, SearchArea = SearchArea.Chrome, FeatureArea = FeatureArea.Cookies });
                                                }
                                            }
                                        }
                                        conn.Close();
                                    }
                                }
                                areasCompleted += 1;
                                backgroundWorker.ReportProgress((areasCompleted / totalAreasToSearch) * 100);
                                break;
                            case BrowserFeatures.Cookies:
                              
                                parentPath = Helper.GetBrowserInternetHistoryPath(SearchArea.Chrome);
                                parentPath += "\\user data\\default\\cookies";


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
                               
                                areasCompleted += 1;
                                backgroundWorker.ReportProgress((areasCompleted / totalAreasToSearch) * 100);
                                break;
                            case BrowserFeatures.DownloadHistory:
                                parentPath = Helper.GetBrowserInternetHistoryPath(SearchArea.Chrome);
                                parentPath += "\\user data\\default\\DownloadMetadata";

                                result.Add(new ResultDetail() { FilePath = parentPath, FileSize = new FileInfo(parentPath).Length, SearchArea = SearchArea.Chrome, FeatureArea = FeatureArea.DownloadHistory });

                                areasCompleted += 1;
                                backgroundWorker.ReportProgress((areasCompleted / totalAreasToSearch) * 100);
                                break;
                            case BrowserFeatures.LastDownloadLocation:
                                parentPath = KnownFolders.GetPath(KnownFolder.Downloads);
                                files = Directory.GetFiles(parentPath, "*.*", SearchOption.AllDirectories).ToList().ToArray();
                                foreach (string fl in files)
                                {
                                    result.Add(new ResultDetail() { FilePath = fl, FileSize = new FileInfo(fl).Length, SearchArea = SearchArea.Chrome, FeatureArea = FeatureArea.LastDownloadLocation });
                                }
                                areasCompleted += 1;
                                backgroundWorker.ReportProgress((areasCompleted / totalAreasToSearch) * 100);
                                break;
                            case BrowserFeatures.Session:
                                parentPath = Helper.GetBrowserInternetHistoryPath(SearchArea.Chrome);
                                parentPath += "\\user data\\default\\Session Storage";

                                files = Directory.GetFiles(parentPath, "*.*", SearchOption.AllDirectories).ToList().ToArray();
                                foreach (string fl in files)
                                {
                                    result.Add(new ResultDetail() { FilePath = fl, FileSize = new FileInfo(fl).Length, SearchArea = SearchArea.Chrome, FeatureArea = FeatureArea.Cache });
                                }
                                files = Directory.GetFiles(parentPath, "*.*", SearchOption.AllDirectories).ToList().ToArray();
                                foreach (string fl in files)
                                {
                                    result.Add(new ResultDetail() { FilePath = fl, FileSize = new FileInfo(fl).Length, SearchArea = SearchArea.Chrome, FeatureArea = FeatureArea.Cache });
                                }


                                parentPath = Helper.GetBrowserInternetHistoryPath(SearchArea.Chrome);
                                parentPath += "\\user data\\default\\Extension State";

                                files = Directory.GetFiles(parentPath, "*.*", SearchOption.AllDirectories).ToList().ToArray();
                                foreach (string fl in files)
                                {
                                    result.Add(new ResultDetail() { FilePath = fl, FileSize = new FileInfo(fl).Length, SearchArea = SearchArea.Chrome, FeatureArea = FeatureArea.Cache });
                                }
                                files = Directory.GetFiles(parentPath, "*.*", SearchOption.AllDirectories).ToList().ToArray();
                                foreach (string fl in files)
                                {
                                    result.Add(new ResultDetail() { FilePath = fl, FileSize = new FileInfo(fl).Length, SearchArea = SearchArea.Chrome, FeatureArea = FeatureArea.Cache });
                                }

                                areasCompleted += 1;
                                backgroundWorker.ReportProgress((areasCompleted / totalAreasToSearch) * 100);
                                break;

                            case BrowserFeatures.SavedPassword:
                                parentPath = Helper.GetBrowserInternetHistoryPath(SearchArea.Chrome);
                                parentPath += "\\user data\\default\\Login Data";

                                result.Add(new ResultDetail() { FilePath = parentPath, FileSize = new FileInfo(parentPath).Length, SearchArea = SearchArea.Chrome, FeatureArea = FeatureArea.SavedPassword });

                                areasCompleted += 1;
                                backgroundWorker.ReportProgress((areasCompleted / totalAreasToSearch) * 100);
                                break;

                        }
                        break;
                        #endregion
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
                              Icon = Resources.Edge
                          };

            summary.DetailResult = selectedFilters;
            summary.OverallResult = results.ToList();

            return summary;
        }
    }
}
