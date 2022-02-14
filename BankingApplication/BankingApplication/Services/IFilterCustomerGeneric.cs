using BankingApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankingApplication.Services
{
    /// <summary>
    /// This interface defines generic behaviour to get customer details with filter.
    /// </summary>
    interface IFilterCustomerGeneric
    {
        /// <summary>
        /// Fetches customer details with specific filter
        /// </summary>
        /// <param name="customers"></param>
        /// <param name="filterKey"></param>
        /// <returns></returns>
        public List<Customer> Apply(List<Customer> customers, string filterKey);
    }
}
