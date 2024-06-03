using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventTicketForms.Services
{
    internal class EventsShow
    {
        private readonly string eventsUrl = "http://localhost:5172/api/Event/events";
        private readonly string eventsByCategory = "http://localhost:5172/api/Event/eventsbycategory/";
        public async Task<string> GetAllEvents()
        {
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage response = await client.GetAsync(eventsUrl))
                {
                    using (HttpContent content = response.Content)
                    {
                        if (Convert.ToInt32(response.StatusCode) == 500)
                        {
                            MessageBox.Show("Internal Server Error");
                            return null;
                        }
                        else if (Convert.ToInt32(response.StatusCode) == 200)
                        {
                            string data = await content.ReadAsStringAsync();
                            if (data != null)
                            {
                                return data;
                            }
                            else
                            {
                                MessageBox.Show("Data Is Empty");
                                return null;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Error");
                            return null;
                        }
                    }
                }
            }
        }
        public async Task<string> GetAllEventsByCategories(int id)
        {
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage response = await client.GetAsync(eventsByCategory + id.ToString()))
                {
                    using (HttpContent content = response.Content)
                    {
                        if (Convert.ToInt32(response.StatusCode) == 500)
                        {
                            MessageBox.Show("Internal Server Error");
                            return null;
                        }
                        else if (Convert.ToInt32(response.StatusCode) == 200)
                        {
                            string data = await content.ReadAsStringAsync();
                            if (data != null)
                            {
                                return data;
                            }
                            else
                            {
                                MessageBox.Show("Data Is Empty");
                                return null;
                            }
                        }
                        else if(Convert.ToInt32(response.StatusCode) == 404)
                        {
                            MessageBox.Show("Error: Not Found");
                            return null;
                        }
                        else
                        {
                            MessageBox.Show("Error");
                            return null;
                        }
                    }
                }
            }
        }
    }
}
