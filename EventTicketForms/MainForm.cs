using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using EventTicketForms.Services;
using EventTicketForms.Resources;
using Newtonsoft.Json;
using System.Linq.Expressions;

namespace EventTicketForms
{
    public partial class MainForm : Form
    {
        List<EventsDto> _events = new List<EventsDto>();
        private string _token;
        public MainForm()
        {
            InitializeComponent();
            FillDataGridAutomatically();
            _token = TokenManager.Token;
            CheckIfUserLogin();
        }
        public void CheckIfUserLogin()
        {
            if (TokenManager.Token != "")
            {
                button3.Visible = false;
                btnLogOut.Visible = true;
                btnFavorites.Visible = true;
                btnBought.Visible = true;
            }
            else
            {
                button3.Visible = true;
                btnLogOut.Visible = false;
                btnFavorites.Visible = false;
                btnBought.Visible = false;
            }

        }
        private void PopulateEventsList()
        {
            _events.Clear();
            for (int i = 0; i < dataGridForEvents.Rows.Count; i++)
            {
                DataGridViewRow row = dataGridForEvents.Rows[i];
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
        public async void FillDataGridAutomatically()
        {
            pnlChild.Visible = true;
            pnlChild.BringToFront();
            EventsShow events = new EventsShow();
            var json = await events.GetAllEvents();
            List<EventsDto>? allEvents = JsonConvert.DeserializeObject<List<EventsDto>>(json);
            dataGridForEvents.DataSource = null;
            if (allEvents != null)
            {
                dataGridForEvents.DataSource = allEvents;
                dataGridForEvents.DefaultCellStyle.ForeColor = Color.Black;
                dataGridForEvents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                PopulateEventsList();




            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private async void btnEvents_Click(object sender, EventArgs e)
        {
            try
            {
                pnlChild.Visible = true;
                pnlChild.BringToFront();
                EventsShow events = new EventsShow();
                var json = await events.GetAllEvents();
                List<EventsDto>? allEvents = JsonConvert.DeserializeObject<List<EventsDto>>(json);
                dataGridForEvents.DataSource = null;
                if (allEvents != null)
                {
                    dataGridForEvents.DataSource = allEvents;
                    dataGridForEvents.DefaultCellStyle.ForeColor = Color.Black;
                    dataGridForEvents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    PopulateEventsList();

                }
                if (pnlSubEvents.Visible == true)
                {
                    pnlSubEvents.Visible = false;
                }
                else
                {
                    pnlSubEvents.Visible = true;
                }
            }
            catch { }
        }

        private async void btnSports_Click(object sender, EventArgs e)
        {
            try
            {
                pnlChild.Visible = true;
                pnlChild.BringToFront();
                EventsShow events = new EventsShow();
                var json = await events.GetAllEventsByCategories(1);
                List<EventsDto>? data = JsonConvert.DeserializeObject<List<EventsDto>>(json);
                dataGridForEvents.DataSource = null;
                if (data != null)
                {
                    dataGridForEvents.DataSource = data;
                    dataGridForEvents.DefaultCellStyle.ForeColor = Color.Black;
                    dataGridForEvents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    PopulateEventsList();

                }
            }
            catch { }

        }

        private async void btnComedy_Click(object sender, EventArgs e)
        {
            try
            {

                pnlChild.Visible = true;
                pnlChild.BringToFront();
                EventsShow events = new EventsShow();
                var json = await events.GetAllEventsByCategories(2);
                List<EventsDto>? data = JsonConvert.DeserializeObject<List<EventsDto>>(json);
                dataGridForEvents.DataSource = null;
                if (data != null)
                {
                    dataGridForEvents.DataSource = data;
                    dataGridForEvents.DefaultCellStyle.ForeColor = Color.Black;
                    dataGridForEvents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    PopulateEventsList();
                }
            }
            catch { }
        }

        private async void btnTheatre_Click(object sender, EventArgs e)
        {
            try
            {

                pnlChild.Visible = true;
                pnlChild.BringToFront();
                EventsShow events = new EventsShow();
                var json = await events.GetAllEventsByCategories(3);
                List<EventsDto>? data = JsonConvert.DeserializeObject<List<EventsDto>>(json);
                dataGridForEvents.DataSource = null;
                if (data != null)
                {
                    dataGridForEvents.DataSource = data;
                    dataGridForEvents.DefaultCellStyle.ForeColor = Color.Black;
                    dataGridForEvents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    PopulateEventsList();
                }
            }
            catch { }
        }

        private async void btnOpera_Click(object sender, EventArgs e)
        {
            try
            {

                pnlChild.Visible = true;
                pnlChild.BringToFront();
                EventsShow events = new EventsShow();
                var json = await events.GetAllEventsByCategories(4);
                List<EventsDto>? data = JsonConvert.DeserializeObject<List<EventsDto>>(json);
                dataGridForEvents.DataSource = null;
                if (data != null)
                {
                    dataGridForEvents.DataSource = data;
                    dataGridForEvents.DefaultCellStyle.ForeColor = Color.Black;
                    dataGridForEvents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    PopulateEventsList();
                }
            }
            catch { }
        }

        private async void btnCircus_Click(object sender, EventArgs e)
        {
            try
            {

                pnlChild.Visible = true;
                pnlChild.BringToFront();
                EventsShow events = new EventsShow();
                var json = await events.GetAllEventsByCategories(5);
                List<EventsDto>? data = JsonConvert.DeserializeObject<List<EventsDto>>(json);
                dataGridForEvents.DataSource = null;
                if (data != null)
                {
                    dataGridForEvents.DataSource = data;
                    dataGridForEvents.DefaultCellStyle.ForeColor = Color.Black;
                    dataGridForEvents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    PopulateEventsList();
                }
            }
            catch { }
        }

        private async void btnConcerts_Click(object sender, EventArgs e)
        {
            try
            {

                pnlChild.Visible = true;
                pnlChild.BringToFront();
                EventsShow events = new EventsShow();
                var json = await events.GetAllEventsByCategories(6);
                List<EventsDto>? data = JsonConvert.DeserializeObject<List<EventsDto>>(json);
                dataGridForEvents.DataSource = null;
                if (data != null)
                {
                    dataGridForEvents.DataSource = data;
                    dataGridForEvents.DefaultCellStyle.ForeColor = Color.Black;
                    dataGridForEvents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    PopulateEventsList();
                }
            }
            catch { }
        }

        private async void btnMovies_Click(object sender, EventArgs e)
        {
            try
            {

                pnlChild.Visible = true;
                pnlChild.BringToFront();
                EventsShow events = new EventsShow();
                var json = await events.GetAllEventsByCategories(7);
                List<EventsDto>? data = JsonConvert.DeserializeObject<List<EventsDto>>(json);
                dataGridForEvents.DataSource = null;
                if (data != null)
                {
                    dataGridForEvents.DataSource = data;
                    dataGridForEvents.DefaultCellStyle.ForeColor = Color.Black;
                    dataGridForEvents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    PopulateEventsList();
                }
            }
            catch { }
        }

        private async void btnKids_Click(object sender, EventArgs e)
        {
            try
            {

                pnlChild.Visible = true;
                pnlChild.BringToFront();
                EventsShow events = new EventsShow();
                var json = await events.GetAllEventsByCategories(8);
                List<EventsDto>? data = JsonConvert.DeserializeObject<List<EventsDto>>(json);
                dataGridForEvents.DataSource = null;
                if (data != null)
                {
                    dataGridForEvents.DataSource = data;
                    dataGridForEvents.DefaultCellStyle.ForeColor = Color.Black;
                    dataGridForEvents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    PopulateEventsList();
                }
            }
            catch { }
        }

        private async void btnOthers_Click(object sender, EventArgs e)
        {
            try
            {

                pnlChild.Visible = true;
                pnlChild.BringToFront();
                EventsShow events = new EventsShow();
                var json = await events.GetAllEventsByCategories(9);
                List<EventsDto>? data = JsonConvert.DeserializeObject<List<EventsDto>>(json);
                dataGridForEvents.DataSource = null;
                if (data != null)
                {
                    dataGridForEvents.DataSource = data;
                    dataGridForEvents.DefaultCellStyle.ForeColor = Color.Black;
                    dataGridForEvents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    PopulateEventsList();
                }
            }
            catch { }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Authentication authentication = new Authentication(this);
            authentication.Show();
            authentication.FormClosed += (s, args) => this.Close();

        }

        private void dataGridForEvents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            string filterText = txtFilter.Text.ToLower();

            if (string.IsNullOrEmpty(filterText))
            {
                dataGridForEvents.DataSource = _events;
            }
            if (dataGridForEvents.DataSource is List<EventsDto> events)
            {
                var filteredEvents = events.Where(e => e.EventName.ToLower().Contains(filterText)).ToList();
                dataGridForEvents.DataSource = filteredEvents;
            }



        }



        private void btnLogOut_Click(object sender, EventArgs e)
        {
            TokenManager.Token = null;
            btnLogOut.Visible = false;
            button3.Visible = true;
            btnBought.Visible = false;
            btnFavorites.Visible = false;

        }

        private void btnFavorites_Click(object sender, EventArgs e)
        {
            OpenChildForm(new MyFavoritesForm());
        }

        private Form _activeform = null;
        private void OpenChildForm(Form childform)
        {
            if (_activeform != null)
            {
                _activeform.Close();
            }
            _activeform = childform;
            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(childform);
            pnlMain.Tag = childform;
            childform.BringToFront();
            childform.Show();
            pnlMain.BringToFront();
            pnlChild.Visible = false;


        }

        private void btnBought_Click(object sender, EventArgs e)
        {
            OpenChildForm(new BoughtTicketsForm());
        }
    }
}
