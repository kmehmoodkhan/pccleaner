using PCCleaner.Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCCleaner.DataAccess
{
    public static class IncludeExcludeOptions
    {
        static DataView DVOptionSettings = null;
        static IncludeExcludeOptions()
        {
            DataSet dataSet = CleanerApplicationSettings.GetIncludedItems();
            DataView defaultView = dataSet.Tables[0].DefaultView;
            DVOptionSettings = defaultView;
        }

        public static DataView GetIncludedItems()
        {
            DataSet dataSet = CleanerApplicationSettings.GetIncludedItems();
            DataView defaultView = dataSet.Tables[0].DefaultView;
            return defaultView;
        }

        public static DataView GetExcludedItems()
        {
            DataSet dataSet = CleanerApplicationSettings.GetExcludedItems();
            DataView defaultView = dataSet.Tables[0].DefaultView;
            return defaultView;
        }

        public static DataView AddNewItem(string path, int itemType, string filterType,bool isInclude)
        {
            int include = (isInclude == true) ? 1 : 0;
            string query = "INSERT INTO ExcludedPath(Path,ItemType,FilterType,IsInclude) values('"+path+"','"+itemType+"','"+filterType+"',"+include+")";
            CleanerApplicationSettings.AddNewItem(query);
            DataSet dataSet = CleanerApplicationSettings.GetIncludedItems();
            DataView defaultView = dataSet.Tables[0].DefaultView;
            DVOptionSettings = defaultView;
            return DVOptionSettings;
        }
    }
}
