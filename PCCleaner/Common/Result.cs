using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCCleaner.Common
{
    public class Result
    {
        public string SearchAreaTitle
        {
            get
            {
                return "Edge";
            }
        }
        public SearchArea SearchArea
        {
            get;
            set;
        }

        Image icon = null;
        public Image Icon
        {
            get
            {
                return icon;
            }
            set
            {
                icon = value;
            }
        }
        public string FeatureName
        {
            get
            {
                return "Internet Cache";
            }
        }
        

        public double FilesSize
        {
            get;
            set;
        }

        public int TotalFiles
        {
            get;
            set;
        }
    }
}
