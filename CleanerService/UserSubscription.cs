//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CleanerService
{
    using System;
    using System.Collections.Generic;
    
    public partial class UserSubscription
    {
        public int SubscriptionId { get; set; }
        public string FullName { get; set; }
        public string EmailAddress { get; set; }
        public string MacAddress { get; set; }
        public bool IsEnabled { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public System.DateTime ModifiedOn { get; set; }
        public string ActivationCode { get; set; }
    }
}
