using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DotNetCoreWebMVC.Models
{
    public class DotNetCoreWebMVCContext : DbContext
    {
        public DotNetCoreWebMVCContext (DbContextOptions<DotNetCoreWebMVCContext> options)
            : base(options)
        {
        }

        public DbSet<DotNetCoreWebMVC.Models.Department> Department { get; set; }
    }
}
