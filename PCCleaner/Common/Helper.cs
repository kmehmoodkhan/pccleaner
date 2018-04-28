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
using Microsoft.Win32;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Threading;
using System.Net.NetworkInformation;

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

        public static string GetBrowserParentPath(SearchArea browser)
        {
            var path = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            switch (browser)
            {
                case SearchArea.Edge:
                    path += "\\Packages\\";
                    try
                    {
                        var directories = System.IO.Directory.GetDirectories(path);
                        foreach (string dir in directories)
                        {
                            if (dir.Contains("Microsoft.MicrosoftEdge_"))
                            {
                                path = dir + "\\AC";
                                break;
                            }
                        }
                    }
                    catch
                    {
                        ;
                    }
                    break;
                case SearchArea.IE:
                    path += "\\Microsoft\\";
                    try
                    {
                        var directories = System.IO.Directory.GetDirectories(path);
                        foreach (string dir in directories)
                        {
                            if (dir.EndsWith(@"Internet Explorer"))
                            {
                                path = dir;
                                break;
                            }
                        }
                    }
                    catch
                    {
                        ;
                    }
                    break;
                case SearchArea.Chrome:
                    path += "\\Google\\";
                    try
                    {
                        var directories = System.IO.Directory.GetDirectories(path);
                        foreach (string dir in directories)
                        {
                            if (dir.EndsWith(@"Chrome"))
                            {
                                path = dir;
                                break;
                            }
                        }
                    }
                    catch
                    {
                        ;
                    }
                    break;
                case SearchArea.Firefox:
                    path += "\\Mozilla\\";
                    try
                    {
                        var directories = System.IO.Directory.GetDirectories(path);
                        foreach (string dir in directories)
                        {
                            if (dir.EndsWith(@"Firefox"))
                            {
                                path = dir;
                                break;
                            }
                        }
                    }
                    catch
                    {
                        ;
                    }
                    break;
            }


            return path;
        }
        public static string GetBrowserCachePath(SearchArea browser)
        {
            var path = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);


            switch (browser)
            {
                case SearchArea.Edge:
                    path += "\\Packages\\";
                    try
                    {
                        string[] directoriesTemp = System.IO.Directory.GetDirectories(path);
                        foreach (string dir in directoriesTemp)
                        {
                            if (dir.Contains("Microsoft.MicrosoftEdge_"))
                            {
                                path = dir + "\\AC";
                                break;
                            }
                        }

                    }
                    catch
                    {
                        ;
                    }
                    break;
                case SearchArea.IE:
                    path += "\\Microsoft\\";
                    try
                    {
                        var directoriesTemp = System.IO.Directory.GetDirectories(path);
                        foreach (string dir in directoriesTemp)
                        {
                            if (dir.EndsWith(@"Internet Explorer"))
                            {
                                path = dir;
                                break;
                            }
                        }
                    }
                    catch
                    {
                        ;
                    }
                    break;
                case SearchArea.Chrome:
                    path += "\\Google\\";
                    try
                    {
                        var directoriesTemp = System.IO.Directory.GetDirectories(path);
                        foreach (string dir in directoriesTemp)
                        {
                            if (dir.EndsWith(@"Chrome"))
                            {
                                path = dir;
                                break;
                            }
                        }
                    }
                    catch
                    {
                        ;
                    }
                    break;
                case SearchArea.Firefox:
                    path += "\\Mozilla\\";
                    try
                    {
                        var directories = System.IO.Directory.GetDirectories(path);
                        foreach (string dir in directories)
                        {
                            if (dir.EndsWith(@"Firefox"))
                            {
                                path = dir;
                                break;
                            }
                        }
                    }
                    catch
                    {
                        ;
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
                    try
                    {
                        var directories = System.IO.Directory.GetDirectories(path);
                        foreach (string dir in directories)
                        {
                            if (dir.Contains("Microsoft.MicrosoftEdge_"))
                            {
                                path = dir + "\\AC";
                                break;
                            }
                        }
                    }
                    catch
                    {
                        ;
                    }
                    break;
                case SearchArea.IE:
                    path += "\\Microsoft\\";
                    try
                    {
                        var directories = System.IO.Directory.GetDirectories(path);
                        foreach (string dir in directories)
                        {
                            if (dir.EndsWith(@"Internet Explorer"))
                            {
                                path = dir;
                                break;
                            }
                        }
                    }
                    catch
                    {
                        ;
                    }
                    break;
                case SearchArea.Chrome:
                    path += "\\Google\\";
                    try
                    {
                        var directories = System.IO.Directory.GetDirectories(path);
                        foreach (string dir in directories)
                        {
                            if (dir.EndsWith(@"Chrome"))
                            {
                                path = dir;
                                break;
                            }
                        }
                    }
                    catch
                    {
                        ;
                    }
                    break;
                case SearchArea.Firefox:
                    path += "\\Mozilla\\";
                    try
                    {
                        var directories = System.IO.Directory.GetDirectories(path);
                        foreach (string dir in directories)
                        {
                            if (dir.EndsWith(@"Firefox"))
                            {
                                path = dir;
                                break;
                            }
                        }
                    }
                    catch
                    {
                        ;
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
                string[] row = new string[] { file.SearchArea.ToString(), file.FilesSize.ToString() + " KB", file.TotalFiles.ToString() + " files" };
                var listViewItem = new ListViewItem(row);
                listview.Items.Add(listViewItem);

                listview.SmallImageList = imageList;
                listview.Items[i].ImageIndex = 0;
                i++;
            }
        }
        public static void BindListView(ref ListView listview, string[] files)
        {
            //  = new string[files.Count]; //{ "Microsoft Internet Explorer", "50kb", "30 files found" };
            foreach (string file in files)
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

        public static List<ListItem> GetWindowStoreItems()
        {
            List<ListItem> list = new List<ListItem>();

            foreach (WindowStore feature in Enum.GetValues(typeof(WindowStore)))
            {
                ListItem item = new ListItem() { ItemId = Convert.ToInt32(feature), ItemText = Resources.ResourceManager.GetString("WindowStore_" + Convert.ToInt32(feature)) };
                list.Add(item);
            }
            return list;
        }

        public static List<ListItem> GetApplicationsInstalled()
        {
            List<ListItem> list = new List<ListItem>();
            foreach (Applications feature in Enum.GetValues(typeof(Applications)))
            {
                ListItem item = new ListItem() { ItemId = Convert.ToInt32(feature), ItemText = Resources.ResourceManager.GetString("Applications_" + Convert.ToInt32(feature)) };
                list.Add(item);
            }

            return list;
        }

        public static List<ListItem> GetInternetItems()
        {
            List<ListItem> list = new List<ListItem>();
            foreach (Internet feature in Enum.GetValues(typeof(Internet)))
            {
                ListItem item = new ListItem() { ItemId = Convert.ToInt32(feature), ItemText = Resources.ResourceManager.GetString("Internet_" + Convert.ToInt32(feature)) };
                list.Add(item);
            }

            return list;
        }

        public static List<ListItem> GetMultimediaItems()
        {
            List<ListItem> list = new List<ListItem>();
            foreach (Multimedia feature in Enum.GetValues(typeof(Multimedia)))
            {
                ListItem item = new ListItem() { ItemId = Convert.ToInt32(feature), ItemText = Resources.ResourceManager.GetString("Multimedia_" + Convert.ToInt32(feature)) };
                list.Add(item);
            }

            return list;
        }

        public static List<ListItem> GetUtilitiesItems()
        {
            List<ListItem> list = new List<ListItem>();
            foreach (Utilities feature in Enum.GetValues(typeof(Utilities)))
            {
                ListItem item = new ListItem() { ItemId = Convert.ToInt32(feature), ItemText = Resources.ResourceManager.GetString("Utilities_" + Convert.ToInt32(feature)) };
                list.Add(item);
            }

            return list;
        }

        public static List<ListItem> GetWindowsItems()
        {
            List<ListItem> list = new List<ListItem>();
            foreach (Windows feature in Enum.GetValues(typeof(Windows)))
            {
                ListItem item = new ListItem() { ItemId = Convert.ToInt32(feature), ItemText = Resources.ResourceManager.GetString("Windows_" + Convert.ToInt32(feature)) };
                list.Add(item);
            }

            return list;
        }



        public static List<String> FilesFound = new List<string>();
        public static void DirSearch(string sDir, string searchCriteria)
        {
            try
            {
                foreach (string d in Directory.GetDirectories(sDir))
                {
                    foreach (string f in Directory.GetFiles(d, "*.*"))
                    {
                        if (f.ToLower().Contains(searchCriteria))
                        {
                            FilesFound.Add(f);
                        }
                    }
                    DirSearch(d, searchCriteria);
                }
            }
            catch (System.Exception excpt)
            {
                Console.WriteLine(excpt.Message);
            }
        }

        public static int CompletionPercentage(int areasCompleted, int totalAreasToSearch)
        {
            decimal decCompletionPercentage = 0;
            decimal decAreaCompleted = 0;
            decimal decTotalAreasToSearch = 0;

            decAreaCompleted = decimal.Parse(areasCompleted.ToString());
            decTotalAreasToSearch = decimal.Parse(totalAreasToSearch.ToString());
            decCompletionPercentage = (decAreaCompleted / decTotalAreasToSearch) * 100;
            return (int)Math.Round(decCompletionPercentage, 0);
        }

        public static Image GetSearchAreaIcon(SearchArea area)
        {
            Image icon = null;
            switch (area)
            {
                case SearchArea.Edge:
                    icon = Resources.Edge;
                    break;
                case SearchArea.IE:
                    icon = Resources.IE;
                    break;
                case SearchArea.WindowExplorer:
                    icon = Resources.Explorer;
                    break;
                case SearchArea.System:
                    icon = Resources.System;
                    break;
                case SearchArea.Advanced:
                    icon = Resources.Information;
                    break;
                case SearchArea.Firefox:
                    icon = Resources.Firefox;
                    break;
                case SearchArea.Chrome:
                    icon = Resources.Chrome;
                    break;
                case SearchArea.WindowsStore:
                    icon = Resources.WindowsStore;
                    break;
                case SearchArea.Applications:
                    icon = Resources.Applications;
                    break;
                case SearchArea.Utilities:
                    icon = Resources.Utilities;
                    break;
                case SearchArea.Multimedia:
                    icon = Resources.Multimedia;
                    break;
                case SearchArea.Internet:
                    icon = Resources.Internet;
                    break;
                case SearchArea.Windows:
                    icon = Resources.Windows;
                    break;
                case SearchArea.Registry:
                    icon = Resources.Registry;
                    break;
                default:
                    icon = Resources.Information;
                    break;
            }
            return icon;
        }

        [DllImport("shell32.dll")]
        static extern int SHEmptyRecycleBin(IntPtr hWnd,string pszRootPath, uint dwFlags);

        [Flags]
        private enum RecycleFlags : uint
        {
            SHERB_NOCONFIRMATION = 0x1,
            SHERB_NOPROGRESSUI = 0x2,
            SHERB_NOSOUND = 0x4
        }
        public static void EmptyWastebasket(bool show_progress,
            bool play_sound, bool confirm)
        {
            RecycleFlags options = 0;
            if (!show_progress) options =
                options | RecycleFlags.SHERB_NOPROGRESSUI;
            if (!play_sound) options =
             options | RecycleFlags.SHERB_NOSOUND;
            if (!confirm) options =
          options | RecycleFlags.SHERB_NOCONFIRMATION;

            try
            {
                SHEmptyRecycleBin(IntPtr.Zero, null, (uint)options);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error emptying wastebasket.\n" +
                    ex.Message, "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        public static void EmptyRecycleBin()
        {
            RecycleFlags options = 0;
           options = RecycleFlags.SHERB_NOPROGRESSUI;
            options = RecycleFlags.SHERB_NOSOUND;

          options = RecycleFlags.SHERB_NOCONFIRMATION;

            try
            {
                SHEmptyRecycleBin(IntPtr.Zero, null, (uint)options);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error emptying wastebasket.\n" +
                    ex.Message, "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        public static List<ListItem> GetRegistryFeaturesList()
        {
            List<ListItem> list = new List<ListItem>();

            foreach (RegistryOptions feature in Enum.GetValues(typeof(RegistryOptions)))
            {
                ListItem item = new ListItem() { ItemId = Convert.ToInt32(feature), ItemText = Resources.ResourceManager.GetString("RegistryOptions_" + Convert.ToInt32(feature)) };
                list.Add(item);
            }
            return list;
        }

        public static string GetProblem(FeatureArea feature)
        {
            string problem = string.Empty;
            switch (feature)
            {
                case FeatureArea.MissingSharedDlls:
                    problem = "Missing Shared Dll";
                    break;
                case FeatureArea.UnUsedFileExtensions:
                    problem = "Unused File Extensions";
                    break;
                case FeatureArea.ApplicationPaths:
                    problem = "Application Path Issue";
                    break;
            }
            return problem;
        }

        public static bool IsApplictionInstalled(string p_name)
        {
            string displayName;
            RegistryKey key;

            // search in: CurrentUser
            key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall");
            foreach (String keyName in key.GetSubKeyNames())
            {
                RegistryKey subkey = key.OpenSubKey(keyName);
                displayName = subkey.GetValue("DisplayName") as string;
                if (p_name.Equals(displayName, StringComparison.OrdinalIgnoreCase) == true)
                {
                    return true;
                }
            }

            // search in: LocalMachine_32
            key = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall");
            foreach (String keyName in key.GetSubKeyNames())
            {
                RegistryKey subkey = key.OpenSubKey(keyName);
                displayName = subkey.GetValue("DisplayName") as string;
                if (p_name.Equals(displayName, StringComparison.OrdinalIgnoreCase) == true)
                {
                    return true;
                }
            }

            // search in: LocalMachine_64
            key = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Wow6432Node\Microsoft\Windows\CurrentVersion\Uninstall");
            foreach (String keyName in key.GetSubKeyNames())
            {
                RegistryKey subkey = key.OpenSubKey(keyName);
                displayName = subkey.GetValue("DisplayName") as string;
                if (p_name.Equals(displayName, StringComparison.OrdinalIgnoreCase) == true)
                {
                    return true;
                }
            }

            // NOT FOUND
            return false;
        }


        public static List<DriveInfo> GetSystemDrives()
        {
            var dirveInfo = DriveInfo.GetDrives();
            return dirveInfo.Where(d => d.DriveType != DriveType.CDRom).ToList();
        }

        public static bool IsValidImage(byte[] bytes)
        {
            try
            {
                using (MemoryStream ms = new MemoryStream(bytes))
                    Image.FromStream(ms);
            }
            catch (ArgumentException)
            {
                return false;
            }
            return true;
        }

        public static string GetMacId()
        {
            string macAddresses = "";

            foreach (NetworkInterface nic in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (nic.OperationalStatus == OperationalStatus.Up)
                {
                    macAddresses += nic.GetPhysicalAddress().ToString();
                    break;
                }
            }
            return macAddresses;
        }
    }
}
