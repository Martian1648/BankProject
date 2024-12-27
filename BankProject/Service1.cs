//using System;
//using System.Collections.Generic;
//using System.Data.Entity;
//using System.Data.Entity.Migrations;
//using System.Linq;
//using System.Runtime.Serialization;
//using System.ServiceModel;
//using System.Text;

//namespace BankProject
//{
//    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
//    public class Service1 : IService1
//    {
//        public IEnumerable<Bank_Obj> GetBanks()
//        {
//            using (var db = new Bank_ProjectEntities())
//            {
//                var banks = new List<Bank_Obj>();
//                foreach (var obj in db.Bank.Include(e=>e.Account))
//                {
//                    banks.Add(new Bank_Obj(obj));
//                }
//                return banks;
//            }
//        }
//        public void Add_Bank(Bank_Obj bank)
//        {
//            using (var db = new Bank_ProjectEntities())
//            {
//                db.Bank.Add(bank.Make_Bank());
//                db.SaveChanges();
//            }
//        }

//        public void Remove_Bank(int id)
//        {
//            using(var db = new Bank_ProjectEntities())
//            {
//                db.Bank.Remove(db.Bank.Find(id));
//                db.SaveChanges();
//            }
//        }  

//        public void Update_Bank(Bank_Obj bank)
//        {
//            using( var db = new Bank_ProjectEntities())
//            {
//                var other = db.Bank.Find(bank.Id);
//                other = bank.Make_Bank();
//                db.Bank.AddOrUpdate(other);
//                db.SaveChanges();
//            }
//        }
//        public IEnumerable<Account_Obj> GetAccounts()
//        {
//            using (var db = new Bank_ProjectEntities())
//            {
//                var accounts = new List<Account_Obj>();
//                foreach (var obj in db.Account)
//                {
//                    accounts.Add(new Account_Obj(obj));
//                }
//                return accounts;
//            }
//        }

//        public void Add_Account(Account_Obj account)
//        {
//            using (var db = new Bank_ProjectEntities())
//            {
//                db.Account.Add(account.Make_Account());
//                db.SaveChanges();
//            }
//        }

//        public void Remove_Account(int id)
//        {
//            using (var db = new Bank_ProjectEntities())
//            {
//                db.Account.Remove(db.Account.Find(id));
//                db.SaveChanges();
//            }
//        }

//        public void Update_Account(Account_Obj account)
//        {
//            using (var db = new Bank_ProjectEntities())
//            {
//                var other = db.Account.Find(account.Id);
//                other = account.Make_Account();
//                db.Account.AddOrUpdate(other);
//                db.SaveChanges();
//            }
//        }
//        public IEnumerable<Account_Type_Obj> GetAccountTypes()
//        {
//            using (var db = new Bank_ProjectEntities())
//            {
//                var accountTypes = new List<Account_Type_Obj>();
//                foreach (var obj in db.Account_Type)
//                {
//                    accountTypes.Add(new Account_Type_Obj(obj));
//                }
//                return accountTypes;
//            }
//        }
//        public void Add_Account_Type(Account_Type_Obj accountType)
//        {
//            using (var db = new Bank_ProjectEntities())
//            {
//                db.Account_Type.Add(accountType.Make_Account_Type());
//                db.SaveChanges();
//            }
//        }

//        public void Remove_Account_Type(int number)
//        {
//            using (var db = new Bank_ProjectEntities())
//            {
//                db.Account_Type.Remove(db.Account_Type.Find(number));
//                db.SaveChanges();
//            }
//        }

//        public void Update_Account_Type(Account_Type_Obj accountType)
//        {
//            using (var db = new Bank_ProjectEntities())
//            {
//                var other = db.Account_Type.Find(accountType.Number);
//                other = accountType.Make_Account_Type();
//                db.Account_Type.AddOrUpdate(other);
//                db.SaveChanges();
//            }
//        }
//        public IEnumerable<Customer_Obj> GetCustomers()
//        {
//            using (var db = new Bank_ProjectEntities())
//            {
//                var customers = new List<Customer_Obj>();
//                foreach (var obj in db.Customer)
//                {
//                    customers.Add(new Customer_Obj(obj));
//                }
//                return customers;
//            }
//        }
//        public void Add_Customer(Customer_Obj customer)
//        {
//            using (var db = new Bank_ProjectEntities())
//            {
//                db.Customer.Add(customer.Make_Customer());
//                db.SaveChanges();
//            }
//        }

//        public void Remove_Customer(int id)
//        {
//            using (var db = new Bank_ProjectEntities())
//            {
//                db.Customer.Remove(db.Customer.Find(id));
//                db.SaveChanges();
//            }
//        }

//        public void Update_Customer(Customer_Obj customer)
//        {
//            using (var db = new Bank_ProjectEntities())
//            {
//                var other = db.Customer.Find(customer.Id);
//                other = customer.Make_Customer();
//                db.Customer.AddOrUpdate(other);
//                db.SaveChanges();
//            }
//        }
//        public IEnumerable<Employee_Obj> GetEmployees()
//        {
//            using (var db = new Bank_ProjectEntities())
//            {
//                var employees = new List<Employee_Obj>();
//                foreach (var obj in db.Employee)
//                {
//                    employees.Add(new Employee_Obj(obj));
//                }
//                return employees;
//            }
//        }
//        public void Add_Employee(Employee_Obj employee)
//        {
//            using (var db = new Bank_ProjectEntities())
//            {
//                db.Employee.Add(employee.Make_Employee());
//                db.SaveChanges();
//            }
//        }

//        public void Remove_Employee(int id)
//        {
//            using (var db = new Bank_ProjectEntities())
//            {
//                db.Employee.Remove(db.Employee.Find(id));
//                db.SaveChanges();
//            }
//        }

//        public void Update_Employee(Employee_Obj employee)
//        {
//            using (var db = new Bank_ProjectEntities())
//            {
//                var other = db.Employee.Find(employee.Id);
//                other = employee.Make_Employee();
//                db.Employee.AddOrUpdate(other);
//                db.SaveChanges();
//            }
//        }
//        public IEnumerable<Transaction_Obj> GetTransactions()
//        {
//            using (var db = new Bank_ProjectEntities())
//            {
//                var transactions = new List<Transaction_Obj>();
//                foreach (var obj in db.Transaction)
//                {
//                    transactions.Add(new Transaction_Obj(obj));
//                }
//                return transactions;
//            }
//        }
//        public void Add_Transaction(Transaction_Obj transaction)
//        {
//            using (var db = new Bank_ProjectEntities())
//            {
//                db.Transaction.Add(transaction.Make_Transaction());
//                db.SaveChanges();
//            }
//        }

//        public void Remove_Transaction(int id)
//        {
//            using (var db = new Bank_ProjectEntities())
//            {
//                db.Transaction.Remove(db.Transaction.Find(id));
//                db.SaveChanges();
//            }
//        }

//        public void Update_Transaction(Transaction_Obj transaction)
//        {
//            using (var db = new Bank_ProjectEntities())
//            {
//                var other = db.Transaction.Find(transaction.Id);
//                other = transaction.Make_Transaction();
//                db.Transaction.AddOrUpdate(other);
//                db.SaveChanges();
//            }
//        }
//        public IEnumerable<Transaction_Type_Obj> GetTransactionTypes()
//        {
//            using (var db = new Bank_ProjectEntities())
//            {
//                var transactionTypes = new List<Transaction_Type_Obj>();
//                foreach (var obj in db.Transaction_Type)
//                {
//                    transactionTypes.Add(new Transaction_Type_Obj(obj));
//                }
//                return transactionTypes;
//            }
//        }
//        public void Add_Transaction_Type(Transaction_Type_Obj transactionType)
//        {
//            using (var db = new Bank_ProjectEntities())
//            {
//                db.Transaction_Type.Add(transactionType.Make_Transaction_Type());
//                db.SaveChanges();
//            }
//        }

//        public void Remove_Transaction_Type(int number)
//        {
//            using (var db = new Bank_ProjectEntities())
//            {
//                db.Transaction_Type.Remove(db.Transaction_Type.Find(number));
//                db.SaveChanges();
//            }
//        }

//        public void Update_Transaction_Type(Transaction_Type_Obj transactionType)
//        {
//            using (var db = new Bank_ProjectEntities())
//            {
//                var other = db.Transaction_Type.Find(transactionType.Number);
//                other = transactionType.Make_Transaction_Type();
//                db.Transaction_Type.AddOrUpdate(other);
//                db.SaveChanges();
//            }
//        }


//        public Bank_Obj GetData(int value)
//        {
//            using(var db = new Bank_ProjectEntities())
//            {
//                return new Bank_Obj(db.Bank.First());
                
//            }
            
//        }

//        public CompositeType GetDataUsingDataContract(CompositeType composite)
//        {
//            if (composite == null)
//            {
//                throw new ArgumentNullException("composite");
//            }
//            if (composite.BoolValue)
//            {
//                composite.StringValue += "Suffix";
//            }
//            return composite;
//        }
//    }
//}
