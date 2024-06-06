using EventTicketForms.Resources;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace EventTicketForms
{
    public partial class BuyTicketForm : Form
    {
        private readonly string _getTicketTypesUrl = "http://localhost:5172/api/TicketType/seetickettypes/";
        private readonly string _buyTicketUrl = "http://localhost:5172/api/Ticket/buyticket/";
        private int _eventId;
        private string _eventName;
        List<TicketTypesDto> _data = new List<TicketTypesDto>();
        private decimal numberOfTickets;
        public BuyTicketForm(int eventId, string eventName)
        {
            InitializeComponent();
            _eventId = eventId;
            _eventName = eventName;
            ShowTicketTypes();
        }
        private async Task ShowTicketTypes()
        {
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", TokenManager.Token);
                using (HttpResponseMessage response = await client.GetAsync(_getTicketTypesUrl + _eventId))
                {
                    if (Convert.ToInt32(response.StatusCode) == 200)
                    {
                        using (HttpContent content = response.Content)
                        {
                            var json = await content.ReadAsStringAsync();
                            _data = JsonConvert.DeserializeObject<List<TicketTypesDto>>(json);
                            comboboxTicketType.ValueMember = "Id";
                            comboboxTicketType.DisplayMember = "TicketTypeName";
                            comboboxTicketType.DataSource = _data;
                           
                        }
                    }
                    else { MessageBox.Show("Internal Server Error"); }
                }
            }
        }

        private void BuyTicketForm_Load(object sender, EventArgs e)
        {
            lblEventName.Text += _eventName;
            

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

            numberOfTickets = numTicketsQuantity.Value;
            decimal totalPrice = numberOfTickets * Convert.ToDecimal(lblPrice.Text);

            lblTotalPrice.Text = totalPrice.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnBuyTicket_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
               "Are you sure you want to buy this ticket?",
               "Confirm Purchase",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Question
           );

            if (result == DialogResult.Yes)
            {
               
                int selectedId = Convert.ToInt32(comboboxTicketType.SelectedValue);
                var inputdata = new
                {
                    _eventId,
                    selectedId,
                    numberOfTickets

                };
                var json = JsonConvert.SerializeObject(inputdata);
                var input = new StringContent(json, Encoding.UTF8, "application/json");
                using (HttpClient client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", TokenManager.Token);
                    using (HttpResponseMessage response = await client.PostAsync($"{_buyTicketUrl}{_eventId}/{selectedId}/{numberOfTickets}",input ))
                    {
                        if (Convert.ToInt32(response.StatusCode) == 200)
                        {
                            MessageBox.Show("You have bought the ticket. Check your email or the tab 'BoughtTickets'", "Purchase Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else if(Convert.ToInt32(response.StatusCode) == 400)
                        {
                            MessageBox.Show("Ticket can't be bought");
                        }
                        else { MessageBox.Show("Internal Server Error"); }
                    }
                }
                
            }
            else
            {
                MessageBox.Show("Purchase canceled.", "Purchase Canceled", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtTicketType_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedId = Convert.ToInt32(comboboxTicketType.SelectedValue);
            numTicketsQuantity.Maximum = _data.FirstOrDefault(x => x.Id == selectedId).TicketsAvailable;
            lblPrice.Text = _data.FirstOrDefault(x => x.Id == selectedId).Price.ToString();
            txtStartDate.Text = _data.FirstOrDefault(x => x.Id == selectedId).SalesStartDate.ToString();
            txtEndDate.Text = _data.FirstOrDefault(x => x.Id == selectedId).SalesEndDate.ToString();
            

            decimal totalPrice = numberOfTickets * Convert.ToDecimal(lblPrice.Text);

            lblTotalPrice.Text = totalPrice.ToString();
        }
    }
}
