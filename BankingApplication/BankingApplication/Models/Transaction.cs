using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankingApplication.Models
{
    public class Transaction
    {
        public int TransactionId { get; set; }

        public string CustomerName { get; set; }

        public int AccountId { get; set; }

        public string FromAccount { get; set; }

        public string ToAccount { get; set; }

        public DateTime Time { get; set; }

        public string Message { get; set; }

        public string TransactionStatus { get; set; }
    }
}
