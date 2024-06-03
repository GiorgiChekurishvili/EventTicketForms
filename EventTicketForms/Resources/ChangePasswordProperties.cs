﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventTicketForms.Entities
{
    internal class ChangePasswordProperties
    {
        public required string Token {  get; set; }
        public required string Password { get; set; }
        public required string ConfirmPassword { get; set; }
    }
}
