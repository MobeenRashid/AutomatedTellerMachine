using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutomatedTellerMachine.Models;

namespace AutomatedTellerMachine.Controllers
{
    public class DepartmentController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string searchText)
        {
            ApplicationDbContext db = new ApplicationDbContext();
            var userAccounts =
                db.CheckingAccounts.Where(acc => acc.FirstName.Contains(searchText) || acc.LastName.Contains(searchText))
                    .ToList();

            return View("Result",userAccounts);
        }
        // GET: Department
        public ActionResult Creat()
        {
            return View();
        }
    }
}