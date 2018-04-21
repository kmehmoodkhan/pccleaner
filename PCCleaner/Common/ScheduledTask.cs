using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCCleaner.Common
{
    public class ScheduledTask
    {
        public bool IsEnabled
        {
            get;
            set;
        }

        public bool IsEnabledText
        {
            get;
            set;
        }

        public string RegistryKey
        {
            get;
            set;
        }


        public string ProgramName
        {
            get;
            set;
        }

        public string Publisher
        {
            get;
            set;
        }

        public string LauncherFile
        {
            get;
            set;
        }

        public string Location
        {
            get;
            set;
        }
    }
}
