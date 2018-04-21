using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PCCleaner.Tools
{
   public class DiskFileInfo
    {
        public string FileName
        {
            get;
            set;
        }

        public string FilePath
        {
            get;
            set;
        }

        public string FileType
        {
            get;
            set;
        }

        public string FileSize
        {
            get;
            set;
        }

        public string Category
        {
            get;
            set;
        }

        public string ModifiedTime
        {
            get;
            set;
        }
    }
}
