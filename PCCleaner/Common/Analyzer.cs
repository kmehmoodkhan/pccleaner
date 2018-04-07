using PCCleaner.Controls.Common;
using PCCleaner.Properties;
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
        public  static List<ResultDetail> GetSearchResults(List<SearchCriteria> searchCriteria, ref BackgroundWorker backgroundWorker)
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
                    case (int)SearchArea.Edge:
                        BrowserFeatures feature = (BrowserFeatures)item.FeatureId;
                        switch (feature)
                        {
                            case BrowserFeatures.Cache:
                               
                                parentPath = Helper.GetBrowserCachePath(SearchArea.Edge);
                                files = Directory.GetFiles(parentPath, "*.*", SearchOption.AllDirectories).ToList().Where(p => p.ToLower().Contains(@"cache")).ToArray();
                                foreach (string fl in files)
                                {
                                    result.Add(new ResultDetail() { FilePath = fl, FileSize = File.ReadAllBytes(fl).LongLength, SearchArea = SearchArea.Edge, Feature = BrowserFeatures.Cache });
                                }
                                areasCompleted += 1;
                                backgroundWorker.ReportProgress((areasCompleted/totalAreasToSearch)*100);
                                break;
                            case BrowserFeatures.InternetHistory:
                               
                                parentPath = Helper.GetBrowserInternetHistoryPath(SearchArea.Edge);
                                files = Directory.GetFiles(parentPath, "*.*", SearchOption.AllDirectories).ToList().Where(p => p.Contains("history")).ToArray(); ;
                                foreach (string fl in files)
                                {
                                    result.Add(new ResultDetail() { FilePath = fl, FileSize = File.ReadAllBytes(fl).LongLength, SearchArea = SearchArea.Edge, Feature = BrowserFeatures.InternetHistory });
                                }
                                areasCompleted += 1;
                                backgroundWorker.ReportProgress((areasCompleted / totalAreasToSearch) * 100);
                                break;
                            case BrowserFeatures.Cookies:
                                parentPath = Helper.GetBrowserInternetHistoryPath(SearchArea.Edge);
                                files = Directory.GetFiles(parentPath, "*.*", SearchOption.AllDirectories).ToList().Where(p => p.Contains("history")).ToArray(); ;
                                foreach (string fl in files)
                                {
                                    result.Add(new ResultDetail() { FilePath = fl, FileSize = File.ReadAllBytes(fl).LongLength, SearchArea = SearchArea.Edge, Feature = BrowserFeatures.InternetHistory });
                                }
                                areasCompleted += 1;
                                backgroundWorker.ReportProgress((areasCompleted / totalAreasToSearch) * 100);
                                break;
                        }
                        break;
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
                          group line by new { line.SearchArea, line.Feature } into g
                          select new Result
                          {
                              SearchArea = g.First().SearchArea,
                              FilesSize = Helper.ToKb(g.Sum(_ => _.FileSize)),
                              TotalFiles = g.Count(),
                              Icon = Resources.Edge
                          };

            summary.DetailResult = selectedFilters;
            summary.OverallResult = results.ToList();

            return summary;
        }
    }
}
