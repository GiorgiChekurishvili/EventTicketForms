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
    public partial class EventModifier : Form
    {
        private readonly string _eventByIdUrl = "http://localhost:5172/api/Event/eventsbyid/";
        private readonly string _favoriteEventUrl = "http://localhost:5172/api/Favorite/favoriteevent/";
        private int _eventId;
        public EventModifier(int eventId)
        {
            InitializeComponent();
            _eventId = eventId;
            FillEventInfo();
        }

        public async void FillEventInfo()
        {
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage response = await client.GetAsync(_eventByIdUrl + _eventId))
                {
                    if (Convert.ToInt32(response.StatusCode) == 200)
                    {
                        using (HttpContent content = response.Content)
                        {
                            var json = await content.ReadAsStringAsync();
                            var data = JsonConvert.DeserializeObject<EventsDto>(json);
                            txtEventName.Text = data.EventName;
                            txtCapacity.Text = data.Capacity.ToString();
                            txtDate.Text = data.EventDate.ToString();
                            txtDescription.Text = data.EventDescription;
                            txtEventLocation.Text = data.EventLocation;
                            label7.Text = data.Id.ToString();

                        }
                    }
                    else if (Convert.ToInt32(response.StatusCode) == 404)
                    {
                        MessageBox.Show("Not Found");
                    }
                    else { MessageBox.Show("Internal Server Error"); }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EventModifier_Load(object sender, EventArgs e)
        {
            if (TokenManager.Token == "" || TokenManager.Token == null)
            {
                btnBuyTicket.Visible = false;
                btnAddFavorites.Visible = false;
            }
        }

        private void btnBuyTicket_Click(object sender, EventArgs e)
        {

        }

        private async void btnAddFavorites_Click(object sender, EventArgs e)
        {
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", TokenManager.Token);
                
                var json = JsonConvert.SerializeObject(label7.Text);
                var input = new StringContent(json, Encoding.UTF8, "application/json");

                using (HttpResponseMessage response = await client.PostAsync(_favoriteEventUrl + int.Parse(label7.Text), input))
                {
                    if (Convert.ToInt32(response.StatusCode) == 200)
                    {
                        MessageBox.Show("Successfully Added To Your Favorites");
                    }
                    else { MessageBox.Show("Internal Server Error"); }
                }
            }
        }
    }
}
