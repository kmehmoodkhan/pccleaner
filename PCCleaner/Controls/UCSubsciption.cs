using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PCCleaner.Common;
using System.Net.NetworkInformation;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using PCCleaner.DataAccess;
using RestSharp;

namespace PCCleaner.Controls
{
    public partial class UCSubsciption : UserControl
    {
        public UCSubsciption()
        {
            InitializeComponent();
            CheckSubscriptionRequest();
        }

        private void CheckSubscriptionRequest()
        {
            DataTable dt = OptionsAdvanceSetting.GetRequestUserInfo();
            if( dt!=null && dt.Rows.Count>0)
            {
                this.groupBoxRequest.Visible = false;
            }

            DataTable subscriptionInfo = OptionsAdvanceSetting.GetSubscriptionInfo();
            if( subscriptionInfo!=null && subscriptionInfo.Rows.Count > 0)
            {
                this.groupBoxSubscripton.Hide();
                this.labelActivated.Show();
            }
        }


        private void buttonSave_Click(object sender, EventArgs e)
        {
            bool isValid = false;

            if(
                (!string.IsNullOrEmpty(this.textBoxFirstName.Text)) && 
                (!string.IsNullOrEmpty(this.textBoxEmail.Text)) &&
                (!string.IsNullOrEmpty(this.textBoxLastName.Text))
                )
            {
                isValid = true;
            }

            if (isValid)
            {
                OptionsAdvanceSetting.AddSubscriptionRequest(this.textBoxFirstName.Text, this.textBoxLastName.Text, this.textBoxEmail.Text, Helper.GetMacId());
                
                string fullName = this.textBoxFirstName.Text+" "+ this.textBoxLastName.Text;

                string subscriptionUrl = CleanerApplicationSettings.SubscriptionURL + "api/subscription/action.php?page_key=create";
                

                var client = new RestClient(subscriptionUrl);
                var request = new RestRequest(Method.POST);
                request.AddHeader("cache-control", "no-cache");
                request.AddHeader("accept", "application/json");

                request.AddParameter("FullName", fullName);
                request.AddParameter("EmailAddress", this.textBoxEmail.Text);
                request.AddParameter("MacId", Helper.GetMacId());

                try
                {
                    IRestResponse response = client.Execute(request);


                    if (response.IsSuccessful)
                    {
                        string jsonResult = response.Content;

                        jsonResult = jsonResult.TrimStart('\"');
                        jsonResult = jsonResult.TrimEnd('\"');
                        jsonResult = jsonResult.Replace("\\", "");
                        this.groupBoxRequest.Hide();
                        MessageBox.Show("Request sent successfully. You will receive activation code email shortly.");
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Application failed to connect to Subscription service, please try later on.");
                }                
            }
        }

        

        private async void button2_Click(object sender, EventArgs e)
        {
            bool isValid = false;

            if (!string.IsNullOrEmpty(this.textBoxActKey.Text))
            {
                isValid = true;
            }

            if (isValid)
            {

                DataTable dt = OptionsAdvanceSetting.GetRequestUserInfo();

                string subscriptionUrl = CleanerApplicationSettings.SubscriptionURL + "api/subscription/action.php?page_key=create";

                string firstName = dt.Rows[0]["FirstName"].ToString();
                string lastName = dt.Rows[0]["LastName"].ToString();
                string emailAddress = dt.Rows[0]["EmailAddress"].ToString();

                string activationCode = this.textBoxActKey.Text;

                var client = new RestClient(subscriptionUrl);
                var request = new RestRequest(Method.POST);
                request.AddHeader("cache-control", "no-cache");
                request.AddHeader("accept", "application/json");
                

                request.AddParameter("EmailAddress", emailAddress);
                request.AddParameter("MacId", Helper.GetMacId());
                request.AddParameter("ActivationCode", activationCode);

                 IRestResponse response = client.Execute(request);

                

                if (response.IsSuccessful)
                {
                    string jsonResult = response.Content;

                    OptionsAdvanceSetting.AddSubscriptionInfo(firstName+" "+lastName, emailAddress, activationCode, Helper.GetMacId());

                    MessageBox.Show("Product is activated successfully.");
                }
            }
        }
    }

    internal class Subscription
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
    }
}
