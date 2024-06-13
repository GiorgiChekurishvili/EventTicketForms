using EventTicketForms.Resources;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventTicketForms.Forms
{
    public partial class AddFundsForm : Form
    {
        private readonly string MakeTransaction = "http://localhost:5172/api/Transaction/maketransaction/";
        public AddFundsForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnAddFunds_Click(object sender, EventArgs e)
        {
            if (txtCreditCardNumber.Text == "" || txtCreditCardNumber == null)
            {
                MessageBox.Show("Credit Card Number isn't filled");
                return;
            }
            if (txtCVC.Text == "" || txtCVC == null)
            {
                MessageBox.Show("CVC isn't filled");
                return;
            }
            if (txtValidThru.Text == "" || txtValidThru == null)
            {
                MessageBox.Show("Valid Thru isn't filled");
                return;
            }
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", StaticResources.Token);
                decimal amount = Decimal.Parse(txtAmount.Text);
                var json = JsonConvert.SerializeObject(amount);
                var input = new StringContent(json, Encoding.UTF8, "application/json");
                using (HttpResponseMessage response = await client.PostAsync(MakeTransaction + amount, input))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show($"{amount} GEL has been added to your account");
                    }
                    else if (response.StatusCode == System.Net.HttpStatusCode.BadRequest)
                    {
                        MessageBox.Show("Failed to add cash to your account");
                    }
                    else { MessageBox.Show("Internal Server Error"); }
                }
            }

        }


        private void txtValidThru_TextChanged(object sender, EventArgs e)
        {
            if (txtValidThru.Text.Length == 2 && !txtValidThru.Text.Contains("/"))
            {
                txtValidThru.Text += "/";
                txtValidThru.SelectionStart = txtValidThru.Text.Length;
            }
        }

        private void txtCreditCardNumber_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
