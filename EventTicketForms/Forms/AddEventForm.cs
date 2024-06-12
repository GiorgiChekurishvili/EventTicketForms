using EventTicketForms.Forms;
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
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventTicketForms
{
    public partial class AddEventForm : Form
    {
        private readonly string _addEvent = "http://localhost:5172/api/Event/publishevent";
        private readonly string _getallcategories = "http://localhost:5172/api/Event/eventcategories";
        public AddEventForm()
        {
            InitializeComponent();
            FillComboBox();
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

        private async void btnAddTicket_Click(object sender, EventArgs e)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", StaticResources.Token);
                    AddEventDto addEvent = new AddEventDto()
                    {
                        EventName = txtEventName.Text,
                        EventDescription = txtDescription.Text,
                        Capacity = int.Parse(txtCapacity.Text),
                        EventDate = Convert.ToDateTime($"{dateOfEvent.Text} {TimeOfEvent.Text}"),
                        CategoryId = Convert.ToInt32(comboBoxCategories.SelectedValue),
                        EventLocation = txtEventLocation.Text

                    };
                    var json = JsonConvert.SerializeObject(addEvent);
                    var input = new StringContent(json, Encoding.UTF8, "application/json");
                    using (HttpResponseMessage response = await client.PostAsync(_addEvent, input))
                    {
                        if (Convert.ToInt32(response.StatusCode) == 409)
                        {
                            MessageBox.Show("Datetime is incorrect");
                        }
                        else if (Convert.ToInt32(response.StatusCode) == 200)
                        {
                            MessageBox.Show("Event Successfully Has Been Added");
                        }
                        else if (Convert.ToInt32(response.StatusCode) == 400)
                        {
                            MessageBox.Show("Event's Name Already Exists");
                        }
                        else if (Convert.ToInt32(response.StatusCode) == 403)
                        {
                            MessageBox.Show("Capacity Must Be Greater Than 0");
                        }
                        else
                        {
                            MessageBox.Show("Internal Server Error");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: input is not valid");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void comboBoxCategories_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddEventForm_Load(object sender, EventArgs e)
        {

        }

        private void btnImage_Click(object sender, EventArgs e)
        {
            ImageUploadForm imageUploadForm = new ImageUploadForm();
            imageUploadForm.ShowDialog();
        }
    }
}
