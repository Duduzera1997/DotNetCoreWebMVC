using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using DotNetCoreWebMVC.Models;

namespace DotNetCoreWebMVC.Services
{
    public class DepartmentService
    {

        private readonly DotNetCoreWebMVCContext _context;

        // Construtor com injeção de dependência.
        public DepartmentService(DotNetCoreWebMVCContext context)
        {
            this._context = context;
        }

        // Método pra buscar todos os Departaments Ordenados;
        public async Task<List<Department>> FindAllAsync()
        {
            return await _context.Department.OrderBy(x => x.Name).ToListAsync();
        }

    }
}
