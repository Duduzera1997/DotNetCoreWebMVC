using Microsoft.AspNetCore.Mvc;

namespace DotNetCoreWebMVC.Controllers
{
    public class SellersController : Controller
    {
        public IActionResult Index(){
            return View();
        }
    }
}