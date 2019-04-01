using System;
using System.Collections.Generic;
using System.Linq;
using DotNetCoreWebMVC.Models;

namespace DotNetCoreWebMVC.Services
{
    public class DepartmentService
    {

        private readonly DotNetCoreWebMVCContext _context;

        // Construtor com inje玢o de depend阯cia.
        public DepartmentService(DotNetCoreWebMVCContext context)
        {
            this._context = context;
        }

        // M閠odo pra buscar todos os Departaments Ordenados;
        public List<Department> FindAll()
        {
            return _context.Department.OrderBy(x => x.Name).ToList();
        }

    }
}
