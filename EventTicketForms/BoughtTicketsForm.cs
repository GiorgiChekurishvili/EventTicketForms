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

namespace EventTicketForms
{
    public partial class BoughtTicketsForm : Form
    {
        private readonly string myTickets = "http://localhost:5172/api/Ticket/viewmytickets";
        private string _token;
        List<EventsDto> _events = new List<EventsDto>();
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
                            var json = await content.ReadAsStringAsync();
                            var data = JsonConvert.DeserializeObject<List<BoughtTicketsDto>>(json);
                            dataGridForBoughtTickets.DataSource = null;
                            if (data != null)
                            {
                                dataGridForBoughtTickets.DataSource = data;
                                dataGridForBoughtTickets.DefaultCellStyle.ForeColor = Color.Black;
                                dataGridForBoughtTickets.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                            }
                            else
                            {
                                MessageBox.Show("You Havent Bought Any Tickets");
                            }



                        }
                    }
                    else { MessageBox.Show("Error"); }
                }
            }
        }
        private void PopulateEventsList()
        {
            _events.Clear();
            for (int i = 0; i < dataGridForBoughtTickets.Rows.Count; i++)
            {
                DataGridViewRow row = dataGridForBoughtTickets.Rows[i];
                if (!row.IsNewRow)
                {
                    int id = int.Parse(row.Cells["Id"].Value.ToString());
                    string eventName = row.Cells["EventName"].Value.ToString();
                    string eventDescription = row.Cells["EventDescription"].Value.ToString();
                    string eventLocation = row.Cells["EventLocation"].Value.ToString();
                    int eventCapacity = int.Parse(row.Cells["Capacity"].Value.ToString());
                    DateTime eventDate = Convert.ToDateTime(row.Cells["EventDate"].Value);

                    _events.Add(new EventsDto
                    {
                        Id = id,
                        EventName = eventName,
                        EventDescription = eventDescription,
                        EventLocation = eventLocation,
                        Capacity = eventCapacity,
                        EventDate = eventDate
                    });
                }
            }
        }
        private void txtFilter_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridForBoughtTickets_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
