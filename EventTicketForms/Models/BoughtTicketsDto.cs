﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventTicketForms.Resources
{
    internal class BoughtTicketsDto
    {
        public int Id { get; set; }
        [JsonProperty("GeneratedTicketId")]
        public string GeneratedEventId { get; set; }
        public string EventName { get; set; }
        public string TicketTypeName { get; set; }
        public int TicketQuantity { get; set; }
        public decimal TotalPrice { get; set; }
        public DateTime PurchaseDate { get; set; }
        
    }
}
