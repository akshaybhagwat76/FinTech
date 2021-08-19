using Microsoft.AspNetCore.Mvc;
using FinTech.Web.Controllers;

namespace FinTech.Web.Public.Controllers
{
    public class HomeController : FinTechControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}