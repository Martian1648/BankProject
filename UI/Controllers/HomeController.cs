using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Services.Description;
using BankService.Models;
namespace UI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            using(var thing = new DataService.DataServiceClient())
            {
                List<DataService.Bank> banks = thing.GetAllBanks().ToList();
                ViewData.Add("Banks", banks);
            }
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}