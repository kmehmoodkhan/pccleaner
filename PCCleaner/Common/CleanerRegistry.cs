using Microsoft.Win32;
using PCCleaner.Controls.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCCleaner.Common
{
   public class CleanerRegistry
    {
        public List<ComputerProgram> GetStartupPrograms()
        {
            List<ComputerProgram> programs = new List<ComputerProgram>();
            RegistryKey key = Registry.LocalMachine.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run");
            var keys1 = key.GetValueNames();

            foreach( var ky in keys1)
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

        }
}
