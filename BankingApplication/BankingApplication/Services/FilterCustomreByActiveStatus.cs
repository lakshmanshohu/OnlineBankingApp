using BankingApplication.Models;
using BankingApplication.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankingApplication.Services
{
    public class FilterCustomreByActiveStatus : IFilterCustomerGeneric
    {
        private readonly IBankManagementRepository _repository;

        public FilterCustomreByActiveStatus(IBankManagementRepository repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }
        public List<Customer> Apply(List<Customer> customers, string filterKey)
        {
            if (customers.Any())
            {
                customers = customers.Where(x => x.IsActive == filterKey).ToList();
            }
            else
            {
                customers = _repository.GetCustomers().Where(x => x.IsActive == filterKey).ToList();
            }

            return customers;
        }
    }
}
