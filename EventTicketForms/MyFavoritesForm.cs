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
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventTicketForms
{
    public partial class MyFavoritesForm : Form
    {
        private readonly string viewFavorites = "http://localhost:5172/api/Favorite/viewmyfavorites";
        private readonly string removeFavorites = "http://localhost:5172/api/Favorite/unfavoriteevent/";
        private string _token;
        List<EventsDto> _events = new List<EventsDto>();
        public MyFavoritesForm()
        {
            InitializeComponent();
            _token = TokenManager.Token;
            ViewMyFavorites();
        }
        private async void ViewMyFavorites()
        {
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _token);
                using (HttpResponseMessage response = await client.GetAsync(viewFavorites))
                {
                    if (Convert.ToInt32(response.StatusCode) == 401)
                    {
                        MessageBox.Show("Unauthorized");
                    }
                    if (Convert.ToInt32(response.StatusCode) == 200)
                    {
                        using (HttpContent content = response.Content)
                        {
                            var data = await content.ReadAsStringAsync();
                            var json = JsonConvert.DeserializeObject<List<EventsDto>>(data);
                            dataGridForFavorites.DataSource = null;
                            if (json != null)
                            {
                                dataGridForFavorites.DataSource = json;
                                dataGridForFavorites.DefaultCellStyle.ForeColor = Color.Black;
                                dataGridForFavorites.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                                PopulateEventsList();
                            }
                        }
                    }
                }
            }
        }
        private void MyFavoritesForm_Load(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string filterText = txtSearch.Text.ToLower();

            if (string.IsNullOrEmpty(filterText))
            {
                dataGridForFavorites.DataSource = _events;
            }
            if (dataGridForFavorites.DataSource is List<EventsDto> events)
            {
                var filteredEvents = events.Where(e => e.EventName.ToLower().Contains(filterText)).ToList();
                dataGridForFavorites.DataSource = filteredEvents;
            }
        }
        private void PopulateEventsList()
        {
            _events.Clear();
            for (int i = 0; i < dataGridForFavorites.Rows.Count; i++)
            {
                DataGridViewRow row = dataGridForFavorites.Rows[i];
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

        private async void dataGridForFavorites_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            var user = _events[index];
            int favoritesId = user.Id;
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _token);
                using (HttpResponseMessage response = await client.DeleteAsync(removeFavorites + favoritesId))
                {
                    if (Convert.ToInt32(response.StatusCode) == 401)
                    {
                        MessageBox.Show("Unauthorized");
                    }
                    else if (Convert.ToInt32(response.StatusCode) == 200)
                    {
                        MessageBox.Show("Successfully removed");
                        ViewMyFavorites();
                    }
                }
            }
        }
    }
}
