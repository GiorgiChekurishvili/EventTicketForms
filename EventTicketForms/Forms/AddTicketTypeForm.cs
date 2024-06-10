using EventTicketForms.Resources;
using Newtonsoft.Json;
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

namespace EventTicketForms.Forms
{
    public partial class AddTicketTypeForm : Form
    {
        private readonly string _addTicketTypeUrl = "http://localhost:5172/api/TicketType/addtickettype";

        private string _eventName;
        private int _eventId;
        public AddTicketTypeForm(int eventId, string eventName)
        {
            InitializeComponent();
            _eventId = eventId;
            _eventName = eventName;
        }

        private void AddTicketTypeForm_Load(object sender, EventArgs e)
        {
            lblEventName.Text = _eventName;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", StaticResources.Token);

                TicketTypeProperties ticketType = new TicketTypeProperties()
                {
                    EventId = _eventId,
                    Price = Convert.ToDecimal(txtPrice.Text),
                    TicketTypeName = txtTicketTypeName.Text,
                    TotalTickets = int.Parse(txtTotalTickets.Text),
                    SalesStartDate = Convert.ToDateTime($"{dateForSalesStart.Text} {TimeForSalesStart.Text}"),
                    SalesEndDate = Convert.ToDateTime($"{DateForSalesEnd.Text} {TimeForSalesEnd.Text}")
                };
                var json = JsonConvert.SerializeObject(ticketType);
                var input = new StringContent(json, Encoding.UTF8, "application/json");
                using (HttpResponseMessage response = await client.PostAsync(_addTicketTypeUrl, input))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("successfully added new ticket type");
                    }
                    else if(response.StatusCode == System.Net.HttpStatusCode.BadRequest)
                    {
                        MessageBox.Show("Error: Adding Ticket Type Failed Because Of Input");
                    }
                    else { MessageBox.Show("Internal Server Error"); }
                }
            }
        }
    }
}
