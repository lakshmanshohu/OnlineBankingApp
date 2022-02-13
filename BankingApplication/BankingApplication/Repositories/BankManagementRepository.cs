using BankingApplication.Helpers;
using BankingApplication.Models;
using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Threading.Tasks;

namespace BankingApplication.Repositories
{
    public class BankManagementRepository : IBankManagementRepository
    {
        public BankManagementRepository() 
        {
            SqlMapper.AddTypeHandler(new DateTimeOffsetHandler());
        }
        public List<Customer> GetCustomers()
        {
            using (IDbConnection connection = new SQLiteConnection(GetConnectionString()))
            {
                var output = connection.Query<Customer>("select * from Customer", new DynamicParameters());
                return output.ToList();
            }
        }

        public void InsertCustomer(Customer customer)
        {
            using (IDbConnection connection = new SQLiteConnection(GetConnectionString()))
            {
                customer.CreatedOn = DateTime.Now;
                customer.UpdatedOn = DateTime.Now;
                connection.Execute("INSERT INTO Customer (Name, Gender, Address, Age, MobileNumber, Email, Password, IsActive, CreatedOn, UpdatedOn) " +
                                    "VALUES (@CustomerName,@Gender, @Address,@Age, @MobileNumber, @Email, @Password, @IsActive, @CreatedOn, @UpdatedOn)", customer);
            }
        }

        public void DeleteCustomer(Customer customer)
        {

        }
        public void UpdateCustomer(Customer customer)
        {

        }
        public List<Account> GetAccounts()
        {
            using (IDbConnection connection = new SQLiteConnection(GetConnectionString()))
            {
                var output = connection.Query<Account>("select * from Account", new DynamicParameters());
                return output.ToList();
            }
        }
        public void InsertAccount(Account customer)
        {
            using (IDbConnection connection = new SQLiteConnection(GetConnectionString()))
            {
                connection.Execute("INSERT INTO Customer (Name, Gender, Address, Age, MobileNumber, Email, Password, IsActive, CreatedOn, UpdatedOn) " +
                                    "VALUES (@CustomerName,@Gender, @Address,@Age, @MobileNumber, @Email, @Password, @IsActive, @CreatedOn, @UpdatedOn)", customer);
            }
        }

        public void DeleteAccount(Customer customer)
        {

        }
        public void UpdateAccount(Customer customer)
        {

        }

        public List<Transaction> GetTransactions()
        {
            return null;
        }
        public void InsertTransation(Account customer)
        {
            using (IDbConnection connection = new SQLiteConnection(GetConnectionString()))
            {
                connection.Execute("INSERT INTO Customer (Name, Gender, Address, Age, MobileNumber, Email, Password, IsActive, CreatedOn, UpdatedOn) " +
                                    "VALUES (@CustomerName,@Gender, @Address,@Age, @MobileNumber, @Email, @Password, @IsActive, @CreatedOn, @UpdatedOn)", customer);
            }
        }
        private static string GetConnectionString(string name = "DefaultConnection")
        {
            return @"data source=.\BankingApplicationDB.db";
            //return ConfigurationManager.ConnectionStrings[0].ConnectionString;
        }

    }
}
