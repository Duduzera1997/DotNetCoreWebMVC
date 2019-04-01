using System;
using System.Collections.Generic;
using System.Linq;
using DotNetCoreWebMVC.Models;

namespace DotNetCoreWebMVC.Services
{
    public class SellerService
    {   
        private readonly DotNetCoreWebMVCContext _context;

        // Construtor com injeção de dependência.
        public SellerService(DotNetCoreWebMVCContext context) 
        {
            this._context = context;
        }

        // Método pra buscar todos os Sellers;
        public List<Seller> FindAll() {
            return _context.Seller.ToList();
        }

        // Método pra inserir um novo Seller;
        public void Insert(Seller seller)
        {
            seller.Department = _context.Department.First();
            _context.Seller.Add(seller);
            _context.SaveChanges();
        }
    }
}