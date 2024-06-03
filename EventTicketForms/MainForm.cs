using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventTicketForms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private Form activeform = null;
        public void openChildForm(Form childform)
        {
            if (activeform != null)
            {
                activeform.Close();
            }
            activeform = childform;
            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            pnlChild.Controls.Add(childform);
            pnlChild.Tag = childform;
            childform.BringToFront();
            childform.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnEvents_Click(object sender, EventArgs e)
        {
            if (pnlSubEvents.Visible == true)
            {
                pnlSubEvents.Visible = false;
            }
            else
            {
                pnlSubEvents.Visible = true;
            }
        }

        private void btnSports_Click(object sender, EventArgs e)
        {

        }

        private void btnComedy_Click(object sender, EventArgs e)
        {

        }

        private void btnTheatre_Click(object sender, EventArgs e)
        {

        }

        private void btnOpera_Click(object sender, EventArgs e)
        {

        }

        private void btnCircus_Click(object sender, EventArgs e)
        {

        }

        private void btnConcerts_Click(object sender, EventArgs e)
        {

        }

        private void btnMovies_Click(object sender, EventArgs e)
        {

        }

        private void btnKids_Click(object sender, EventArgs e)
        {

        }

        private void btnOthers_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Authentication authentication = new Authentication();
            authentication.Show();
            authentication.FormClosed += (s, args) => this.Close();
        }
    }
}
