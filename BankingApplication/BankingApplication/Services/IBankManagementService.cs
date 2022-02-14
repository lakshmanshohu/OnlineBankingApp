using BankingApplication.Models;
using System.Collections.Generic;

namespace BankingApplication.Services
{
    public interface IBankManagementService
    {
        Customer GetCustomerById(int customerId);
        Customer GetCustomerByName(string customerName);
        List<Customer> GetCustomers(int customerId, string customerName, string activeStatus);
        void Insert(Customer customer);
        void DeleteAccount(int id);
    }
}