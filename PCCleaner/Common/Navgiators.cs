using Microsoft.Win32;
using Newtonsoft.Json;
using PCCleaner.Controls.Common;
using PCCleaner.Properties;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace PCCleaner.Common
{
    public class Navigators
    {

        public static List<Browser> GetBrowsers()
        {
            RegistryKey browserKeys;
            //on 64bit the browsers are in a different location
            browserKeys = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\WOW6432Node\Clients\StartMenuInternet");
            if (browserKeys == null)
                browserKeys = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Clients\StartMenuInternet");
            string[] browserNames = browserKeys.GetSubKeyNames();
            var browsers = new List<Browser>();
            for (int i = 0; i < browserNames.Length; i++)
            {
                Browser browser = new Browser();
                RegistryKey browserKey = browserKeys.OpenSubKey(browserNames[i]);
                browser.Name = (string)browserKey.GetValue(null);

                if (browser.Name.Contains("Internet Explorer") || (browser.Name.Contains("Edge")))
                {
                    browser.BrowserType = BrowserType.Microsoft;
                }

                RegistryKey browserKeyPath = browserKey.OpenSubKey(@"shell\open\command");
                browser.Path = (string)browserKeyPath.GetValue(null).ToString().StripQuotes();
                RegistryKey browserIconPath = browserKey.OpenSubKey(@"DefaultIcon");
                browser.IconPath = (string)browserIconPath.GetValue(null).ToString().StripQuotes();
                browsers.Add(browser);
                if (browser.Path != null)
                    browser.Version = FileVersionInfo.GetVersionInfo(browser.Path).FileVersion;
                else
                    browser.Version = "unknown";
            }
            return browsers;
        }

        public static bool IsEdgeBrowserInstalled()
        {
            bool edgeFound = false;
            using (var key = Microsoft.Win32.Registry.ClassesRoot.OpenSubKey(@"Local Settings\Software\Microsoft\Windows\CurrentVersion\AppModel\PackageRepository\Packages\"))
            {
                if (key != null)
                {
                    foreach (var subkey in key.GetSubKeyNames())
                    {
                        if (subkey.StartsWith("Microsoft.MicrosoftEdge_"))
                        {
                            edgeFound = true;
                            break;
                        }
                    }
                }
            }
            return edgeFound;
        }

        public static List<ListItem> GetBrowserFeatures()
        {
            List<ListItem> list = new List<ListItem>();

            foreach (BrowserFeatures feature in Enum.GetValues(typeof(BrowserFeatures)))
            {
                ListItem item = new ListItem() { ItemId = Convert.ToInt32(feature), ItemText = Resources.ResourceManager.GetString("BrowserFeature_" + Convert.ToInt32(feature)) };
                list.Add(item);
            }
            return list;
        }

        public static List<BrowserExtension> GetIEPlugins()
        {
            List<BrowserExtension> extensions = new List<BrowserExtension>();

            string machineLevelAddOns = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\Browser Helper Objects";
            RegistryKey key = Registry.LocalMachine.OpenSubKey(machineLevelAddOns);
            var list = key.GetSubKeyNames();

            foreach (string keyValue in list)
            {
                RegistryKey childKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Classes\\CLSID\\" + keyValue + "\\InprocServer32");
                var path = childKey.GetValue("");
                BrowserExtension extension = new BrowserExtension();

                extension.FilePath = path.ToString();
                extension.Key = "Helper";



                string publisher = string.Empty;
                ///////////////////////////////////////////////////
                string registryKey = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall";
                RegistryKey programKey = Registry.LocalMachine.OpenSubKey(registryKey);
                if (key != null)
                {
                    foreach (RegistryKey subkey in programKey.GetSubKeyNames().Select(keyName => programKey.OpenSubKey(keyName)))
                    {
                        if (subkey.GetValue("DisplayName") as string == keyValue)
                        {
                            publisher = subkey.GetValue("Publisher") as string;
                        }
                    }
                    childKey.Close();
                }

                extensions.Add(extension);

                ///////////////////////////////////////////////////
            }
            key.Close();
            return extensions;
        }

        public static List<BrowserExtension> GetChromePlugins()
        {
            List<BrowserExtension> list = new List<BrowserExtension>();
            string extensionsPath = string.Empty;

            var path = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            path += @"\Google\Chrome\User Data\Default\Extensions\";

            var dirs = Directory.GetDirectories(path, "*.*", SearchOption.TopDirectoryOnly);

            foreach (string dir in dirs)
            {
                BrowserExtension extension = new BrowserExtension();
                DirectoryInfo dirInfo = new DirectoryInfo(dir);
                var versionDirectory = dirInfo.GetDirectories().ToList().ElementAt(0);

                var jsonFilePath = versionDirectory.FullName + "\\_locales\\en_US\\messages.json";

                if (new FileInfo(jsonFilePath).Exists)
                {
                    var file = File.ReadAllText(jsonFilePath);

                    dynamic parsed = JsonConvert.DeserializeObject<dynamic>(file);

                    try
                    {
                        string appName = ((Newtonsoft.Json.Linq.JValue)((Newtonsoft.Json.Linq.JProperty)((Newtonsoft.Json.Linq.JContainer)parsed.appName).Last).Value).Value.ToString();

                        extension.Program = appName;
                        extension.FilePath = versionDirectory.FullName;
                        extension.Key = "Extension";
                        list.Add(extension);
                    }
                    catch (Exception ex)
                    {
                        ;
                    }
                }
            }

            return list;
        }


        public static List<BrowserExtension> GetFirefoxExtensions()
        {
            List<BrowserExtension> list = new List<BrowserExtension>();
            string extensionsPath = string.Empty;

            var path = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles);
            path += @"\Mozilla Firefox\browser\features\";

            var files = Directory.GetFiles(path, "*.xpi", SearchOption.TopDirectoryOnly);

            BrowserExtension extension = new BrowserExtension();

            foreach (string file in files.ToList())
                if (new FileInfo(file).Exists)
                {
                    var fileContent = File.ReadAllText(file);



                    try
                    {
                        //dynamic parsed = JsonConvert.DeserializeObject<dynamic>(fileContent);
                        //string appName = ((Newtonsoft.Json.Linq.JValue)((Newtonsoft.Json.Linq.JProperty)((Newtonsoft.Json.Linq.JContainer)parsed.appName).Last).Value).Value.ToString();

                        extension.Program = Path.GetFileName(file);
                        extension.FilePath = file;
                        extension.Key = "Extension";
                        list.Add(extension);
                    }
                    catch (Exception ex)
                    {
                        ;
                    }
                }

            return list;
        }
    }

    public static class Extensions
    {
        internal static String StripQuotes(this String s)
        {
            if (s.EndsWith("\"") && s.StartsWith("\""))
            {
                return s.Substring(1, s.Length - 2);
            }
            else
            {
                return s;
            }
        }
    }


    public class Browser
    {
        public string Name { get; set; }
        public string Path { get; set; }
        public string IconPath { get; set; }
        public string Version { get; set; }

        public BrowserType BrowserType { get; set; }
    }
}
