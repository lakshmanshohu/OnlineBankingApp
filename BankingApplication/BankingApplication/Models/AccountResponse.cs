using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankingApplication.Models
{
    public class AccountResponse
    {
        public int AccountId { get; set; }

        public string Type { get; set; }

        public Customer Customer { get; set; }

        public BankBranch Branch { get; set; }

        public int Balance { get; set; }

        public string IsActive { get; set; }
    }
}
