using System;
using System.Collections.Generic;
using System.Linq;
using DotNetCoreWebMVC.Models;

namespace DotNetCoreWebMVC.Services
{
    public class SellerService
    {
        private readonly DotNetCoreWebMVCContext _context;

        public SellerService(DotNetCoreWebMVCContext context) 
        {
            this._context = context;
        }

        public List<Seller> FindAll() {
            return _context.Seller.ToList();
        }
    }
}