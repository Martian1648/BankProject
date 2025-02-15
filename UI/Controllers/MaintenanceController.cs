﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UI.DataService;

namespace UI.Controllers
{
    public class MaintenanceController : Controller
    {
        //CRUD for Banks
        #region
        public ActionResult GetAllBanks()
        {
            using (var thing = new DataService.DataServiceClient())
            {
                List<DataService.Bank> banks = thing.GetAllBanks().ToList();
                return View("Bank/Banks", banks);

            }
        }

        public ActionResult GetOneBank(int id)
        {
            using (var thing = new DataService.DataServiceClient())
            {
                return View("Bank/Bank", thing.GetBank(id));
            }
        }
        public ActionResult EditBank(int id)
        {
            using (var thing = new DataService.DataServiceClient())
            {
                return View("Bank/EditBank", thing.GetBank(id));
            }
        }

        [HttpPost]
        public ActionResult EditBank(int id, Bank bank)
        {
            using (var thing = new DataService.DataServiceClient())
            {
                thing.Update_Bank(bank);
                return RedirectToAction("GetAllBanks");
            }
        }
        public ActionResult CreateBank()
        {
            return View("Bank/CreateBank", new UI.DataService.Bank());
        }

        [HttpPost]
        public ActionResult CreateBank(Bank bank)
        {
            using (var thing = new DataService.DataServiceClient())
            {
                thing.Add_Bank(bank);
                return RedirectToAction("GetAllBanks");
            }
        }

        public ActionResult DeleteBank(int id)
        {
            using (var thing = new DataService.DataServiceClient())
            {
                return View("Bank/DeleteBank", thing.GetBank(id));
            }
        }

        [HttpPost]
        public ActionResult DeleteBank(Bank bank)
        {
            using (var thing = new DataService.DataServiceClient())
            {
                thing.Remove_Bank(bank.Id);
                return RedirectToAction("GetAllBanks");
            }
        }
        #endregion

        //CRUD for Accounts
        #region
        public ActionResult GetAllAccounts()
        {
            using (var thing = new DataService.DataServiceClient())
            {
                return View("Account/Accounts", thing.GetAllAccounts().ToList());
            }
        }

        public ActionResult GetOneAccount(int id)
        {
            using (var thing = new DataService.DataServiceClient())
            {
                string name = "";
                name += thing.GetCustomer(thing.GetAccount(id).Customer_Id).First_Name;
                name += thing.GetCustomer(thing.GetAccount(id).Customer_Id).Last_Name;
                string bank_name = "";
                bank_name += thing.GetBank(thing.GetAccount(id).Bank_Id).Name;
                return View("Account/Account", new Tuple<Account, string, string>(thing.GetAccount(id), name, bank_name));
            }
        }

        public ActionResult EditAccount(int id)
        {
            using (var thing = new DataService.DataServiceClient())
            {
                return View("Account/EditAccount", thing.GetAccount(id));
            }
        }

        [HttpPost]
        public ActionResult EditAccount(int id, Account account)
        {
            using (var thing = new DataService.DataServiceClient())
            {
                thing.Update_Account(account);
                return RedirectToAction("GetAllAccounts");
            }
        }

        public ActionResult CreateAccount()
        {
            return View("Account/CreateAccount", new UI.DataService.Account());
        }

        [HttpPost]
        public ActionResult CreateAccount(Account account)
        {
            using (var thing = new DataService.DataServiceClient())
            {
                thing.Add_Account(account);
                return RedirectToAction("GetAllAccounts");
            }
        }

        public ActionResult DeleteAccount(int id)
        {
            using (var thing = new DataService.DataServiceClient())
            {
                return View("Account/DeleteAccount", thing.GetAccount(id));
            }
        }

        [HttpPost]
        public ActionResult DeleteAccount(Account account)
        {
            using (var thing = new DataService.DataServiceClient())
            {
                thing.Remove_Account(account.Id);
                return RedirectToAction("GetAllAccounts");
            }
        }
        #endregion

        //CRUD for Employees
        #region
        public ActionResult GetAllEmployees()
        {
            using (var thing = new DataService.DataServiceClient())
            {
                return View("Employee/Employees", thing.GetAllEmployees().ToList());
            }
        }

        public ActionResult GetOneEmployee(int id)
        {
            using (var thing = new DataService.DataServiceClient())
            {
                return View("Employee/Employee", thing.GetEmployee(id));
            }
        }

        public ActionResult EditEmployee(int id)
        {
            using (var thing = new DataService.DataServiceClient())
            {
                return View("Employee/EditEmployee", thing.GetEmployee(id));
            }
        }

        [HttpPost]
        public ActionResult EditEmployee(int id, Employee employee)
        {
            using (var thing = new DataService.DataServiceClient())
            {
                thing.Update_Employee(employee);
                return RedirectToAction("GetAllEmployees");
            }
        }

        public ActionResult CreateEmployee()
        {
            return View("Employee/CreateEmployee", new UI.DataService.Employee());
        }

        [HttpPost]
        public ActionResult CreateEmployee(Employee employee)
        {
            using (var thing = new DataService.DataServiceClient())
            {
                thing.Add_Employee(employee);
                return RedirectToAction("GetAllEmployees");
            }
        }

        public ActionResult DeleteEmployee(int id)
        {
            using (var thing = new DataService.DataServiceClient())
            {
                return View("Employee/DeleteEmployee", thing.GetEmployee(id));
            }
        }

        [HttpPost]
        public ActionResult DeleteEmployee(Employee employee)
        {
            using (var thing = new DataService.DataServiceClient())
            {
                thing.Remove_Employee(employee.Id);
                return RedirectToAction("GetAllEmployees");
            }
        }

        #endregion

        //CRUD for Customers
        #region
        public ActionResult GetAllCustomers()
        {
            using (var thing = new DataService.DataServiceClient())
            {
                return View("Customer/Customers", thing.GetAllCustomers().ToList());
            }
        }

        public ActionResult GetOneCustomer(int id)
        {
            using (var thing = new DataService.DataServiceClient())
            {
                return View("Customer/Customer", thing.GetCustomer(id));
            }
        }

        public ActionResult EditCustomer(int id)
        {
            using (var thing = new DataService.DataServiceClient())
            {
                return View("Customer/EditCustomer", thing.GetCustomer(id));
            }
        }

        [HttpPost]
        public ActionResult EditCustomer(int id, Customer customer)
        {
            using (var thing = new DataService.DataServiceClient())
            {
                thing.Update_Customer(customer);
                return RedirectToAction("GetAllCustomers");
            }
        }

        public ActionResult CreateCustomer()
        {
            return View("Customer/CreateCustomer", new UI.DataService.Customer());
        }

        [HttpPost]
        public ActionResult CreateCustomer(Customer customer)
        {
            using (var thing = new DataService.DataServiceClient())
            {
                thing.Add_Customer(customer);
                return RedirectToAction("GetAllCustomers");
            }
        }

        public ActionResult DeleteCustomer(int id)
        {
            using (var thing = new DataService.DataServiceClient())
            {
                return View("Customer/DeleteCustomer", thing.GetCustomer(id));
            }
        }

        [HttpPost]
        public ActionResult DeleteCustomer(Customer customer)
        {
            using (var thing = new DataService.DataServiceClient())
            {
                thing.Remove_Customer(customer.Id);
                return RedirectToAction("GetAllCustomers");
            }
        }

        #endregion

        //CRUD for Transactions
        #region
        public ActionResult GetAllTransactions()
        {
            using (var thing = new DataService.DataServiceClient())
            {
                return View("Transaction/Transactions", thing.GetAllTransactions().ToList());
            }
        }

        public ActionResult GetOneTransaction(int id)
        {
            using (var thing = new DataService.DataServiceClient())
            {
                string name = "";
                name += thing.GetCustomer(thing.GetTransaction(id).Customer_Id).First_Name;
                name += thing.GetCustomer(thing.GetTransaction(id).Customer_Id).Last_Name;
                return View("Transaction/Transaction", new Tuple<Transaction, string>(thing.GetTransaction(id)
                    , name));
            }
        }

        public ActionResult EditTransaction(int id)
        {
            using (var thing = new DataService.DataServiceClient())
            {
                return View("Transaction/EditTransaction", thing.GetTransaction(id));
            }
        }

        [HttpPost]
        public ActionResult EditTransaction(int id, Transaction transaction)
        {
            using (var thing = new DataService.DataServiceClient())
            {
                thing.Update_Transaction(transaction);
                return RedirectToAction("GetAllTransactions");
            }
        }

        public ActionResult CreateTransaction()
        {
            return View("Transaction/CreateTransaction", new UI.DataService.Transaction());
        }

        [HttpPost]
        public ActionResult CreateTransaction(Transaction transaction)
        {
            using (var thing = new DataService.DataServiceClient())
            {
                thing.Add_Transaction(transaction);
                return RedirectToAction("GetAllTransactions");
            }
        }

        public ActionResult DeleteTransaction(int id)
        {
            using (var thing = new DataService.DataServiceClient())
            {
                return View("Transaction/DeleteTransaction", thing.GetTransaction(id));
            }
        }

        [HttpPost]
        public ActionResult DeleteTransaction(Transaction transaction)
        {
            using (var thing = new DataService.DataServiceClient())
            {
                thing.Remove_Transaction(transaction.Id);
                return RedirectToAction("GetAllTransactions");
            }
        }

        #endregion
    }
}