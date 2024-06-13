using EventTicketForms.Models;
using EventTicketForms.Resources;
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
    public partial class TransactionsForm : Form
    {
        private readonly string ViewMyBalanceUrl = "http://localhost:5172/api/Transaction/viewmybalance";
        private readonly string ViewMyTransactionsUrl = "http://localhost:5172/api/Transaction/viewmytransactions";
        public TransactionsForm()
        {
            InitializeComponent();
            FillDataGrid();
            SeeMyBalance();
        }
        private async void SeeMyBalance()
        {
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", StaticResources.Token);
                using (HttpResponseMessage response = await client.GetAsync(ViewMyBalanceUrl))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        using (HttpContent content = response.Content)
                        {
                            var json = await content.ReadAsStringAsync();
                            decimal data = JsonConvert.DeserializeObject<decimal>(json);
                            lblBalance.Text = $"{data} GEL";
                        }
                    }
                    else
                    {
                        MessageBox.Show("Internal Server Error");
                    }
                }
            }
        }
        private async void FillDataGrid()
        {
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", StaticResources.Token);
                using (HttpResponseMessage response = await client.GetAsync(ViewMyTransactionsUrl))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        using (HttpContent content = response.Content)
                        {
                            var json = await content.ReadAsStringAsync();
                            var data = JsonConvert.DeserializeObject<List<ViewMyTransactions>>(json);

                            dataGridView1.DataSource = data;
                            dataGridView1.DefaultCellStyle.ForeColor = Color.Black;
                            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                        }
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
            this.Close();
        }

        private void TransactionsForm_Load(object sender, EventArgs e)
        {

        }

        private void btnAddFunds_Click(object sender, EventArgs e)
        {
            AddFundsForm addFundsForm = new AddFundsForm();
            addFundsForm.Show();
            addFundsForm.FormClosed += btnAddFunds_FormClosed;
        }
        private void btnAddFunds_FormClosed(object sender, FormClosedEventArgs e)
        {
            FillDataGrid();
            SeeMyBalance();
        }

    }
}
