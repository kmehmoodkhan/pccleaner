using PCCleaner.Controls.Common;
using PCCleaner.Properties;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace PCCleaner.Common
{
    public static class Analyzer
    {
        public static List<ResultDetail> GetSearchResults(SearchArea area, List<ListItem> selectedFilters)
        {
            List<ResultDetail> result = new List<ResultDetail>();
            string[] files = null;
            string parentPath = string.Empty;

            switch (area)
            {
                case SearchArea.Edge:
                    foreach (var item in selectedFilters)
                    {
                        BrowserFeatures feature = (BrowserFeatures)item.ItemId;
                        if (feature == BrowserFeatures.Cache)
                        {
                            parentPath = Helper.GetBrowserCachePath(SearchArea.Edge);
                            files = Directory.GetFiles(parentPath, "*", SearchOption.AllDirectories);
                            foreach (string fl in files)
                            {
                                result.Add(new ResultDetail() { FilePath = fl, FileSize = File.ReadAllBytes(fl).LongLength, SearchArea = SearchArea.Edge, Feature = FeatureArea.Cache });
                            }
                        }
                    }
                    break;
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
