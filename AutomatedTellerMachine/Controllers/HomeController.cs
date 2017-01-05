using AutomatedTellerMachine.Models;
using Microsoft.AspNet.Identity;
using System.Linq;
using System.Web.Mvc;

namespace AutomatedTellerMachine.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext _dbContext;
        public HomeController()
        {
            _dbContext = new ApplicationDbContext();
        }

        [Authorize]
        public ActionResult Index()
        {
            string userId = User.Identity.GetUserId();
            var accountId = _dbContext.CheckingAccounts.Where(ur => ur.UserId == userId).First().Id;
            ViewBag.CheckingAccountId = accountId;
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