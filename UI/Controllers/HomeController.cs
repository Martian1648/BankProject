using System;
using System.Collections.Generic;
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
        //List and Details for Models
        #region
        
        public ActionResult GetAllBanks()
        {
            using (var thing = new DataService.DataServiceClient())
            {
                List<DataService.Bank> banks = thing.GetAllBanks().ToList();
                return View("Banks", banks);

            }
        }

        public ActionResult GetOneBank(int id)
        {
            using (var thing = new DataService.DataServiceClient())
            {
                return View("Bank", thing.GetBank(id));
            }
        }

        public ActionResult GetAllAccounts()
        {
            using (var thing = new DataService.DataServiceClient())
            {
                return View("Accounts", thing.GetAllAccounts().ToList());
            }
        }

        public ActionResult GetOneAccount(int id)
        {
            using(var thing = new DataService.DataServiceClient())
            {
                return View("Account", thing.GetAccount(id));
            }
        }

        public ActionResult GetAllEmployees()
        {
            using (var thing = new DataService.DataServiceClient())
            {
                return View("Employees", thing.GetAllEmployees().ToList());
            }
        }

        public ActionResult GetOneEmployee(int id)
        {
            using(var thing =new DataService.DataServiceClient())
            {
                return View("Employee", thing.GetEmployee(id));
            }
        }

        public ActionResult GetAllCustomers()
        {
            using (var thing = new DataService.DataServiceClient())
            {
                return View("Customers", thing.GetAllCustomers().ToList());
            }
        }

        public ActionResult GetOneCustomer(int id)
        {
            using (var thing = new DataService.DataServiceClient())
            {
                return View("Customer", thing.GetCustomer(id));
            }
        }

        public ActionResult GetAllTransactions()
        {
            using (var thing = new DataService.DataServiceClient())
            {
                return View("Transactions", thing.GetAllTransactions().ToList());
            }
        }

        public ActionResult GetOneTransactions(int id) 
        {
            using(var thing =new DataService.DataServiceClient())
            {
                return View("Transaction", thing.GetTransaction(id));
            }
        }
        #endregion

        //Edit for Banks
        #region
        public ActionResult EditBank(int id)
        {
            using (var thing = new DataService.DataServiceClient())
            {
                return View("EditBank", thing.GetBank(id));
            }
        }

        [HttpPost]
        public ActionResult EditBank(int id, Bank bank)
        {
            using(var thing = new DataService.DataServiceClient())
            {
                thing.Update_Bank(bank);
                return RedirectToAction("GetAllBanks");
            }
        }
        #endregion

        //Create & Delete for Banks
        #region
        public ActionResult CreateBank()
        {
            return View("CreateBank", new UI.DataService.Bank());
        }

        [HttpPost]
        public ActionResult CreateBank(Bank bank)
        {
            using(var thing = new DataService.DataServiceClient())
            {
                thing.Add_Bank(bank);
                return RedirectToAction("GetAllBanks");
            }
        }

        public ActionResult DeleteBank(int id)
        {
            using(var thing = new DataService.DataServiceClient())
            {
                return View("DeleteBank", thing.GetBank(id));
            }
        }

        [HttpPost]
        public ActionResult DeleteBank(Bank bank)
        {
            using(var thing  =new DataService.DataServiceClient())
            {
                thing.Remove_Bank(bank.Id);
                return RedirectToAction("GetAllBanks");
            }
        }
        #endregion

    }
}