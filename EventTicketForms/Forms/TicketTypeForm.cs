using EventTicketForms.Resources;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EventTicketForms
{
    public partial class TicketTypeForm : Form
    {
        private readonly string _getTicketTypesUrl = "http://localhost:5172/api/TicketType/seetickettypes/";
        private readonly string _deleteTicketTypeUrl = "http://localhost:5172/api/TicketType/removetickettype/";
        private readonly string _updateTicketTypeUrl = "http://localhost:5172/api/TicketType/changeeventtype/";


        List<TicketTypesDto> _ticketTypes = new List<TicketTypesDto>();
        private int _eventId;
        private string _eventName;
        private int _ticketTypeId;
        public TicketTypeForm(int eventId, string eventName)
        {
            InitializeComponent();
            _eventId = eventId;
            _eventName = eventName;
            ShowTicketTypes();
           
        }

        private async void ShowTicketTypes()
        {
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage response = await client.GetAsync(_getTicketTypesUrl + _eventId))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        using (HttpContent content = response.Content)
                        {
                            var json = await content.ReadAsStringAsync();
                            _ticketTypes = JsonConvert.DeserializeObject<List<TicketTypesDto>>(json);
                            if (_ticketTypes.Count == 0)
                            {
                                MessageBox.Show("There is no ticket types for this event, please add it");
                                button1.Visible = false;
                                button3.Visible = false;
                                return;

                            }
                            comboBoxTicketType.ValueMember = "Id";
                            comboBoxTicketType.DisplayMember = "TicketTypeName";
                            comboBoxTicketType.DataSource = _ticketTypes;
                            button1.Visible = true;
                            button3.Visible = true;
                        }
                    }
                    else if (Convert.ToInt32(response.StatusCode) == 404)
                    {
                        MessageBox.Show("There is no ticket types for this event, please add it");
                    }
                    else { MessageBox.Show("internal server error"); }
                }
            }
        }

        private void TicketTypeForm_Load(object sender, EventArgs e)
        {

        }

        private void comboBoxTicketType_SelectedIndexChanged(object sender, EventArgs e)
        {
            _ticketTypeId = Convert.ToInt32(comboBoxTicketType.SelectedValue);
            txtEventName.Text = _eventName;
            try
            {


                txtPrice.Text = _ticketTypes.FirstOrDefault(x => x.Id == _ticketTypeId).Price.ToString();
                txtTotalTickets.Text = _ticketTypes.FirstOrDefault(x => x.Id == _ticketTypeId).TotalTickets.ToString();
                txtTicketsLeft.Text = _ticketTypes.FirstOrDefault(x => x.Id == _ticketTypeId).TicketsAvailable.ToString();
                dateForSalesStart.Text = _ticketTypes.FirstOrDefault(x => x.Id == _ticketTypeId).SalesStartDate.ToString("yyyy-MM-dd");
                TimeForSalesStart.Text = _ticketTypes.FirstOrDefault(x => x.Id == _ticketTypeId).SalesStartDate.ToString("HH:mm:ss");
                DateForSalesEnd.Text = _ticketTypes.FirstOrDefault(x => x.Id == _ticketTypeId).SalesEndDate.ToString("yyyy-MM-dd");
                TimeForSalesEnd.Text = _ticketTypes.FirstOrDefault(x => x.Id == _ticketTypeId).SalesEndDate.ToString("HH:mm:ss");
            }
            catch { }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", StaticResources.Token);
                //var tickettypeId = _ticketTypes.FirstOrDefault(x => x.Id == Convert.ToInt32(comboBoxTicketType.SelectedValue));
                using (HttpResponseMessage response = await client.DeleteAsync(_deleteTicketTypeUrl + _ticketTypeId + "/" + _eventId))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Successfully deleted ticket type");
                        ShowTicketTypes();
                    }
                    else { MessageBox.Show("Internal server error"); }
                }
            }
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", StaticResources.Token);

                UpdateTicketTypeProperties ticketTypesDto = new UpdateTicketTypeProperties()
                {
                    EventId = _eventId,
                    TicketTypeName = comboBoxTicketType.Text,
                    Price = Convert.ToDecimal(txtPrice.Text),
                    TotalTickets = int.Parse(txtTotalTickets.Text),
                    SalesEndDate = Convert.ToDateTime($"{DateForSalesEnd.Text} {TimeForSalesEnd.Text}"),
                    SalesStartDate = Convert.ToDateTime($"{dateForSalesStart.Text} {TimeForSalesStart.Text}")
            };
                var json = JsonConvert.SerializeObject(ticketTypesDto);
                var inputdata = new StringContent(json, Encoding.UTF8, "application/json");
                using (HttpResponseMessage response = await client.PutAsync(_updateTicketTypeUrl + _ticketTypeId, inputdata))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Successfully Updated Data");
                        ShowTicketTypes();
                    }
                    else { MessageBox.Show("Internal Server Error"); }
                }
            }
        }
    }
}
