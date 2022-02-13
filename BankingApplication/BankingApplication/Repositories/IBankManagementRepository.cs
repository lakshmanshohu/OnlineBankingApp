using BankingApplication.Models;
using System.Collections.Generic;

namespace BankingApplication.Repositories
{
    public interface IBankManagementRepository
    {
        void DeleteAccount(Customer customer);
        void DeleteCustomer(Customer customer);
        List<Account> GetAccounts();
        List<Customer> GetCustomers();
        List<Transaction> GetTransactions();
        void InsertAccount(Account customer);
        void InsertCustomer(Customer customer);
        void InsertTransation(Account customer);
        void UpdateAccount(Customer customer);
        void UpdateCustomer(Customer customer);
    }
}