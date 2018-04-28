using PCCleaner.Common;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PCCleaner.Tools
{
    public class ToolsLibrary
    {
        List<DiskFileInfo> files = new List<DiskFileInfo>();
        public List<DiskFileInfo> SearchFiles(List<int> fileTypes, List<string> drives)
        {


            Parallel.ForEach(drives, drive =>
            {
                try
                {
                    Parallel.ForEach(fileTypes, type =>
                    {
                        try
                        {
                            switch (type)
                            {
                                case (int)FileTypes.Pictures:
                                    {
                                        List<string> pictureExtensions = new List<string>();
                                        pictureExtensions.Add("jpeg");
                                        pictureExtensions.Add("png");
                                        pictureExtensions.Add("gif");
                                        pictureExtensions.Add("png");
                                        pictureExtensions.Add("tiff");

                                        string[] extensions = { "*.jpeg", "*.png", "*.gif", "*.png", "*.tiff" };

                                        List<string> searchResult = new List<string>();
                                        searchResult = DirSearch(drive,extensions);

                                        foreach (var file in searchResult)
                                        {
                                            DiskFileInfo fileDetail = new DiskFileInfo();
                                            fileDetail.FileName = Path.GetFileName(file);
                                            fileDetail.FilePath = file;
                                            fileDetail.FileType = Path.GetExtension(file);
                                            fileDetail.FileSize = new FileInfo(file).Length.ToString();
                                            fileDetail.Category = "Pictures";

                                            if (files.Where(f => f.FileName.ToLower() == fileDetail.FileName.ToLower()).Count() < 1)
                                            {
                                                files.Add(fileDetail);
                                            }
                                        }

                                    }
                                    break;
                                case (int)FileTypes.Music:
                                    break;

                                case (int)FileTypes.Documents:
                                    break;

                                case (int)FileTypes.Video:
                                    break;

                                case (int)FileTypes.Compressed:
                                    break;

                                case (int)FileTypes.Email:
                                    break;

                                case (int)FileTypes.Everything:
                                    break;

                            };

                            if (type == (int)FileTypes.Pictures)
                            {

                            }
                        }
                        catch (Exception ex)
                        {
                            ;
                        }
                    });

                }
                catch (Exception ex)
                {
                    ;
                }
            });
            return files;
        }



        static List<string> result = new List<string>();
        static List<string> DirSearch(string sDir, string[] extensions)
        {

            try
            {
                var dirList = Directory.GetDirectories(sDir);
                Parallel.ForEach(dirList, (d) =>
                {
                    try
                    {
                        var files = Directory.GetFiles(d).ToList();
                        Parallel.ForEach(files, (f) =>
                        {
                            if (extensions.Contains(Path.GetExtension(f).ToLower()))
                                result.Add(f);
                        });
                        DirSearch(d,extensions);
                    }
                    catch (Exception ex)
                    {
                        ;
                    }
                });
            }
            catch (System.Exception excpt)
            {
                Console.WriteLine(excpt.Message);
            }
            return result;
        }


    }
}
