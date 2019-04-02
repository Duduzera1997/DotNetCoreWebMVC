using System;
using System.Threading.Tasks;
using System.Linq;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using DotNetCoreWebMVC.Models;

namespace DotNetCoreWebMVC.Services
{
    public class SalesRecordService
    {
        private readonly DotNetCoreWebMVCContext _context;


        // Construtor com injeção de dependência.
        public SalesRecordService(DotNetCoreWebMVCContext context)
        {
            this._context = context;
        }

        public async Task<List<SalesRecord>> FindByDateAsync(DateTime? minDate, DateTime? maxDate)
        {
            var result = from salesRecord in _context.SalesRecord select salesRecord;
            if (minDate.HasValue)
            {
                result = result.Where(x => x.Date >= minDate.Value);
            }
            if (maxDate.HasValue)
            {
                result = result.Where(x => x.Date <= maxDate.Value);

            }

            return await result.Include(x => x.Seller).Include(x => x.Seller.Department).OrderByDescending(x => x.Date).ToListAsync();

        }
    }
}
