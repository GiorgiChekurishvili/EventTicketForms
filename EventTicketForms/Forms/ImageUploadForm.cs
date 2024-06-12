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

namespace EventTicketForms.Forms
{
    public partial class ImageUploadForm : Form
    {
        private readonly string _getAllEventsUrl = "http://localhost:5172/api/Event/events";
        private readonly string _getImageByEventId = "http://localhost:5172/api/Images/RetrieveImage/";
        private readonly string _UploadImageUrl = "http://localhost:5172/api/Images/UploadImage/";
        private readonly string _deleteImageUrl = "http://localhost:5172/api/Images/DeleteImage/";
        public ImageUploadForm()
        {
            InitializeComponent();
            FillCombobox();
        }
        private async void FillCombobox()
        {
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage response = await client.GetAsync(_getAllEventsUrl))
                {
                    using (HttpContent content = response.Content)
                    {
                        if (response.IsSuccessStatusCode)
                        {
                            var json = await content.ReadAsStringAsync();
                            var data = JsonConvert.DeserializeObject<List<EventsDto>>(json);
                            comboBoxEvents.ValueMember = "Id";
                            comboBoxEvents.DisplayMember = "EventName";
                            comboBoxEvents.DataSource = data;
                        }
                        else { MessageBox.Show("Internal Server Error"); }
                    }
                }
            }
        }
        private async void comboBoxCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (HttpClient client = new HttpClient())
            {
                int eventid = Convert.ToInt32(comboBoxEvents.SelectedValue);
                using (HttpResponseMessage response = await client.GetAsync(_getImageByEventId + eventid))
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnUpload_Click(object sender, EventArgs e)
        {
            try
            {
                string imagelocation = "";
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "JPEG Files (*.jpg, *.jpeg)|*.jpg;*.jpeg|PNG Files (*.png)|*.png";
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imagelocation = dialog.FileName;
                    pictureBox1.ImageLocation = imagelocation;
                }

                using (HttpClient client = new HttpClient())
                {
                    using (var content = new MultipartFormDataContent())
                    {
                        int eventid = Convert.ToInt32(comboBoxEvents.SelectedValue);
                        byte[] fileBytes = File.ReadAllBytes(imagelocation);
                        ByteArrayContent fileContent = new ByteArrayContent(fileBytes);

                        content.Add(fileContent, "files", Path.GetFileName(imagelocation));

                        content.Add(new StringContent(eventid.ToString()), "eventId");
                        string imageType = Path.GetExtension(imagelocation).ToLower() == ".jpg" ? "image/jpeg" : "image/png"; ;
                        fileContent.Headers.ContentType = new MediaTypeHeaderValue(imageType);

                        content.Add(fileContent, "files", Path.GetFileName(imagelocation));


                        client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", StaticResources.Token);
                        using (HttpResponseMessage response = await client.PostAsync(_UploadImageUrl + eventid, content))
                        {
                            if (response.StatusCode == System.Net.HttpStatusCode.BadRequest)
                            {
                                MessageBox.Show("No file uploaded.");
                            }
                            if (response.IsSuccessStatusCode)
                            {
                                MessageBox.Show("Image Successfully Added");
                                FillCombobox();
                            }
                            else { MessageBox.Show("Internal Server Error"); }
                        }
                    }
                }
            }
            catch (Exception)
            {

                MessageBox.Show("An Error Occured");
            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", StaticResources.Token);
                int eventid = Convert.ToInt32(comboBoxEvents.SelectedValue);
                using (HttpResponseMessage response = await client.DeleteAsync(_deleteImageUrl + eventid))
                {
                    FillCombobox();
                }
            }
        }

        private void ImageUploadForm_Load(object sender, EventArgs e)
        {

        }
    }
}
