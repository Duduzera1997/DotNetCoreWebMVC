using Microsoft.AspNetCore.Mvc;
using DotNetCoreWebMVC.Services;

namespace DotNetCoreWebMVC.Controllers
{
    public class SellersController : Controller
    {   
        
        private readonly SellerService _sellerService;

        public SellersController(SellerService sellerService)
        {
            this._sellerService = sellerService;
        }
        public IActionResult Index() 
        {
            var sellers = _sellerService.FindAll();
            return View(sellers);
        }
    }
}