using Microsoft.AspNetCore.Mvc;
using DotNetCoreWebMVC.Services;
using DotNetCoreWebMVC.Models;

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

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Seller seller)
        {
            _sellerService.Insert(seller);
            return RedirectToAction(nameof(Index));
        }
    }
}