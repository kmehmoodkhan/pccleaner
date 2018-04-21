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

                                        //DirectoryInfo dirInfo = new DirectoryInfo(drive);
                                        //FileInfo[] oldFiles =
                                        //        dirInfo.EnumerateFiles("*.*", SearchOption.AllDirectories)
                                        //               .AsParallel()
                                        //               .Where(fi => fi.Extension.ToLower() == ".jpg").ToArray();


                                        var result = EnumerateFiles(drive, "*.jpeg", SearchOption.AllDirectories);


                                        //var result = EnumerateFiles(drive, "*.jpeg", SearchOption.AllDirectories);

                                        foreach (var file in result.ToList())
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

                                        //var result = Directory.EnumerateFiles(drive, "*.jpeg", SearchOption.AllDirectories);

                                        //var list= SearchAccessibleFiles(drive, pictureExtensions, FileTypes.Pictures.ToString());                                        


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



        public IEnumerable<string> EnumerateDirectories(string parentDirectory, string searchPattern, SearchOption searchOpt)
        {
            try
            {
                var directories = Enumerable.Empty<string>();
                if (searchOpt == SearchOption.AllDirectories)
                {
                    directories = Directory.EnumerateDirectories(parentDirectory)
                        .SelectMany(x => EnumerateDirectories(x, searchPattern, searchOpt)).AsParallel();
                }
                return directories.Concat(Directory.EnumerateDirectories(parentDirectory, searchPattern));
            }
            catch (UnauthorizedAccessException ex)
            {
                return Enumerable.Empty<string>();
            }
        }

        public IEnumerable<string> EnumerateFiles(string path, string searchPattern, SearchOption searchOpt)
        {
            try
            {
                var dirFiles = Enumerable.Empty<string>();
                if (searchOpt == SearchOption.AllDirectories)
                {
                    dirFiles = Directory.EnumerateDirectories(path)
                                        .SelectMany(x => EnumerateFiles(x, searchPattern, searchOpt)).AsParallel();
                }
                return dirFiles.Concat(Directory.EnumerateFiles(path, searchPattern).AsParallel());
            }
            catch (UnauthorizedAccessException ex)
            {
                return Enumerable.Empty<string>();
            }
        }


    }
}
