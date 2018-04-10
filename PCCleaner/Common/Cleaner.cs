using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCCleaner.Common
{
    public class Cleaner
    {
        public static void CleanUpSystem(List<SearchCriteria> searchCriteria, List<ResultDetail> files, ref BackgroundWorker backgroundWorker)
        {
            int totalAreasToSearch = searchCriteria.Count;
            int areasCompleted = 0;

            Parallel.ForEach(searchCriteria, criteria =>
            {
                try
                {
                    
                }
                catch (Exception ex)
                {
                    ;
                }
                if (areasCompleted < totalAreasToSearch)
                {
                    areasCompleted += 1;
                }
                //backgroundWorker.ReportProgress(Helper.CompletionPercentage(areasCompleted, totalAreasToSearch));
            });


            Parallel.ForEach(files, file =>
            {
                try
                {
                    File.SetAttributes(file.FilePath, FileAttributes.Normal);
                    File.Delete(file.FilePath);
                }
                catch (Exception ex)
                {
                    ;
                }
            });
        }
    }
}