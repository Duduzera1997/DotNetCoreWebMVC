using System;
using System.Collections.Generic;
using System.Linq;
using DotNetCoreWebMVC.Models;

namespace DotNetCoreWebMVC.Services
{
    public class SellerService
    {   
        private readonly DotNetCoreWebMVCContext _context;

        // Construtor com inje��o de depend�ncia.
        public SellerService(DotNetCoreWebMVCContext context) 
        {
            this._context = context;
        }

        // M�todo pra buscar todos os Sellers;
        public List<Seller> FindAll() {
            return _context.Seller.ToList();
        }

        // M�todo pra inserir um novo Seller;
        public void Insert(Seller seller)
        {
            seller.Department = _context.Department.First();
            _context.Seller.Add(seller);
            _context.SaveChanges();
        }
    }
}