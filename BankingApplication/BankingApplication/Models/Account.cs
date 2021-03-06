using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankingApplication.Models
{
    public class Account
    {
        public int AccountId { get; set; }

        public string type { get; set; }

        public int CustomerId { get; set; }

        public int Branch { get; set; }

        public int Age { get; set; }

        public int Balance { get; set; }

        public string IsActive { get; set; }

        public DateTime CreatedOn { get; set; }

        public DateTime UpdatedOn { get; set; }
    }
}
