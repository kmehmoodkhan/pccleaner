using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCCleaner.Common
{
    public class Cleaner
    {
        public static void CleanUpSystem(List<SearchCriteria> searchCriteria, List<ResultDetail> files, ref BackgroundWorker backgroundWorker)
        {
            int totalAreasToSearch = files.Count;
            int areasCompleted = 0;


            if (searchCriteria.Any(t=>t.SearchArea == (int) SearchArea.System && t.FeatureId == (int)SystemFeatures.EmptyRecycleBin))
            {
                Task.Run(() => Helper.EmptyRecycleBin());                
            }
            

            /*
            Parallel.ForEach(files, file =>
            {
                try
                {

                    if (areasCompleted < totalAreasToSearch)
                    {
                        areasCompleted += 1;
                    }
                    DeleteFile(file);
                    var progress=Helper.CompletionPercentage(areasCompleted, totalAreasToSearch);
                }
                catch (Exception ex)
                {
                    ;
                }
            });
            */

            foreach( var file in files)
            {
                if (areasCompleted < totalAreasToSearch)
                {
                    areasCompleted += 1;
                }
                try
                {
                    DeleteFile(file);
                }
                catch(Exception ex)
                {
                    ;
                }
                var progress = Helper.CompletionPercentage(areasCompleted, totalAreasToSearch);
                backgroundWorker.ReportProgress(progress);
            }

            
        }

        private static void DeleteFile(ResultDetail file)
        {
            File.SetAttributes(file.FilePath, FileAttributes.Normal);
            File.Delete(file.FilePath);  
            
        }

        private static void UpdateProgress(ref BackgroundWorker backgroundWorker,int progress)
        {
            backgroundWorker.ReportProgress(progress);
        }
    }
}