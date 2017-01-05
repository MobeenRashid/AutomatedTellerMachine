using System.Data.Entity;
using System.Linq;
using AutomatedTellerMachine.Models;
using System.Web.Mvc;

namespace AutomatedTellerMachine.Controllers
{
    public class CheckingAccountController : Controller
    {
        // GET: ChekingAccount
        public ActionResult Index()
        {
            return View();
        }

        // GET: ChekingAccount/Details
        public ActionResult Details()
        {
            var account = new CheckingAccount
            {
                AccountNumber = "00232",
                FirstName = "Mobeen",
                LastName = "Rashid",
                Balance = 1000
            };


            return View(account);
        }

        // GET: ChekingAccount/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ChekingAccount/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
               
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: ChekingAccount/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ChekingAccount/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: ChekingAccount/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ChekingAccount/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
