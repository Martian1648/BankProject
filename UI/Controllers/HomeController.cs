using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Web.Services.Description;
using UI.DataService;
namespace UI.Controllers
{
    public class HomeController : Controller
    {
        

        //Interface for a bank
        /*
         * Display bank name up top
         * have a list of customers at that bank
         * make a service that gets all the customers with bank.id as their bankid
         * have a list of employees at that bank
         * have a section of bank info
         */

        public ActionResult GetBankData(int id)
        {
            using (var thing = new DataService.DataServiceClient())
            {
                Tuple<Bank, List<Customer>, List<Employee>> model =
                    new Tuple<Bank, List<Customer>, List<Employee>>(thing.GetBank(id), thing.GetCustomersofBank(id), thing.GetEmployeesofBank(id));
                return View("BankInterface/BankData", model);
            }
        }

        public ActionResult SelectBank()
        {
            using (var thing = new DataService.DataServiceClient())
            {
                return View("SelectBank", thing.GetAllBanks());
            }
        }

        public ActionResult GetCustomerData(int id)
        {
            using (var thing = new DataService.DataServiceClient())
            {

                Tuple<Customer, List<Account>, List<Bank>, List<Transaction>> model =
                    new Tuple<Customer, List<Account>, List<Bank>, List<Transaction>>(thing.GetCustomer(id), thing.GetAccountsofCustomer(id),
                    thing.GetAllBanks(), thing.GetTransactionsofCustomer(id));
                return View("CustomerInterface/CustomerData", model);
            }
        }

        public ActionResult SelectCustomer()
        {
            using (var thing = new DataService.DataServiceClient())
            {
                return View("SelectCustomer", thing.GetAllCustomers());
            }
        }

        public ActionResult Home()
        {
            return View("Home");
        }

        public ActionResult MakeTransaction(int id)
        {
            using (var thing = new DataService.DataServiceClient())
            {
                Tuple<Transaction, List<Account>> model = new Tuple<Transaction, List<Account>>
                    (new Transaction() { Customer_Id = id }, thing.GetAccountsofCustomer(id));
                return View("CustomerInterface/MakeTransaction", model);
            }
        }

        [HttpPost]
        public ActionResult MakeTransaction(Transaction transaction)
        {
            using (var thing = new DataService.DataServiceClient())
            {
                thing.MakeTransaction(transaction);
                return RedirectToAction("Home");
            }
        }

        public ActionResult Seed()
        {
            return View("Seed");
        }

        [HttpPost]
        public ActionResult Seed(string message = null)
        {
            using (var thing = new DataService.DataServiceClient())
            {
                Random random = new Random();
                for (int i = 0; i < 10000; i++)
                {
                    int id = random.Next(1, 101);
                    var x = thing.GetAccountsofCustomer(id);
                    bool randbool = random.Next(0, 2) == 0;
                    int type = random.Next(1, 4);
                    if (type == 1)
                    {
                        thing.MakeTransaction(new Transaction()
                        {
                            Amount = 1.00m,
                            To_Account_Id = randbool == true ? x.First().Id : x.Last().Id,
                            Type_Number = type
                        });
                    }
                    else if (type == 2)
                    {
                        thing.MakeTransaction(new Transaction()
                        {
                            Amount = 1.00m,
                            From_Account_Id = randbool == true ? x.First().Id : x.Last().Id,
                            Type_Number = type
                        });
                    }
                    else if (type == 3)
                    {
                        thing.MakeTransaction(new Transaction()
                        {
                            Amount = 1.00m,
                            From_Account_Id = randbool == true ? x.First().Id : x.Last().Id,
                            To_Account_Id = randbool == true ? x.Last().Id : x.First().Id,
                            Type_Number = type
                        });
                    }

                    
                }
                return RedirectToAction("Home");

            }

        }

        public ActionResult See_Transaction_Report(int id, int type)
        {
            using(var thing = new DataService.DataServiceClient())
            {
                var report = thing.Report_Transactions_of_Bank(type, id);
                return PartialView("BankInterface/ReportBankTransaction", report);
            }
        }

        public ActionResult View_Customer(int id)
        {
            using(var thing = new DataService.DataServiceClient())
            {
                return PartialView("BankInterface/ViewCustomer", thing.GetCustomer(id));
            }
        }

        public ActionResult View_Employee(int id)
        {
            using (var thing = new DataService.DataServiceClient())
            {
                return PartialView("BankInterface/ViewEmployee", thing.GetEmployee(id));
            }
        }
    }


}
