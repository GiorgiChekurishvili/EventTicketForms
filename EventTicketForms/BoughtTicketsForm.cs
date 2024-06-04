using EventTicketForms.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventTicketForms
{
    public partial class BoughtTicketsForm : Form
    {
        private readonly string myTickets = "http://localhost:5172/api/Ticket/viewmytickets";
        private string _token;
        public BoughtTicketsForm()
        {
            InitializeComponent();
            _token = TokenManager.Token;
            SeeMyTickets();
        }
        private async void SeeMyTickets()
        {
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _token);
                using (HttpResponseMessage response = await client.GetAsync(myTickets))
                {
                    if (Convert.ToInt32(response.StatusCode) == 401)
                    {
                        MessageBox.Show("Unauthorized");
                    }
                    else if (Convert.ToInt32(response.StatusCode) == 200)
                    {
                        using (HttpContent content = response.Content)
                        {
                            var data = content.ReadAsStringAsync();


                        }
                    }
                    else { MessageBox.Show("Error"); }
                }
            }
        }
        private void txtFilter_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
