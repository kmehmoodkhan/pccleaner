﻿using System;
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
using System.Net.Mail;
using System.Diagnostics;

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
            if (dt != null && dt.Rows.Count > 0)
            {
                this.groupBoxRequest.Visible = false;
            }

            DataTable subscriptionInfo = OptionsAdvanceSetting.GetSubscriptionInfo();
            if (subscriptionInfo != null && subscriptionInfo.Rows.Count > 0)
            {
                this.groupBoxSubscripton.Hide();
                this.labelActivated.Show();
            }
        }


        private void buttonSave_Click(object sender, EventArgs e)
        {
            bool isValid = false;

            if (
                (!string.IsNullOrEmpty(this.textBoxFirstName.Text)) &&
                (!string.IsNullOrEmpty(this.textBoxEmail.Text)) &&
                (!string.IsNullOrEmpty(this.textBoxLastName.Text))
                )
            {
                try
                {
                    string email = new MailAddress(this.textBoxEmail.Text).Address;
                    isValid = true;
                }
                catch (Exception ex)
                {
                    errorProvider1.SetError(textBoxEmail, "Please provide valid email address");
                    isValid = false;
                    ;
                }
            }

            if (this.textBoxFirstName.Text.Trim().Length < 1)
            {
                errorProvider1.SetError(textBoxFirstName, "Please enter First Name");
            }

            if (this.textBoxLastName.Text.Trim().Length < 1)
            {
                errorProvider1.SetError(textBoxLastName, "Please enter Last Name");
            }

            if (this.textBoxEmail.Text.Trim().Length < 1)
            {
                errorProvider1.SetError(textBoxEmail, "Please enter Email Address");
            }

            if (isValid)
            {
                OptionsAdvanceSetting.AddSubscriptionRequest(this.textBoxFirstName.Text, this.textBoxLastName.Text, this.textBoxEmail.Text, Helper.GetMacId());

                string fullName = this.textBoxFirstName.Text + " " + this.textBoxLastName.Text;

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
                catch (Exception ex)
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

                //DataTable dt = OptionsAdvanceSetting.GetRequestUserInfo();

                //if (dt.Rows.Count < 1)
                //{
                //    MessageBox.Show("Please request for subscription.");
                //}
                //else
                //{

                //    string subscriptionUrl = CleanerApplicationSettings.SubscriptionURL + "api/subscription/action.php?page_key=create";

                //    string firstName = dt.Rows[0]["FirstName"].ToString();
                //    string lastName = dt.Rows[0]["LastName"].ToString();
                //    string emailAddress = dt.Rows[0]["EmailAddress"].ToString();

                //    string activationCode = this.textBoxActKey.Text;

                //    var client = new RestClient(subscriptionUrl);
                //    var request = new RestRequest(Method.POST);
                //    request.AddHeader("cache-control", "no-cache");
                //    request.AddHeader("accept", "application/json");


                //    request.AddParameter("EmailAddress", emailAddress);
                //    request.AddParameter("MacId", Helper.GetMacId());
                //    request.AddParameter("ActivationCode", activationCode);

                //    IRestResponse response = client.Execute(request);



                //    if (response.IsSuccessful)
                //    {
                //        string jsonResult = response.Content;

                //        OptionsAdvanceSetting.AddSubscriptionInfo(firstName + " " + lastName, emailAddress, activationCode, Helper.GetMacId());

                //        MessageBox.Show("Product is activated successfully. It will be restarted.");

                //        System.Threading.Thread.Sleep(2000);
                //        Process.Start(System.Reflection.Assembly.GetExecutingAssembly().Location);
                //        Process.GetCurrentProcess().Kill();
                //    }
                //    else
                //    {
                //        MessageBox.Show("Activation code provided is incorrect, please try again with correct one.");
                //    }

                //}
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
