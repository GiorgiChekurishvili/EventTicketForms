using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventTicketForms.Models
{
    internal class ViewMyTransactions
    {
        public decimal Amount { get; set; }
        public string Reason { get; set; }
        public decimal BalanceChanges { get; set; }
        public DateTime TransactionMade { get; set; }
    }
}
