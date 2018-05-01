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
        public static void CleanUpSystem(List<SearchCriteria> searchCriteria, List<ResultDetail> files,ApplicationItem item, ref BackgroundWorker backgroundWorker)
        {
            if (item == ApplicationItem.Cleaner && searchCriteria.Any(t => t.SearchArea == (int)SearchArea.System && t.FeatureId == (int)SystemFeatures.EmptyRecycleBin))
            {
                Task.Run(() => Helper.EmptyRecycleBin());
            }

            if (files.Count > 0 && item == ApplicationItem.Cleaner)
            {
                int totalAreasToSearch = files.Count;
                int areasCompleted = 0;
               

                foreach (var file in files)
                {
                    if (areasCompleted < totalAreasToSearch)
                    {
                        areasCompleted += 1;
                    }
                    try
                    {
                        DeleteFile(file);
                    }
                    catch (Exception ex)
                    {
                        ;
                    }
                    var progress = Helper.CompletionPercentage(areasCompleted, totalAreasToSearch);
                    backgroundWorker.ReportProgress(progress);
                }
            }
            else if( item == ApplicationItem.Registry)
            {
                int totalAreasToSearch = files.Count;
                int areasCompleted = 0;

                foreach (var file in files)
                {
                    if (areasCompleted < totalAreasToSearch)
                    {
                        areasCompleted += 1;
                    }
                    try
                    {
                        if( file.RegistryKey.StartsWith(@"HKLM\"))
                        {
                            var path = file.RegistryKey.Replace("HKLM\\","");
                            var registryKey = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(path,true);
                            registryKey.DeleteValue(file.FilePath);
                            registryKey.Close();
                        }
                    }
                    catch (Exception ex)
                    {
                        ;
                    }
                    var progress = Helper.CompletionPercentage(areasCompleted, totalAreasToSearch);
                    backgroundWorker.ReportProgress(progress);
                }
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