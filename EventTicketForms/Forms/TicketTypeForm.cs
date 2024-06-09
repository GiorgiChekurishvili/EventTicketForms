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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace EventTicketForms
{
    public partial class TicketTypeForm : Form
    {
        private readonly string _getTicketTypesUrl = "http://localhost:5172/api/TicketType/seetickettypes/";
        List<TicketTypesDto> _ticketTypes = new List<TicketTypesDto>();
        private int _eventId;
        private string _eventName;
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
                            comboBoxTicketType.ValueMember = "Id";
                            comboBoxTicketType.DisplayMember = "TicketTypeName";
                            comboBoxTicketType.DataSource = _ticketTypes;
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
            int _ticketTypeId = Convert.ToInt32(comboBoxTicketType.SelectedValue);
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
    }
}
