using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
using EventTicketForms.Entities;
using EventTicketForms.Resources;

namespace EventTicketForms.Services
{
    internal class AuthenticationHelper
    {
        private readonly string loginUrl = "http://localhost:5172/api/Authentication/login";
        private readonly string registerUrl = "http://localhost:5172/api/Authentication/register";
        private readonly string verifyAccountUrl = "http://localhost:5172/api/Authentication/verify";
        private readonly string forgotPasswordUrl = "http://localhost:5172/api/Authentication/forgetpassword";
        private readonly string changePasswordUrl = "http://localhost:5172/api/Authentication/changepassword";
        public async Task<string> Login(string email, string password)
        {
            var inputdata = new
            {
                email,
                password
            };

            var json = JsonConvert.SerializeObject(inputdata);
            var input = new StringContent(json, Encoding.UTF8, "application/json");
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage response = await client.PostAsync(loginUrl, input))
                {
                    using (HttpContent content = response.Content)
                    {
                        string data = await content.ReadAsStringAsync();
                        if (Convert.ToInt32(response.StatusCode) != 200)
                        {
                            return null;
                        }
                        else
                        {
                            
                            return data;
                            
                        }
                    }
                }
            }
        }

        public async Task Register(RegisterEntity register)
        {
            var json = JsonConvert.SerializeObject(register);
            var input = new StringContent(json, Encoding.UTF8, "application/json");
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage response = await client.PostAsync(registerUrl, input))
                {
                    using (HttpContent content = response.Content)
                    {
                        switch (Convert.ToInt32(response.StatusCode))
                        {
                            case 409: MessageBox.Show("User With This Email Address Already Exists"); break;
                            case 400: MessageBox.Show("Invalid Email Address or The Passwords Don't Match"); break;
                            case 200: MessageBox.Show("Successfully Registered, Please Verify"); break;
                            default: MessageBox.Show("Error"); break;
                        }
                    }
                }
            }
        }
        public async Task VerifyAccount(string token)
        {
            var json = JsonConvert.SerializeObject(token);
            var input = new StringContent(json, Encoding.UTF8, "application/json");
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage response = await client.PostAsync($"{verifyAccountUrl}/{token}", input))
                {
                    using (HttpContent content = response.Content)
                    {
                        if (Convert.ToInt32(response.StatusCode) == 401)
                        {
                            MessageBox.Show("Invalid Token");
                        }
                        else if (Convert.ToInt32(response.StatusCode) == 200)
                        {
                            MessageBox.Show("Successfully Verified");
                        }
                        else
                        {
                            MessageBox.Show("Error");
                        }
                    }
                }
            }
            {

            }
        }
        public async Task<int> ForgetPassword(string email)
        {
            var json = JsonConvert.SerializeObject(email);
            var input = new StringContent(json, Encoding.UTF8, "application/json");
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage response = await client.PostAsync($"{forgotPasswordUrl}/{email}", input))
                {
                    using (HttpContent content = response.Content)
                    {
                        if (Convert.ToInt32(response.StatusCode) == 400)
                        {
                            MessageBox.Show("Email Address Isnt Registered");
                            return 400;
                        }
                        else if (Convert.ToInt32(response.StatusCode) == 200)
                        {
                            MessageBox.Show("A Key Has Been Send To Your Email Address.");
                            return 200;
                        }
                        else
                        {
                            MessageBox.Show("Error");
                            return 0;
                        }
                    }
                }
            }
            {

            }
        }

        public async Task ChangePassword(ChangePasswordProperties inputdata)
        {
            var json = JsonConvert.SerializeObject(inputdata);
            var input = new StringContent(json, Encoding.UTF8, "application/json");
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage response = await client.PostAsync(changePasswordUrl, input))
                {
                    if (Convert.ToInt32(response.StatusCode) == 400)
                    {
                        MessageBox.Show("Passwords Dont Match");
                    }
                    else if (Convert.ToInt32(response.StatusCode) == 401)
                    {
                        MessageBox.Show("Invalid Token");
                    }
                    else if (Convert.ToInt32(response.StatusCode) == 200)
                    {
                        MessageBox.Show("Password Changed Successfully");
                    }
                    else { MessageBox.Show("Error"); }

                }

            }
        }
    }
}
