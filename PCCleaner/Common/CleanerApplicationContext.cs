using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCCleaner.Common
{
    public static class CleanerApplicationContext
    {

        private static ResultSummary resultSummary = null;
        public static ResultSummary ResultSummary
        {
            get
            {
                return resultSummary;
            }
            set
            {
                resultSummary = value;
            }
        }

        public static void ResetObject()
        {
            resultSummary = null;
        }
    }
}
