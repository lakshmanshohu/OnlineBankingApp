using BankingApplication.Models;
using BankingApplication.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankingApplication.Services
{
    public class FilterCustomerByName : IFilterCustomerGeneric
    {
        private readonly IBankManagementRepository _repository;

        public FilterCustomerByName(IBankManagementRepository repository) 
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }
        public List<Customer> Apply(List<Customer> customers, string filterKey)
        {
            if (customers.Any())
            {
                customers = customers.Where(x => x.CustomerName == filterKey).ToList();
            }
            else 
            {
                customers = _repository.GetCustomers().Where(x=>x.CustomerName==filterKey).ToList();
            }

            return customers;
        }
    }
}
