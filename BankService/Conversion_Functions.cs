using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BankService
{
    public static class Conversion_Functions
    {
        public static HashSet<Models.Account> CreateAccount_Objs(ICollection<Account> _accounts)
        {
            HashSet<Models.Account> accounts = new HashSet<Models.Account>();
            foreach (var account in _accounts)
            {
                accounts.Add(new Models.Account(account));
            }
            return accounts;
        }

        public static HashSet<Account> CreateAccounts(ICollection<Models.Account> _accounts)
        {
            HashSet<Account> accounts = new HashSet<Account>();
            foreach(var account in _accounts)
            {
                accounts.Add(account.Make_Account());
            }
            return accounts;
        }

        public static HashSet<Models.Employee> CreateEmployee_Objs(ICollection<Employee> _employees)
        {
            HashSet<Models.Employee> employees = new HashSet<Models.Employee>();
            foreach (var employee in _employees)
            {
                employees.Add(new Models.Employee(employee));
            }
            return employees;
        }

        public static HashSet<Employee> CreateEmployees(ICollection<Models.Employee> _employees)
        {
            HashSet<Employee> employees = new HashSet<Employee>();
            foreach (var employee in _employees)
            {
                employees.Add(employee.Make_Employee());
            }
            return employees;
        }
        public static HashSet<Models.Customer> CreateCustomer_Objs(ICollection<Customer> _customers)
        {
            HashSet<Models.Customer> customers = new HashSet<Models.Customer>();
            foreach (var customer in _customers)
            {
                customers.Add(new Models.Customer(customer));
            }
            return customers;
        }

        public static HashSet<Customer> CreateCustomers(ICollection<Models.Customer> _customers)
        {
            HashSet<Customer> customers = new HashSet<Customer>();
            foreach (var customer in _customers)
            {
                customers.Add(customer.Make_Customer());
            }
            return customers;
        }
        public static HashSet<Models.Transaction> CreateTransaction_Objs(ICollection<Transaction> _transactions)
        {
            HashSet<Models.Transaction> transactions = new HashSet<Models.Transaction>();
            foreach (var transaction in _transactions)
            {
                transactions.Add(new Models.Transaction(transaction));
            }
            return transactions;
        }

        public static HashSet<Transaction> CreateTransactions(ICollection<Models.Transaction> _transactions)
        {
            HashSet<Transaction> transactions = new HashSet<Transaction>();
            foreach (var transaction in _transactions)
            {
                transactions.Add(transaction.Make_Transaction());
            }
            return transactions;
        }

    }
}
