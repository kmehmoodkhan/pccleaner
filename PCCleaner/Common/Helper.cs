using PCCleaner.Controls.Common;
using PCCleaner.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Management;
using System.IO;
using System.Windows.Forms;

namespace PCCleaner.Common
{
    public static class Helper
    {
        public static Bitmap ResizeImage(Image image, int width, int height)
        {
            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return destImage;
        }

        public static List<ListItem> GetExplorerFeatures()
        {
            List<ListItem> list = new List<ListItem>();

            foreach (ExplorerFeatures feature in Enum.GetValues(typeof(ExplorerFeatures)))
            {
                ListItem item = new ListItem() { ItemId = Convert.ToInt32(feature), ItemText = Resources.ResourceManager.GetString("ExplorerFeature_" + Convert.ToInt32(feature)) };
                list.Add(item);
            }
            return list;
        }

        public static List<ListItem> GetSystemFeatures()
        {
            List<ListItem> list = new List<ListItem>();

            foreach (SystemFeatures feature in Enum.GetValues(typeof(SystemFeatures)))
            {
                ListItem item = new ListItem() { ItemId = Convert.ToInt32(feature), ItemText = Resources.ResourceManager.GetString("SystemFeature_" + Convert.ToInt32(feature)) };
                list.Add(item);
            }
            return list;
        }

        public static List<ListItem> GetAdvancedFeatures()
        {
            List<ListItem> list = new List<ListItem>();

            foreach (AdvancedFeatures feature in Enum.GetValues(typeof(AdvancedFeatures)))
            {
                ListItem item = new ListItem() { ItemId = Convert.ToInt32(feature), ItemText = Resources.ResourceManager.GetString("AdvancedFeature_" + Convert.ToInt32(feature)) };
                list.Add(item);
            }
            return list;
        }

        public static List<ListItem> GetWindowsApplications()
        {
            List<ListItem> list = new List<ListItem>();
            

            ManagementObjectSearcher mos = new ManagementObjectSearcher("SELECT * FROM Win32_Product");
            foreach (ManagementObject mo in mos.Get())
            {
                ListItem item = new ListItem() { ItemId = -1, ItemText = mo["Name"].ToString() };
                list.Add(item);
            }
            return list;
        }


        public static string GetBrowserCachePath(SearchArea browser)
        {
            var path = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            switch (browser)
            {
                case SearchArea.Edge:
                    path += "\\Packages\\";
                    var directories = System.IO.Directory.GetDirectories(path);
                    foreach (string dir in directories)
                    {
                        if (dir.Contains("Microsoft.MicrosoftEdge_"))
                        {
                            path = dir+"\\AC";
                            break;
                        }
                    }
                    break;
                case SearchArea.IE:
                    path += "\\Microsoft\\";
                    directories = System.IO.Directory.GetDirectories(path);
                    foreach (string dir in directories)
                    {
                        if (dir.EndsWith(@"Internet Explorer"))
                        {
                            path = dir;
                            break;
                        }
                    }
                    break;
                case SearchArea.Chrome:
                    path += "\\Google\\";
                    directories = System.IO.Directory.GetDirectories(path);
                    foreach (string dir in directories)
                    {
                        if (dir.EndsWith(@"Chrome"))
                        {
                            path = dir;
                            break;
                        }
                    }
                    break;
                case SearchArea.Firefox:
                    path += "\\Mozilla\\";
                    directories = System.IO.Directory.GetDirectories(path);
                    foreach (string dir in directories)
                    {
                        if (dir.EndsWith(@"Firefox"))
                        {
                            path = dir;
                            break;
                        }
                    }
                    break;
            }

            
            return path;
        }

        public static string GetBrowserInternetHistoryPath(SearchArea browser)
        {
            var path = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            switch (browser)
            {
                case SearchArea.Edge:
                    path += "\\Packages\\";
                    var directories = System.IO.Directory.GetDirectories(path);
                    foreach (string dir in directories)
                    {
                        if (dir.Contains("Microsoft.MicrosoftEdge_"))
                        {
                            path = dir + "\\AC";
                            break;
                        }
                    }
                    break;
                case SearchArea.IE:
                    path += "\\Microsoft\\";
                    directories = System.IO.Directory.GetDirectories(path);
                    foreach (string dir in directories)
                    {
                        if (dir.EndsWith(@"Internet Explorer"))
                        {
                            path = dir;
                            break;
                        }
                    }
                    break;
                case SearchArea.Chrome:
                    path += "\\Google\\";
                    directories = System.IO.Directory.GetDirectories(path);
                    foreach (string dir in directories)
                    {
                        if (dir.EndsWith(@"Chrome"))
                        {
                            path = dir;
                            break;
                        }
                    }
                    break;
                case SearchArea.Firefox:
                    path += "\\Mozilla\\";
                    directories = System.IO.Directory.GetDirectories(path);
                    foreach (string dir in directories)
                    {
                        if (dir.EndsWith(@"Firefox"))
                        {
                            path = dir;
                            break;
                        }
                    }
                    break;
            }


            return path;
        }

        public static void BindResult(ref ListView listview, List<Result> result)
        {
            int i = 0;
           // var imageList1 = new ImageList();
            foreach (Result file in result)
            {
                ImageList imageList = new ImageList();
                imageList.Images.Add(Resources.Edge);
                string[] row = new string[] {file.SearchArea.ToString(), file.FilesSize.ToString()+" KB", file.TotalFiles.ToString()+" files" };
                var listViewItem = new ListViewItem(row);
                listview.Items.Add(listViewItem);
               
                listview.SmallImageList = imageList;
                listview.Items[i].ImageIndex = 0;
                i++;
            }
        }
        public static void BindListView(ref ListView listview,string[] files)
        {
           //  = new string[files.Count]; //{ "Microsoft Internet Explorer", "50kb", "30 files found" };
            foreach( string file in files)
            {
                string[] row = new string[] { file, "10KB", files.Length.ToString() + " files found" };
                //row = { file,"10Kb",files.Count.ToString()+"files found"};
                var listViewItem = new ListViewItem(row);
                listview.Items.Add(listViewItem);
            }
            
        }

        public static double ToKb(long totalBytes)
        {
            return (totalBytes / 1000);
        }
    }
}
