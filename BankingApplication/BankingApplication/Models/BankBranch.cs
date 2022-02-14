using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankingApplication.Models
{
    public class BankBranch
    {
        public int BranchId { get; set; }

        public string BranchName { get; set; }

        public string Address { get; set; }

        public string Ifsc { get; set; }

        public DateTime CreatedOn { get; set; }

        public DateTime UpdatedOn { get; set; }
    }
}
