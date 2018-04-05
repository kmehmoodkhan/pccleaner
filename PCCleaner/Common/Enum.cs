using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCCleaner.Common
{
    public enum BrowserType { Others = 0, Microsoft = 1 };

    public enum SearchArea
    {
        Edge = 0,
        IE =1,
        Chrome = 2,
        Firefox = 3,
        WindowExplorer=4,
        System = 5,
        Advanced = 6
    };

    public enum BrowserFeatures
    {
        Cache = 1,
        InternetHistory = 2,
        Cookies = 3,
        DownloadHistory = 4,
        LastDownloadLocation = 5,
        Session = 6,
        SitePreferences = 7,
        SavedFormInformation = 8,
        SavedPassword = 9,
        CompactDatabases = 10
    }

    public enum ExplorerFeatures
    {
        RecentDocuments = 1,
        Run = 2,
        MRUs = 3,
        ThumbnailCache = 4,
        TaskbarJumpList = 5,
        NetworkPasswords = 6
    }

    public enum SystemFeatures
    {
        EmptyRecycleBin = 1,
        TemporaryFiles = 2,
        Clipboard = 3,
        MemoryDumps = 4,
        ChkDskFileFragments = 5,
        WindowsLogFiles = 6,
        WindowErrorReporting = 7,
        DNSCache = 8,
        FontCache = 9,
        StartMenuShortCuts = 10,
        DesktopShortCuts = 11
    }

    public enum AdvancedFeatures
    {
        WindowsEventLogs = 1,
        OldPrefetchedData = 2,
        MenuOrderCache=3,
        TrayNotificationCache=4,
        WindowSizeLocationCache=5,
        EnvironmentPath = 6,
        UserAssistHistory = 7,
        IISLogFiles = 8,
        OldWindowsInstallation = 9,
        CustomFilesFolderPath = 10,
        WipeFreeSpace = 11
    }

    public enum FeatureArea
    {
        Cache = 1
    }

    public enum ResultView
    {
        Overall = 1,
        Detail = 2
    }
}
