using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using BankService;
using System.Data.Entity;

using System.Data.Entity.Migrations;
using System.Threading.Tasks;
namespace BankService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file toGetAllher.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class DataService : IDataService
    {
        //basic CRUD stuff
        #region
        public IEnumerable<Models.Bank> GetAllBanks()
        {
            using (var db = new Bank_ProjectEntities())
            {
                var banks = new List<Models.Bank>();
                foreach (Bank obj in db.Bank)
                {
                    banks.Add(new Models.Bank(obj));
                }
                return banks;
            }
        }
        public Models.Bank GetBank(int id)
        {
            using (var db = new Bank_ProjectEntities())
            {
                return new Models.Bank(db.Bank.Find(id));
            }
        }
        public void Add_Bank(Models.Bank bank)
        {
            using (var db = new Bank_ProjectEntities())
            {
                db.Bank.Add(bank.Make_Bank());
                db.SaveChanges();
            }
        }

        public void Remove_Bank(int id)
        {
            using (var db = new Bank_ProjectEntities())
            {
                db.Bank.Remove(db.Bank.Find(id));
                db.Database.ExecuteSqlCommand("DBCC CHECKIDENT ('Bank', RESEED, @p0);", db.Bank.ToArray()[db.Bank.Count() - 2].Id);
                db.SaveChanges();
            }
        }

        public void Update_Bank(Models.Bank bank)
        {
            using (var db = new Bank_ProjectEntities())
            {
                var other = db.Bank.Find(bank.Id);
                other = bank.Make_Bank();
                db.Bank.AddOrUpdate(other);
                db.SaveChanges();
            }
        }
        public IEnumerable<Models.Account> GetAllAccounts()
        {
            using (var db = new Bank_ProjectEntities())
            {
                var accounts = new List<Models.Account>();
                foreach (var obj in db.Account)
                {
                    accounts.Add(new Models.Account(obj));
                }
                return accounts;
            }
        }
        public Models.Account GetAccount(int id)
        {
            using (var db = new Bank_ProjectEntities())
            {
                return new Models.Account(db.Account.Find(id));
            }
        }
        public void Add_Account(Models.Account account)
        {
            using (var db = new Bank_ProjectEntities())
            {
                db.Account.Add(account.Make_Account());
                db.SaveChanges();
            }
        }

        public void Remove_Account(int id)
        {
            using (var db = new Bank_ProjectEntities())
            {
                db.Account.Remove(db.Account.Find(id));
                db.Database.ExecuteSqlCommand("DBCC CHECKIDENT ('Account', RESEED, @p0);", db.Account.ToArray()[db.Account.Count() - 2].Id);
                db.SaveChanges();
            }
        }

        public void Update_Account(Models.Account account)
        {
            using (var db = new Bank_ProjectEntities())
            {
                var other = db.Account.Find(account.Id);
                other = account.Make_Account();
                db.Account.AddOrUpdate(other);
                db.SaveChanges();
            }
        }
        public IEnumerable<Models.Account_Type> GetAllAccountTypes()
        {
            using (var db = new Bank_ProjectEntities())
            {
                var accountTypes = new List<Models.Account_Type>();
                foreach (var obj in db.Account_Type)
                {
                    accountTypes.Add(new Models.Account_Type(obj));
                }
                return accountTypes;
            }
        }
        public Models.Account_Type GetAccountType(int number)
        {
            using (var db = new Bank_ProjectEntities())
            {
                return new Models.Account_Type(db.Account_Type.Find(number));
            }
        }
        public void Add_Account_Type(Models.Account_Type accountType)
        {
            using (var db = new Bank_ProjectEntities())
            {
                db.Account_Type.Add(accountType.Make_Account_Type());
                db.SaveChanges();
            }
        }

        public void Remove_Account_Type(int number)
        {
            using (var db = new Bank_ProjectEntities())
            {
                db.Account_Type.Remove(db.Account_Type.Find(number));
                db.SaveChanges();
            }
        }

        public void Update_Account_Type(Models.Account_Type accountType)
        {
            using (var db = new Bank_ProjectEntities())
            {
                var other = db.Account_Type.Find(accountType.Number);
                other = accountType.Make_Account_Type();
                db.Account_Type.AddOrUpdate(other);
                db.SaveChanges();
            }
        }
        public IEnumerable<Models.Customer> GetAllCustomers()
        {
            using (var db = new Bank_ProjectEntities())
            {
                var customers = new List<Models.Customer>();
                foreach (var obj in db.Customer)
                {
                    customers.Add(new Models.Customer(obj));
                }
                return customers;
            }
        }
        public Models.Customer GetCustomer(int id)
        {
            using (var db = new Bank_ProjectEntities())
            {
                return new Models.Customer(db.Customer.Find(id));
            }
        }
        public void Add_Customer(Models.Customer customer)
        {
            using (var db = new Bank_ProjectEntities())
            {
                db.Customer.Add(customer.Make_Customer());
                db.SaveChanges();
            }
        }

        public void Remove_Customer(int id)
        {
            using (var db = new Bank_ProjectEntities())
            {
                db.Customer.Remove(db.Customer.Find(id));
                db.Database.ExecuteSqlCommand("DBCC CHECKIDENT ('Customer', RESEED, @p0);", db.Customer.ToArray()[db.Customer.Count() - 2].Id);
                db.SaveChanges();
            }
        }

        public void Update_Customer(Models.Customer customer)
        {
            using (var db = new Bank_ProjectEntities())
            {
                var other = db.Customer.Find(customer.Id);
                other = customer.Make_Customer();
                db.Customer.AddOrUpdate(other);
                db.SaveChanges();
            }
        }
        public IEnumerable<Models.Employee> GetAllEmployees()
        {
            using (var db = new Bank_ProjectEntities())
            {
                var employees = new List<Models.Employee>();
                foreach (var obj in db.Employee)
                {
                    employees.Add(new Models.Employee(obj));
                }
                return employees;
            }
        }
        public Models.Employee GetEmployee(int id)
        {
            using (var db = new Bank_ProjectEntities())
            {
                return new Models.Employee(db.Employee.Find(id));
            }
        }
        public void Add_Employee(Models.Employee employee)
        {
            using (var db = new Bank_ProjectEntities())
            {
                db.Employee.Add(employee.Make_Employee());
                db.SaveChanges();
            }
        }

        public void Remove_Employee(int id)
        {
            using (var db = new Bank_ProjectEntities())
            {
                db.Employee.Remove(db.Employee.Find(id));
                db.Database.ExecuteSqlCommand("DBCC CHECKIDENT ('Employee', RESEED, @p0);", db.Employee.ToArray()[db.Employee.Count() - 2].Id);
                db.SaveChanges();
            }
        }

        public void Update_Employee(Models.Employee employee)
        {
            using (var db = new Bank_ProjectEntities())
            {
                var other = db.Employee.Find(employee.Id);
                other = employee.Make_Employee();
                db.Employee.AddOrUpdate(other);
                db.SaveChanges();
            }
        }
        public IEnumerable<Models.Transaction> GetAllTransactions()
        {
            using (var db = new Bank_ProjectEntities())
            {
                var transactions = new List<Models.Transaction>();
                foreach (var obj in db.Transaction)
                {
                    transactions.Add(new Models.Transaction(obj));
                }
                return transactions;
            }
        }
        public Models.Transaction GetTransaction(int id)
        {
            using (var db = new Bank_ProjectEntities())
            {
                return new Models.Transaction(db.Transaction.Find(id));
            }
        }
        public void Add_Transaction(Models.Transaction transaction)
        {
            using (var db = new Bank_ProjectEntities())
            {
                db.Transaction.Add(transaction.Make_Transaction());
                db.SaveChanges();
            }
        }

        public void Remove_Transaction(int id)
        {
            using (var db = new Bank_ProjectEntities())
            {
                db.Transaction.Remove(db.Transaction.Find(id));
                db.Database.ExecuteSqlCommand("DBCC CHECKIDENT ('Transaction', RESEED, @p0);", db.Transaction.ToArray()[db.Transaction.Count() - 2].Id);
                db.SaveChanges();
            }
        }

        public void Update_Transaction(Models.Transaction transaction)
        {
            using (var db = new Bank_ProjectEntities())
            {
                var other = db.Transaction.Find(transaction.Id);
                other = transaction.Make_Transaction();
                db.Transaction.AddOrUpdate(other);
                db.SaveChanges();
            }
        }
        public IEnumerable<Models.Transaction_Type> GetAllTransactionTypes()
        {
            using (var db = new Bank_ProjectEntities())
            {
                var transactionTypes = new List<Models.Transaction_Type>();
                foreach (var obj in db.Transaction_Type)
                {
                    transactionTypes.Add(new Models.Transaction_Type(obj));
                }
                return transactionTypes;
            }
        }
        public Models.Transaction_Type GetTransactionType(int number)
        {
            using (var db = new Bank_ProjectEntities())
            {
                return new Models.Transaction_Type(db.Transaction_Type.Find(number));
            }
        }
        public void Add_Transaction_Type(Models.Transaction_Type transactionType)
        {
            using (var db = new Bank_ProjectEntities())
            {
                db.Transaction_Type.Add(transactionType.Make_Transaction_Type());
                db.SaveChanges();
            }
        }

        public void Remove_Transaction_Type(int number)
        {
            using (var db = new Bank_ProjectEntities())
            {
                db.Transaction_Type.Remove(db.Transaction_Type.Find(number));
                db.SaveChanges();
            }
        }

        public void Update_Transaction_Type(Models.Transaction_Type transactionType)
        {
            using (var db = new Bank_ProjectEntities())
            {
                var other = db.Transaction_Type.Find(transactionType.Number);
                other = transactionType.Make_Transaction_Type();
                db.Transaction_Type.AddOrUpdate(other);
                db.SaveChanges();
            }
        }
        #endregion

        //retreive all customers in given bank
        public IEnumerable<Models.Customer> GetCustomersofBank(int id)
        {
            using(var thing = new Bank_ProjectEntities())
            {
                var customers = new List<Models.Customer>();
                foreach (var item in thing.Customer.Where(c => c.Bank_Id == id))
                {
                    customers.Add(new Models.Customer(item));    
                }
                return customers;
            }
        }

        //retrieve all employees in given bank
        public IEnumerable<Models.Employee> GetEmployeesofBank(int id)
        {
            using(var thing = new Bank_ProjectEntities())
            {
                var employees = new List<Models.Employee>();
                foreach(var item in thing.Employee.Where(e => e.Bank_Id == id))
                {
                    employees.Add(new Models.Employee(item));
                }
                return employees;
            }
        }

        //retrieve all accounts of a given customer
        public IEnumerable<Models.Account> GetAccountsofCustomer(int id)
        {
            using(var thing = new Bank_ProjectEntities())
            {
                var accounts = new List<Models.Account>();
                foreach(var item in thing.Account.Where(c =>c.Customer_Id == id))
                {
                    accounts.Add(new Models.Account(item));
                }
                return accounts;
            }
        }

        //retrieve all transactions of a given customer
        public IEnumerable<Models.Transaction> GetTransactionsofCustomer(int id)
        {
            using (var thing = new Bank_ProjectEntities())
            {
                var transactions = new List<Models.Transaction>();
                foreach(var item in thing.Transaction.Where(t => t.Customer_Id == id))
                {
                    transactions.Add(new Models.Transaction(item));
                }
                return transactions;
            }
        }

    }
}
