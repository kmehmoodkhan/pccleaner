using Microsoft.Win32;
using WinTaskScheduler=Microsoft.Win32.TaskScheduler;
using PCCleaner.Controls.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace PCCleaner.Common
{
    public class CleanerRegistry
    {
        public List<ComputerProgram> GetStartupPrograms()
        {
            List<ComputerProgram> programs = new List<ComputerProgram>();
            RegistryKey key = Registry.LocalMachine.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run");
            var keys1 = key.GetValueNames();

            foreach (var ky in keys1)
            {
                var path = key.GetValue(ky);

                ComputerProgram program = new ComputerProgram();
                program.ProgramName = ky;
                program.LauncherFile = path.ToString();
                program.RegistryKey = "HKLM:Run";
                program.Publisher = GetProgramPublisher(program.ProgramName);
                program.IsEnabled = IsStartupProgramEnabled(program.ProgramName);
                program.IsEnabledText = (program.IsEnabled == true ? "Enabled" : "Disabled");
                programs.Add(program);
            }

            key.Close();


            RegistryKey keyUser = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run");
            var keyUserValues = keyUser.GetValueNames();

            foreach (var ky in keyUserValues)
            {
                var path = keyUser.GetValue(ky);

                ComputerProgram program = new ComputerProgram();
                program.ProgramName = ky;
                program.LauncherFile = path.ToString();
                program.RegistryKey = "HKCU:Run";

                program.Publisher = GetProgramPublisher(program.ProgramName);
                program.IsEnabled = IsStartupProgramEnabled(program.ProgramName);
                program.IsEnabledText = (program.IsEnabled == true ? "Enabled" : "Disabled");
                programs.Add(program);
            }

            keyUser.Close();



            return programs;


        }

        public string GetProgramPublisher(string program)
        {
            string publisher = string.Empty;
            string registryKey = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall";
            RegistryKey key = Registry.LocalMachine.OpenSubKey(registryKey);
            if (key != null)
            {
                foreach (RegistryKey subkey in key.GetSubKeyNames().Select(keyName => key.OpenSubKey(keyName)))
                {
                    if (subkey.GetValue("DisplayName") as string == program)
                    {
                        publisher = subkey.GetValue("Publisher") as string;
                    }
                }
                key.Close();
            }
            return publisher;
        }

        public bool IsStartupProgramEnabled(string programName)
        {
            bool isEnabled = true;
            RegistryKey keyUser = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Explorer\StartupApproved\Run");
            var keyUserValues = keyUser.GetValueNames();

            foreach (var ky in keyUserValues)
            {
                if (ky == programName)
                {
                    var path = keyUser.GetValue(ky);
                    if (((byte[])keyUser.GetValue(ky))[0] == 3)
                    {
                        isEnabled = false;
                    }
                }
            }

            keyUser.Close();
            return isEnabled;

        }


        List<ComputerProgram> Tasks = new List<ComputerProgram>();
        public List<ComputerProgram> GetScheduledTasks()
        {
            using (WinTaskScheduler.TaskService ts = new WinTaskScheduler.TaskService())
            {
                EnumFolderTasks(ts.RootFolder);
            }
            return Tasks;
        }

        public void EnumFolderTasks(WinTaskScheduler.TaskFolder fld)
        {
            foreach (WinTaskScheduler.Task task in fld.Tasks)
                DisplayTask(task);
        }

        public void DisplayTask(Microsoft.Win32.TaskScheduler.Task t)
        {
            ComputerProgram program = new ComputerProgram();
            program.ProgramName = t.Name;
            program.Publisher = t.Definition.RegistrationInfo.Author;
            program.IsEnabled = t.Enabled;
            program.RegistryKey = "Task";
            program.IsEnabledText = (t.Enabled == true ? "Enabled" : "Disabled");
            program.LauncherFile = t.Definition.Actions.ToString();

            if(t.Definition.Principal.UserId!=null && t.Definition.Principal.UserId.ToLower() == "system")
                Tasks.Add(program);
        }
        

        public List<ComputerProgram> GetContextMenuItems()
        {
            string[] ExludedItems = { " FileSyncEx", "EPP", "ModernSharing", "Open With","Sharing","WorkFolders","Library Location","Offline Files","PintoStartScreen" };
            List<ComputerProgram> programs = new List<ComputerProgram>();

            string filesRegistry = @"*\shellex\ContextMenuHandlers";
            string foldersRegistry = @"Folder\shellex\ContextMenuHandlers";
            string directoryRegistry = @"Directory\shellex\ContextMenuHandlers";

            using (var regKey = Registry.ClassesRoot.OpenSubKey(filesRegistry))
            {
                var items = regKey.GetSubKeyNames();
                foreach(string item in items)
                {
                    if (!ExludedItems.Contains(item) && !item.StartsWith("{"))
                    {
                        var subKey = regKey.OpenSubKey(item);
                        ComputerProgram contextMenuItem = new ComputerProgram();
                        contextMenuItem.ProgramName = Path.GetFileName( subKey.Name);
                        contextMenuItem.Level = "File";
                        contextMenuItem.RegistryKey = filesRegistry;

                        if ( subKey.GetValue("")!=null && !string.IsNullOrEmpty(subKey.GetValue("").ToString()))
                        {
                            if (!subKey.GetValue("").ToString().StartsWith("[CC]"))
                            {
                                contextMenuItem.IsEnabled = true;
                                contextMenuItem.IsEnabledText = "Enabled";
                            }
                            else
                            {
                                contextMenuItem.IsEnabled = false;
                                contextMenuItem.IsEnabledText = "Disabled";
                            }
                            
                            
                            programs.Add(contextMenuItem);
                        }
                       
                    }
                }
            }

            using (var regKey = Registry.ClassesRoot.OpenSubKey(foldersRegistry))
            {
                var items = regKey.GetSubKeyNames();
                foreach (string item in items)
                {
                    if (!ExludedItems.Contains(item) && !item.StartsWith("{"))
                    {
                        var subKey = regKey.OpenSubKey(item);
                        ComputerProgram contextMenuItem = new ComputerProgram();
                        contextMenuItem.ProgramName = Path.GetFileName(subKey.Name);
                        contextMenuItem.Level = "Folder";
                        contextMenuItem.RegistryKey = foldersRegistry;

                        if (subKey.GetValue("") != null && !string.IsNullOrEmpty(subKey.GetValue("").ToString()))
                        {
                            if (!subKey.GetValue("").ToString().StartsWith("[CC]"))
                            {
                                contextMenuItem.IsEnabled = true;
                                contextMenuItem.IsEnabledText = "Enabled";
                            }
                            else
                            {
                                contextMenuItem.IsEnabled = false;
                                contextMenuItem.IsEnabledText = "Disabled";
                            }


                            programs.Add(contextMenuItem);
                        }


                        programs.Add(contextMenuItem);
                    }
                }
            }

            using (var regKey = Registry.ClassesRoot.OpenSubKey(directoryRegistry))
            {
                var items = regKey.GetSubKeyNames();
                foreach (string item in items)
                {
                    if (!ExludedItems.Contains(item) && !item.StartsWith("{"))
                    {
                        var subKey = regKey.OpenSubKey(item);
                        ComputerProgram contextMenuItem = new ComputerProgram();
                        contextMenuItem.ProgramName = Path.GetFileName(subKey.Name);
                        contextMenuItem.Level = "Directory";
                        contextMenuItem.RegistryKey = directoryRegistry;

                        if (subKey.GetValue("") != null && !string.IsNullOrEmpty(subKey.GetValue("").ToString()))
                        {
                            if (!subKey.GetValue("").ToString().StartsWith("[CC]"))
                            {
                                contextMenuItem.IsEnabled = true;
                                contextMenuItem.IsEnabledText = "Enabled";
                            }
                            else
                            {
                                contextMenuItem.IsEnabled = false;
                                contextMenuItem.IsEnabledText = "Disabled";
                            }


                            programs.Add(contextMenuItem);
                        }


                        programs.Add(contextMenuItem);
                    }
                }
            }


            return programs;
        }
    }
}
