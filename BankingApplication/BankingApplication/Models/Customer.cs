using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankingApplication.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        
        public string CustomerName { get; set; }

        public string Gender { get; set; }

        public string Address { get; set; }

        public int Age { get; set; }

        public string MobileNumber { get; set; }
        
        public string Email { get; set; }
        
        public string Password { get; set; }
        
        public string IsActive { get; set; }
        
        public DateTimeOffset CreatedOn { get; set; }
        
        public DateTimeOffset UpdatedOn { get; set; }
    }
}
