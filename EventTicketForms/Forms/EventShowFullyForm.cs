using EventTicketForms.Resources;
using Microsoft.AspNetCore.Mvc.Diagnostics;
using Microsoft.Extensions.Logging;
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
    public partial class EventShowFullyForm : Form
    {
        private readonly string _getImageByEventId = "http://localhost:5172/api/Images/RetrieveImage/";
        private readonly string _getallcategories = "http://localhost:5172/api/Event/eventcategories";

        private readonly string _eventByIdUrl = "http://localhost:5172/api/Event/eventsbyid/";
        private readonly string _favoriteEventUrl = "http://localhost:5172/api/Favorite/favoriteevent/";

        private readonly string _deleteEventUrl = "http://localhost:5172/api/Event/deleteevent/";
        private readonly string _updateEventUrl = "http://localhost:5172/api/Event/updateevent/";

        private int _eventId;
        public EventShowFullyForm(int eventId)
        {
            InitializeComponent();
            _eventId = eventId;
            FillEventInfo();
            FillComboBox();
            FillImage();
        }

        public async void FillImage()
        {
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage response = await client.GetAsync(_getImageByEventId + _eventId))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        using (HttpContent content = response.Content)
                        {
                            byte[] imagedata = await content.ReadAsByteArrayAsync();
                            using (var stream = new System.IO.MemoryStream(imagedata))
                            {
                                pictureBox1.Image = System.Drawing.Image.FromStream(stream);
                            }

                        }
                    }
                    else
                    {
                        pictureBox1.Image = null;
                    }

                }
            }
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
                            dateForEvent.Text = data.EventDate.ToString("yyyy-MM-dd");
                            TimeForEvent.Text = data.EventDate.ToString("HH:mm:ss");
                            txtDescription.Text = data.EventDescription;
                            txtEventLocation.Text = data.EventLocation;
                            lblid.Text = data.Id.ToString();

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
        private async void FillComboBox()
        {
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage response = await client.GetAsync(_getallcategories))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        using (HttpContent content = response.Content)
                        {
                            var json = await content.ReadAsStringAsync();
                            var data = JsonConvert.DeserializeObject<List<Categories>>(json);
                            comboBoxCategories.ValueMember = "Id";
                            comboBoxCategories.DisplayMember = "Name";
                            comboBoxCategories.DataSource = data;

                        }
                    }
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EventModifier_Load(object sender, EventArgs e)
        {
            if (StaticResources.Token == "" || StaticResources.Token == null)
            {
                btnBuyTicket.Visible = false;
                btnAddFavorites.Visible = false;
            }
            if (StaticResources.Role == "admin")
            {
                txtEventName.ReadOnly = false;
                txtEventLocation.ReadOnly = false;
                txtDescription.ReadOnly = false;
                dateForEvent.Enabled = true;
                TimeForEvent.Enabled = true;
                txtCapacity.ReadOnly = false;
                btnDelete.Visible = true;
                btnUpdate.Visible = true;
                btnAddFavorites.Visible = false;
                btnBuyTicket.Visible = false;
                button2.Visible = true;
            }
        }

        private void btnBuyTicket_Click(object sender, EventArgs e)
        {
            BuyTicketForm buyTicketForm = new BuyTicketForm(_eventId, txtEventName.Text);
            buyTicketForm.ShowDialog();
        }

        private async void btnAddFavorites_Click(object sender, EventArgs e)
        {
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", StaticResources.Token);

                var json = JsonConvert.SerializeObject(lblid.Text);
                var input = new StringContent(json, Encoding.UTF8, "application/json");

                using (HttpResponseMessage response = await client.PostAsync(_favoriteEventUrl + int.Parse(lblid.Text), input))
                {
                    if (Convert.ToInt32(response.StatusCode) == 200)
                    {
                        MessageBox.Show("Successfully Added To Your Favorites");
                    }
                    else if (Convert.ToInt32(response.StatusCode) == 400)
                    {
                        MessageBox.Show("This event is already in your favorites");
                    }
                    else { MessageBox.Show("Internal Server Error"); }
                }
            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", StaticResources.Token);
                using (HttpResponseMessage response = await client.DeleteAsync(_deleteEventUrl + lblid.Text))
                {

                    if (Convert.ToInt32(response.StatusCode) == 200)
                    {
                        MessageBox.Show("Event Successfully Has Been Deleted");
                    }
                    else if (Convert.ToInt32(response.StatusCode) == 500)
                    {
                        MessageBox.Show("Internal Server Error");
                    }
                }
            }
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            using (HttpClient client = new HttpClient())
            {
                var date = Convert.ToDateTime($"{dateForEvent.Text} {TimeForEvent.Text}");

                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", StaticResources.Token);
                AddEventDto eventDto = new AddEventDto()
                {
                    EventName = txtEventName.Text,
                    EventDescription = txtDescription.Text,
                    EventDate = date,
                    EventLocation = txtEventLocation.Text,
                    Capacity = int.Parse(txtCapacity.Text),
                    CategoryId = Convert.ToInt32(comboBoxCategories.SelectedValue)
                };
                var json = JsonConvert.SerializeObject(eventDto);
                var input = new StringContent(json, Encoding.UTF8, "application/json");
                using (HttpResponseMessage response = await client.PutAsync(_updateEventUrl + lblid.Text, input))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Database Updated");
                    }
                    else if (Convert.ToInt32(response.StatusCode) == 400)
                    {
                        MessageBox.Show("date for this event is incorrect");
                    }
                    else if (Convert.ToInt32(response.StatusCode) == 403)
                    {
                        MessageBox.Show("capacity cant be less than 0 ");
                    }
                    else
                    {
                        MessageBox.Show("Internal Server Error");
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TicketTypeForm ticketTypeForm = new TicketTypeForm(_eventId, txtEventName.Text);
            ticketTypeForm.Show();
        }
    }
}
