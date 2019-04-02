using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using DotNetCoreWebMVC.Models;
using DotNetCoreWebMVC.Services.Exceptions;

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
            _context.Seller.Add(seller);
            _context.SaveChanges();
        }

        public Seller FindById(int id)
        {
            return _context.Seller.Include(seller => seller.Department).FirstOrDefault(seller => seller.Id == id);
        }

        public void Remove(int id)
        {
            var seller = _context.Seller.Find(id);
            _context.Seller.Remove(seller);
            _context.SaveChanges();
        }

        public void Update(Seller seller)
        {
            if (!_context.Seller.Any(x => x.Id == seller.Id))
            {
                throw new NotFoundException("ID Not Found!");
            }

            try
            {
                _context.Update(seller);
                _context.SaveChanges();
            }
            catch (DbUpdateConcurrencyException e)
            {
                throw new DbConcurrencyException(e.Message);
            }
        }
    }
}