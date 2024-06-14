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
        List<BoughtTicketsDto> _boughtTickets = new List<BoughtTicketsDto>();
        public BoughtTicketsForm()
        {
            InitializeComponent();
            _token = StaticResources.Token;
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
                            if ( data!= null)
                            {
                                dataGridForBoughtTickets.DataSource = data;
                                dataGridForBoughtTickets.DefaultCellStyle.ForeColor = Color.Black;
                                dataGridForBoughtTickets.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                                PopulateBoughtTicketsList();
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
        private void PopulateBoughtTicketsList()
        {
            _boughtTickets.Clear();
            for (int i = 0; i < dataGridForBoughtTickets.Rows.Count; i++)
            {
                DataGridViewRow row = dataGridForBoughtTickets.Rows[i];
                if (!row.IsNewRow)
                {
                    int id = int.Parse(row.Cells["Id"].Value.ToString());
                    string eventId = row.Cells["generatedEventId"].Value.ToString();
                    string eventName = row.Cells["EventName"].Value.ToString();
                    string tickettypename = row.Cells["TicketTypeName"].Value.ToString();
                    int ticketquantity = int.Parse(row.Cells["TicketQuantity"].Value.ToString());
                    decimal totalprice = Convert.ToDecimal(row.Cells["TotalPrice"].Value.ToString());
                    DateTime purchasedate = Convert.ToDateTime(row.Cells["PurchaseDate"].Value);

                    _boughtTickets.Add(new BoughtTicketsDto
                    {
                        Id = id,
                        GeneratedEventId = eventId,
                        EventName = eventName,
                        TicketTypeName = tickettypename,
                        TicketQuantity = ticketquantity,
                        TotalPrice = totalprice,
                        PurchaseDate = purchasedate
                    });
                }
            }
        }
        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            string filterText = txtFilter.Text.ToLower();

            if (string.IsNullOrEmpty(filterText))
            {
                dataGridForBoughtTickets.DataSource = _boughtTickets;
            }
            if (dataGridForBoughtTickets.DataSource is List<BoughtTicketsDto> events)
            {
                var filteredEvents = events.Where(e => e.EventName.ToLower().Contains(filterText)).ToList();
                dataGridForBoughtTickets.DataSource = filteredEvents;
            }
        }

        private void dataGridForBoughtTickets_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show("Click only on event");
            }
        }

        private void BoughtTicketsForm_Load(object sender, EventArgs e)
        {

        }
    }
}
