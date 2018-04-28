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

namespace PCCleaner.Controls
{
    public partial class UCSubsciption : UserControl
    {
        private static HttpClient httpClientSubApi;
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


        private async void buttonSave_Click(object sender, EventArgs e)
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
                HttpClientHandler handler = new HttpClientHandler()
                {
                    UseDefaultCredentials = true
                };

                string subscriptionUrl = CleanerApplicationSettings.SubscriptionURL + "api/subscription/requestactivation?";

                httpClientSubApi = new HttpClient(handler);
                httpClientSubApi.BaseAddress = new Uri(CleanerApplicationSettings.SubscriptionURL);

                subscriptionUrl += "FullName=" + this.textBoxFirstName.Text + " " + this.textBoxLastName.Text;
                subscriptionUrl += "&EmailAddress=" + this.textBoxEmail.Text;
                subscriptionUrl += "&MacId=" + Helper.GetMacId();


                httpClientSubApi.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = await httpClientSubApi.GetAsync(subscriptionUrl);

                if (response.IsSuccessStatusCode)
                {
                    string jsonResult = await response.Content.ReadAsStringAsync();

                    jsonResult = jsonResult.TrimStart('\"');
                    jsonResult = jsonResult.TrimEnd('\"');
                    jsonResult = jsonResult.Replace("\\", "");

                   

                    MessageBox.Show("Request sent successfully. You will receive activation code email shortly.");
                }
                this.groupBoxRequest.Hide();
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
                HttpClientHandler handler = new HttpClientHandler()
                {
                    UseDefaultCredentials = true
                };

                DataTable dt = OptionsAdvanceSetting.GetRequestUserInfo();

                string subscriptionUrl = CleanerApplicationSettings.SubscriptionURL + "api/subscription/addsubscription?";

                httpClientSubApi = new HttpClient(handler);
                httpClientSubApi.BaseAddress = new Uri(CleanerApplicationSettings.SubscriptionURL);

                string firstName = dt.Rows[0]["FirstName"].ToString();
                string lastName = dt.Rows[0]["LastName"].ToString();
                string emailAddress = dt.Rows[0]["EmailAddress"].ToString();
                string activationKey = this.textBoxActKey.Text;
                string macId = Helper.GetMacId();

                subscriptionUrl += "FullName=" + firstName + " "+ lastName;
                subscriptionUrl += "&EmailAddress=" + emailAddress;
                subscriptionUrl += "&ActivationCode=" + activationKey;
                subscriptionUrl += "&MacId=" + macId;


                httpClientSubApi.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = await httpClientSubApi.GetAsync(subscriptionUrl);

                if (response.IsSuccessStatusCode)
                {
                    string jsonResult = await response.Content.ReadAsStringAsync();

                    OptionsAdvanceSetting.AddSubscriptionInfo(firstName+" "+lastName, emailAddress, activationKey,macId);

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
