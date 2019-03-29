using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DotNetCoreWebMVC.Models;

namespace DotNetCoreWebMVC.Controllers
{
    public class DepartmentsController : Controller
    {
        public IActionResult Index()
        {
            List<Department> departments = new List<Department>();
            departments.Add(new Department { Id = 1, Name = "Computers" });
            departments.Add(new Department { Id = 2, Name = "Smartphones" });

            return View(departments);
        }
    }
}