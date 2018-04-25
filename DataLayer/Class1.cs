using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public static class AdvanceOptionSettings 
    {

        static DataSet dataSet = null;
        static AdvanceOptionSettings()
        {
            dataSet = CleanerApplicationSettings.GetApplicationSettings();

        }

        public bool ShowInitialResultsView
        {
            get;
        }
    }
}
