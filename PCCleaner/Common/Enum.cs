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
        Advanced = 6,
        WindowsStore = 7,
        Applications = 8,
        Internet = 9,
        Multimedia = 10,
        Utilities = 11,
        Windows = 12,
        Registry = 13
    };

    public enum BrowserFeatures
    {
        Cache = 1,
        InternetHistory = 2,
        Cookies = 3,
        DownloadHistory = 4,
        LastDownloadLocation = 5,
        Session = 6,
        SavedFormInformation = 7,
        SavedPassword = 8,
        CompactDatabases = 9
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
        Cache = 1,
        InternetHistory = 2,
        Cookies = 3,
        DownloadHistory = 4,
        LastDownloadLocation = 5,
        Session = 6,
        SavedFormInformation = 7,
        SavedPassword = 8,
        CompactDatabases = 9,
        RecentDocuments = 10,
        Run = 11,
        MRUs = 12,
        ThumbnailCache = 13,
        TaskbarJumpList = 14,
        NetworkPasswords = 15,
        EmptyRecycleBin = 16,
        TemporaryFiles = 17,
        Clipboard = 18,
        MemoryDumps = 19,
        ChkDskFileFragments = 20,
        WindowsLogFiles = 21,
        WindowErrorReporting = 22,
        DNSCache = 23,
        FontCache = 24,
        StartMenuShortCuts = 25,
        DesktopShortCuts = 26,
        WindowsEventLogs = 27,
        OldPrefetchedData = 28,
        MenuOrderCache = 29,
        TrayNotificationCache = 29,
        WindowSizeLocationCache = 30,
        EnvironmentPath = 31,
        UserAssistHistory = 32,
        IISLogFiles = 33,
        OldWindowsInstallation = 34,
        CustomFilesFolderPath = 35,
        WipeFreeSpace = 36,
        BingNews = 37,
        SkypeMetro = 38,
        AdobeReader = 39,
        McAFee = 40,
        PictureManager = 41,
        NotepadPlus = 42,
        Office = 43,
        Skype=44,
        UTorrent = 45,
        SevenZip = 46,
        Teamviewer = 47,
        WindowsDefender = 48,
        GameExplorer = 49,
        ManagementConsole = 50,
        Paint = 51,
        Search = 52,
        RegEdit = 53,
        RemoteDesktop = 54,
        MissingSharedDlls = 55,
        UnUsedFileExtensions = 56,
        ActivexAndClassIssues = 57,
        TypeLibraries = 58,
        Applications = 59,
        Fonts = 60,
        ApplicationPaths = 61,
        HelpFiles =62,
        Installer = 63,
        ObsoleteSoftware = 64,
        RunAtStartup = 65,
        StartMenuOrdering = 66,
        MUICache = 67,
        SoundEvents = 68,
        WindowsServices = 69
    }

    public enum WindowStore
    {
        BingNews = 1,
        SkypeMetro =2 
    }

    public enum Applications
    {
        AdobeReader = 1,
        McAFee = 2,
        PictureManager = 3,
        NotepadPlus = 4,
        Office = 5
    }

    public enum Internet
    {
        Skype = 1,
        UTorrent = 2
    }

    public enum Multimedia
    {
        AdobeFlashPlayer = 1,
        Silverlight = 2,
        MediaPlayer = 3
    }

    public enum ResultView
    {
        Overall = 1,
        Detail = 2
    }

    public enum Utilities
    {
        SevenZip = 1,
        Teamviewer= 2,
        WindowsDefender = 3
    }
    public enum Windows
    {
        GameExplorer = 1,
        ManagementConsole = 2,
        Paint=3,
        Search = 4,
        RegEdit = 5,
        RemoteDesktop = 6
    }

    public enum KnownFolder
    {
        Contacts,
        Desktop,
        Documents,
        Downloads,
        Favorites,
        Links,
        Music,
        Pictures,
        SavedGames,
        SavedSearches,
        Videos
    }

    public enum RegistryOptions
    {
        MissingSharedDlls = 1,
        UnUsedFileExtensions = 2,
        ActivexAndClassIssues = 3,
        TypeLibraries = 4,
        Applications = 5,
        Fonts = 6,
        ApplicationPaths = 7,
        HelpFiles = 8,
        Installer = 9,
        ObsoleteSoftware = 10,
        RunAtStartup = 11,
        StartMenuOrdering = 12,
        MUICache = 13,
        SoundEvents = 14,
        WindowsServices = 15
    }

    public enum ApplicationItem
    {
        Cleaner = 1,
        Registry = 2,
        Tools = 3,
        Options = 4
    }

    public enum FileTypes
    {
        Pictures = 1,
        Music = 2,
        Documents = 3,
        Video = 4,
        Compressed = 5,
        Email = 6,
        Everything = 7
    }
}
