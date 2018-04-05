using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCCleaner.Common
{
   public class ResultSummary
    {
        public List<Result> OverallResult
        {
            get;
            set;
        }

        public List<ResultDetail> DetailResult
        {
            get;
            set;
        }

        public ResultSummary()
        {
            OverallResult = new List<Result>();
            DetailResult = new List<ResultDetail>();
        }
    }
}
