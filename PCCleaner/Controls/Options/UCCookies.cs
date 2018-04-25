using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PCCleaner.DataAccess;

namespace PCCleaner.Controls.Options
{
    public partial class UCCookies : UserControl
    {
        public UCCookies()
        {
            InitializeComponent();

            var list = CookiesSettings.GetCookiesList();

            foreach( DataRow dr in list.Table.Rows)
            {
                this.listBoxCookiesToKeep.Items.Add(dr["Cookie"]);
            }

            var cookiesList = CookiesSettings.GetAvailableCookies();

            foreach( var item in cookiesList)
            {
                this.listBoxAvailableCookies.Items.Add(item);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            

            try
            {
                String cookie = this.listBoxAvailableCookies.SelectedItem.ToString();
                this.listBoxAvailableCookies.Items.Remove(cookie);
                CookiesSettings.AddRemoveCookie(true, cookie);
                if (this.listBoxCookiesToKeep.Items.Contains(cookie))
                    this.listBoxCookiesToKeep.Items.Add(cookie);
            }
            catch (Exception ex)
            {
                ;
            }

           

        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            try
            {
                String cookie = this.listBoxCookiesToKeep.SelectedItem.ToString();
                this.listBoxCookiesToKeep.Items.Remove(cookie);
                CookiesSettings.AddRemoveCookie(false, cookie);

                if (this.listBoxAvailableCookies.Items.Contains(cookie))
                    this.listBoxAvailableCookies.Items.Add(cookie);
            }
            catch (Exception ex)
            {
                ;
            }
        }
    }
}
