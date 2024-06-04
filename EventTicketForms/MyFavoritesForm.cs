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
        private string _token;
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
                            }
                        }
                    }
                }
            }
        }
        private void MyFavoritesForm_Load(object sender, EventArgs e)
        {

        }
    }
}
