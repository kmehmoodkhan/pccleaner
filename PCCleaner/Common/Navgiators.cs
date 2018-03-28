using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PCCleaner.Common.Enum;

namespace PCCleaner.Common
{
    public class Navgiators
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

                if (browser.Name.Contains("Internet Explorer") || (browser.Name.Contains("Edge"))) {
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
    }

    public  static class Extensions
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


    public  class Browser
    {
        public string Name { get; set; }
        public string Path { get; set; }
        public string IconPath { get; set; }
        public string Version { get; set; }

        public BrowserType BrowserType { get; set; }
    }
}
