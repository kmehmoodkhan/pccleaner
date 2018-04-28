using CleanerService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;

namespace CleanerService
{
    public class Business
    {
        public void RequestActivation(string fullName, string emailAddress)
        {
            string activationKey = "";
            using (var db = new SubscriptionContext())
            {
                activationKey = db.ActivationCodes.FirstOrDefault().CodeName;
            }
            SendActivationCodeEmail(emailAddress, fullName, activationKey);
        }
        public ClientInfo AddSubscription(string fullName, string emailAddress, string macAddress, string activationCode)
        {
            ClientInfo clientInfo = new ClientInfo();

            using (var db = new SubscriptionContext())
            {
                var checkForKey = db.ActivationCodes.Where(c => c.CodeName == activationCode).FirstOrDefault();
                if (checkForKey != null)
                {
                    bool isActivatedAlready = false;

                    isActivatedAlready = db.UserSubscriptions.Where(t => t.FullName == fullName && t.EmailAddress == emailAddress).Count() > 0;

                    if (!isActivatedAlready)
                    {
                        var usrSub = new CleanerService.UserSubscription();
                        usrSub.FullName = fullName;
                        usrSub.EmailAddress = emailAddress;
                        usrSub.MacAddress = macAddress;
                        usrSub.ActivationCode = activationCode;
                        usrSub.IsEnabled = true;
                        clientInfo.ActivationCode = activationCode;

                        usrSub.CreatedOn = DateTime.Now;
                        usrSub.ModifiedOn = DateTime.Now;

                        db.UserSubscriptions.Add(usrSub);
                        db.SaveChanges();
                    }
                    else
                    {
                        clientInfo.ErrorCode = 2;
                    }
                }
                else
                {
                    clientInfo.ErrorCode = 1;
                }
            }

            clientInfo.FullName = fullName;
            clientInfo.EmailAddress = emailAddress;
            clientInfo.MacId = macAddress;
            return clientInfo;
        }

        public ClientInfo GetSubscriptionInfo(string fullName, string emailAddress, string macAddress)
        {
            ClientInfo clientInfo = new ClientInfo();
            using (var db = new SubscriptionContext())
            {
                var subscription = db.UserSubscriptions.Where(u => u.FullName.ToLower() == fullName.ToLower() &&
                                                                      u.EmailAddress.ToLower() == emailAddress &&
                                                                      u.MacAddress == macAddress &&
                                                                      u.IsEnabled == true).FirstOrDefault();

                if (subscription != null)
                {
                    clientInfo.FullName = subscription.FullName;
                    clientInfo.EmailAddress = subscription.EmailAddress;
                    clientInfo.IsEnabled = subscription.IsEnabled.Equals(true) ? 1 : 0;
                }
                else
                {
                    clientInfo.ActivationCode = db.ActivationCodes.FirstOrDefault().CodeName;
                }
            }
            return clientInfo;
        }

        public bool IsValidSubscription(string fullName, string emailAddress, string macAddress, string activationCode)
        {
            bool isValid = false;
            using (var db = new SubscriptionContext())
            {
                if (db.UserSubscriptions.Where(t => 
                                                    t.EmailAddress == emailAddress &&
                                                    t.MacAddress == macAddress &&
                                                    t.ActivationCode == activationCode &&
                                                    t.IsEnabled == true
                                                    ).Count() > 0)
                {
                    isValid = true;
                }
            }
            return isValid;
        }

        private void SendActivationCodeEmail(string receiverEmailAddress, string receiverName, string activationCode)
        {
            string host = System.Configuration.ConfigurationManager.AppSettings["EmailHost"].ToString();
            int port = 25;

            if (System.Configuration.ConfigurationManager.AppSettings["EmailPort"] != null)
            {
                port = Convert.ToInt32(System.Configuration.ConfigurationManager.AppSettings["EmailPort"].ToString());
            }

            string htmlBody = "<p>Dear [User],</p>";
            htmlBody += "<p>&nbsp;</p>";
            htmlBody += "<p>Thank you for purchasing our service. Please copy the activation code \"[" + activationCode + "]\" and paste in the subscription form which is available in the Options area. Once you enter the activation code press the subscribe button.&nbsp;</p>";
            htmlBody += "<p>Have a nice day!</p>";
            htmlBody += "<p>&nbsp;</p>";
            htmlBody += "<p>PC-Cleaner Team</p>";

            MailMessage mail = new MailMessage("nopreply@pccleaner.com", receiverEmailAddress);
            SmtpClient client = new SmtpClient();
            client.Port = port;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.UseDefaultCredentials = false;
            client.Host = host;
            mail.IsBodyHtml = true;
            mail.Subject = "PC-Cleaner Activation";
            mail.Body = htmlBody;
            client.Send(mail);
        }
    }
}