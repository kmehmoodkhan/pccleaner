using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCCleaner.Common
{
    public class BrowserExtension
    {
        public bool IsEnabled
        {
            get;
            set;
        }
        public string Key
        {
            get;
            set;
        }
        public string Program
        {
            get;
            set;
        }

        public string Publisher
        {
            get;
            set;
        }
        public string FilePath
        {
            get;
            set;
        }
        public string Version
        {
            get;
            set;
        }
        public string Product
        {
            get;
            set;
        }
    }
}
