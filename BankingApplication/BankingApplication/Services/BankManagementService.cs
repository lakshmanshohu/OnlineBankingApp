using BankingApplication.Models;
using BankingApplication.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankingApplication.Services
{
    public class BankManagementService : IBankManagementService
    {
        private readonly IBankManagementRepository _repository;
        public BankManagementService(IBankManagementRepository repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }
        public List<Customer> GetCustomers()
        {
            return _repository.GetCustomers();
        }
        public Customer GetCustomerById(int customerId)
        {
            return null;
        }
        public Customer GetCustomerByName(string customerName)
        {
            return null;
        }

        public void Insert(Customer customer)
        {
            _repository.InsertCustomer(customer);
        }
    }
}
