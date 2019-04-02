using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;


namespace DotNetCoreWebMVC.Models
{
    public class Seller
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Display(Name = "Birth Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime BirthDate { get; set; }

        [Display(Name = "Base Salary")]
        [DisplayFormat(DataFormatString = "{0:F2}")]
        public double BaseSalary { get; set; }
        public Department Department { get; set; }
        public int DepartmentId { get; set; }
        public ICollection<SalesRecord> Sales { get; set; } = new List<SalesRecord>();

        public Seller(){}

        public Seller(int id, string name, string email, DateTime birthDate, double baseSalary, Department department) {
            this.Id = id;
            this.Name = name;
            this.Email = email;
            this.BirthDate = birthDate;
            this.BaseSalary = baseSalary;
            this.Department = department;
        }

        public void AddSales(SalesRecord salesRecord) {
            this.Sales.Add(salesRecord);
        }

        public void RemoveSales(SalesRecord salesRecord) {
            this.Sales.Remove(salesRecord);
        }

        // Calcular total de vendas de um vendedor em determinado período.
        public double TotalSales(DateTime initial, DateTime final) {
            return Sales.Where(salesRecord => salesRecord.Date >= initial && salesRecord.Date <= final).Sum(salesRecord => salesRecord.Amount);
        }

    }
}