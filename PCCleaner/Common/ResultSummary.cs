using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace PCCleaner.Common
{
    [Serializable]
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

        public ResultSummary(List<Result> overallResult, List<ResultDetail> detailResult)
        {
            OverallResult = overallResult;
            DetailResult = detailResult;
            
        }
        
    }
}
