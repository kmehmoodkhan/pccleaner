using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCCleaner.Common
{
    [Serializable]
   public class ResultDetail
    {
        public string FilePath
        {
            get;
            set;
        }

        public long FileSize
        {
            get;
            set;
        }

        
        public SearchArea SearchArea
        {
            get;
            set;
        }
        public FeatureArea FeatureArea
        {
            get;
            set;
        }
        
        public Image Icon
        {
            get
            {
                return Helper.GetSearchAreaIcon(SearchArea);
            }
        }

        public RegistryOptions RegistryProblem
        {
            get;
            set;
        }

        public string Data
        {
            get;
            set;
        }

        public string RegistryKey
        {
            get;
            set;
        }
    }
}
