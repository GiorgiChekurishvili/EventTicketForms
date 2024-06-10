using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventTicketForms.Resources
{
    internal class TicketTypeProperties
    {
        public int EventId { get; set; }
        public required string TicketTypeName { get; set; }
        public decimal Price { get; set; }
        public int TotalTickets { get; set; }
        public DateTime SalesStartDate { get; set; }
        public DateTime SalesEndDate { get; set; }
    }
}
