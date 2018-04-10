using PCCleaner.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCCleaner.Common
{
    [Serializable]
    public class Result
    {
        string searchAreaTitle = string.Empty;
        public string SearchAreaTitle
        {
            get
            {
                return searchAreaTitle;
            }
        }


        SearchArea searchArea;
        public SearchArea SearchArea
        {
            get
            {
                return searchArea;
            }
            set
            {
                searchArea = value;
                searchAreaTitle =  Resources.ResourceManager.GetString("SearchArea_" + Convert.ToInt32(searchArea));
            }
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
            get;
            set;
        }
        

        public string FilesSize
        {
            get;
            set;
        }

        public string TotalFiles
        {
            get;
            set;
        }
    }
}
