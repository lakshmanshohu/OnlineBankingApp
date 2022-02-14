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
        private Dictionary<string, IFilterCustomerGeneric> _filterMap = new Dictionary<string, IFilterCustomerGeneric>();

        private const string CUSTOMERT_NAME_FILTER = "ByCustomerName";
        private const string CUSTOMERT_ACTIVE_STATUS_FILTER = "ByActiveStatus";

        public BankManagementService(IBankManagementRepository repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
            _filterMap.Add(CUSTOMERT_NAME_FILTER, new FilterCustomerByName(_repository));
            _filterMap.Add(CUSTOMERT_ACTIVE_STATUS_FILTER, new FilterCustomreByActiveStatus(_repository));
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

        public List<Customer> GetCustomers(int customerId, string customerName, string activeStatus)
        {
            List<Customer> customers = new List<Customer>();
            if (customerId > 0) 
            {
                return _repository.GetCustomerById(customerId);
            }
            bool isDefaultFilter = true;
            if (!string.IsNullOrEmpty(customerName)) 
            {
                customers = _filterMap[CUSTOMERT_NAME_FILTER].Apply(customers, customerName);
                isDefaultFilter = false;
            }
            if (!string.IsNullOrEmpty(activeStatus)) 
            {
                customers = _filterMap[CUSTOMERT_ACTIVE_STATUS_FILTER].Apply(customers, activeStatus);
                isDefaultFilter = false;
            }

            if (isDefaultFilter) 
            {
                customers = _repository.GetCustomers();
            }

            return customers;
        }

        public void DeleteAccount(int id)
        {
            throw new NotImplementedException();
        }
    }
}
