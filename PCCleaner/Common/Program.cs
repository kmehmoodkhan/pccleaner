using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCCleaner.Common
{
   public  class Program
    {
        public string LauncherPath
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
        public string InstallDate
        {
            get;
            set;
        }
        public string Version
        {
            get;
            set;
        }
        public string Size
        {
            get;
            set;
        }
        public Image Icon
        {

            get;
            set;
        }

        public string UninstallString
        {
            get;
            set;
        }
        public string RegistryEntry
        {
            get;
            set;
        }
    }
}
