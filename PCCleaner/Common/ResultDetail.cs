using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCCleaner.Common
{
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
        public BrowserFeatures Feature
        {
            get;
            set;
        }
       
    }
}
