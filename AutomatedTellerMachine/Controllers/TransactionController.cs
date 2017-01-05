using AutomatedTellerMachine.Models;
using System.Web.Mvc;

namespace AutomatedTellerMachine.Controllers
{
    [Authorize]
    public class TransactionController : Controller
    {
        private ApplicationDbContext _dbContext = null;
        public TransactionController()
        {
            _dbContext = new ApplicationDbContext();
        }
        public ActionResult Deposite(int checkingAccountId)
        {
            return View();
        }

        [HttpPost]
        public ActionResult Deposite(Transaction transations)
        {
            _dbContext.Transactions.Add(transations);
            _dbContext.SaveChanges();
            return RedirectToAction("Index", "Home", null);
        }
    }
}