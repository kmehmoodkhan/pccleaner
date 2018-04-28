using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CleanerService.Models
{
    public class ClientInfo
    {
        public string FullName
        {
            get;
            set;
        }
        public string EmailAddress
        {
            get;
            set;
        }
        public string MacId
        {
            get;
            set;
        }
        public string ActivationCode
        {
            get;
            set;
        }
        public int IsEnabled
        {
            get;
            set;
        }
        public int ErrorCode
        {
            get;
            set;
        }
    }
}