using EventTicketForms.Entities;
using EventTicketForms.Resources;
using EventTicketForms.Services;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace EventTicketForms
{
    public partial class Authentication : Form
    {
        private MainForm _mainform;
        public Authentication(MainForm mainForm)
        {
            InitializeComponent();
            _mainform = mainForm;
        }



        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pnName.Visible = pnLastName.Visible = pnEmail.Visible = pnPassword.Visible = pnConfirmPassword.Visible = false;
        }



        private async void button3_Click(object sender, EventArgs e)
        {
            if (txtFirstName.Text == "" || txtLastName.Text == "" || txtEmailAddress.Text == "" || txtPassword.Text == "" || txtConfirmPassword.Text == "")
            {
                if (txtFirstName.Text == "")
                {
                    pnName.Visible = true;
                }
                if (txtLastName.Text == "")
                {
                    pnLastName.Visible = true;
                }
                if (txtEmailAddress.Text == "")
                {
                    pnEmail.Visible = true;
                }
                if (txtPassword.Text == "")
                {
                    pnPassword.Visible = true;
                }
                if (txtConfirmPassword.Text == "")
                {
                    pnConfirmPassword.Visible = true;
                }
            }
            else
            {
                RegisterEntity register = new()
                {
                    Name = txtFirstName.Text,
                    LastName = txtLastName.Text,
                    Email = txtEmailAddress.Text,
                    Password = txtPassword.Text,
                    ConfirmPassword = txtConfirmPassword.Text,
                };
                AuthenticationHelper authentication = new AuthenticationHelper();
                await authentication.Register(register);

            }


        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            txtEmailAddress.Clear();
            txtPassword.Clear();
            txtConfirmPassword.Clear();
            pnlRegister.Visible = false;
            pnlLogo.Dock = DockStyle.Left;
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pnlRegister.Visible = true;
            pnlRegister.Dock = DockStyle.Fill;
            pnlLogo.Dock = DockStyle.Right;
        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            if (txtKey.Text == "")
            {
                pnlKey.Visible = true;

            }
            else
            {
                AuthenticationHelper authentication = new AuthenticationHelper();
                var statuscode = authentication.VerifyAccount(txtKey.Text);

            }
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtKey.Clear();
            pnlVerify.Visible = false;
            pnlRegister.Visible = false;
            pnlLogo.Dock = DockStyle.Left;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtForgotPasswordKey.Text == "" || txtNewPassword.Text == "" || txtForgotPasswordConfirm.Text == "")
            {
                if (txtForgotPasswordKey.Text == "")
                {
                    pnlForgotPasswordKey.Visible = true;
                }
                if (txtNewPassword.Text == "")
                {
                    pnlNewPassword.Visible = true;
                }
                if (txtForgotPasswordConfirm.Text == "")
                {
                    pnlForgotPasswordConfirm.Visible = true;
                }
            }
            else
            {
                AuthenticationHelper authentication = new AuthenticationHelper();
                ChangePasswordProperties registerEntity = new ChangePasswordProperties()
                {
                    Token = txtForgotPasswordKey.Text,
                    Password = txtNewPassword.Text,
                    ConfirmPassword = txtForgotPasswordConfirm.Text,
                };
                authentication.ChangePassword(registerEntity);

            }

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pnlForgetPassword.Visible = true;
            pnlForgetPassword.Dock = DockStyle.Fill;
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pnlChangePassword.Visible = false;
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            AuthenticationHelper authentication = new AuthenticationHelper();
            var response = await authentication.Login(txtLoginEmail.Text, txtLoginPassword.Text);
            if (response == null)
            {
                MessageBox.Show("Invalid Email Address or Password or Account isnt verified");

            }
            else
            {
                TokenManager.Token = response;
                this.Hide();
                _mainform.CheckIfUserLogin();


            }


        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkLabel7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            txtEmailAddress.Clear();
            txtPassword.Clear();
            txtConfirmPassword.Clear();
            pnlRegister.Visible = false;
            pnlVerify.Visible = true;
            pnlVerify.Dock = DockStyle.Fill;
        }

        private async void btnForgetPasswordSend_Click(object sender, EventArgs e)
        {
            if (txtForgetPasswordEmail.Text == "")
            {
                panel32.Visible = true;
            }
            else
            {
                AuthenticationHelper authentication = new AuthenticationHelper();
                var statuscode = await authentication.ForgetPassword(txtForgetPasswordEmail.Text);
                if (Convert.ToInt32(statuscode) == 200)
                {
                    pnlForgetPassword.Visible = false;
                    pnlForgetPassword.Dock = DockStyle.None;
                    pnlChangePassword.Visible = true;
                    pnlChangePassword.Dock = DockStyle.Fill;
                }


            }
        }

        private void linkLabel8_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pnlForgetPassword.Visible = false;
            pnlForgetPassword.Dock = DockStyle.None;
        }

        private void linkLabel6_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pnlForgetPassword.Visible = false;
            pnlForgetPassword.Dock = DockStyle.None;
            pnlChangePassword.Visible = true;
            pnlChangePassword.Dock = DockStyle.Fill;
        }

        private void pnlLogin_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

