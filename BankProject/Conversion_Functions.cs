//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace BankProject
//{
//    public static class Conversion_Functions
//    {
//        public static HashSet<Account_Obj> CreateAccount_Objs(ICollection<Account> _accounts)
//        {
//            HashSet<Account_Obj> accounts = new HashSet<Account_Obj>();
//            foreach (var account in _accounts)
//            {
//                accounts.Add(new Account_Obj(account));
//            }
//            return accounts;
//        }

//        public static HashSet<Account> CreateAccounts(ICollection<Account_Obj> _accounts)
//        {
//            HashSet<Account> accounts = new HashSet<Account>();
//            foreach(var account in _accounts)
//            {
//                accounts.Add(account.Make_Account());
//            }
//            return accounts;
//        }

//        public static HashSet<Employee_Obj> CreateEmployee_Objs(ICollection<Employee> _employees)
//        {
//            HashSet<Employee_Obj> employees = new HashSet<Employee_Obj>();
//            foreach (var employee in _employees)
//            {
//                employees.Add(new Employee_Obj(employee));
//            }
//            return employees;
//        }

//        public static HashSet<Employee> CreateEmployees(ICollection<Employee_Obj> _employees)
//        {
//            HashSet<Employee> employees = new HashSet<Employee>();
//            foreach (var employee in _employees)
//            {
//                employees.Add(employee.Make_Employee());
//            }
//            return employees;
//        }
//        public static HashSet<Customer_Obj> CreateCustomer_Objs(ICollection<Customer> _customers)
//        {
//            HashSet<Customer_Obj> customers = new HashSet<Customer_Obj>();
//            foreach (var customer in _customers)
//            {
//                customers.Add(new Customer_Obj(customer));
//            }
//            return customers;
//        }

//        public static HashSet<Customer> CreateCustomers(ICollection<Customer_Obj> _customers)
//        {
//            HashSet<Customer> customers = new HashSet<Customer>();
//            foreach (var customer in _customers)
//            {
//                customers.Add(customer.Make_Customer());
//            }
//            return customers;
//        }
//        public static HashSet<Transaction_Obj> CreateTransaction_Objs(ICollection<Transaction> _transactions)
//        {
//            HashSet<Transaction_Obj> transactions = new HashSet<Transaction_Obj>();
//            foreach (var transaction in _transactions)
//            {
//                transactions.Add(new Transaction_Obj(transaction));
//            }
//            return transactions;
//        }

//        public static HashSet<Transaction> CreateTransactions(ICollection<Transaction_Obj> _transactions)
//        {
//            HashSet<Transaction> transactions = new HashSet<Transaction>();
//            foreach (var transaction in _transactions)
//            {
//                transactions.Add(transaction.Make_Transaction());
//            }
//            return transactions;
//        }

//    }
//}
