using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebSalesMVC.Models
{
    public class SellerModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public double BaseSalary { get; set; }
        public DepartmentModel Deparment { get; set; }
        public ICollection<SalesRecordModel> Sales { get; set; } = new List<SalesRecordModel>();

        public SellerModel()
        {
        }

        public SellerModel(int id, string name, string email, DateTime birthDate, double baseSalary, DepartmentModel deparment)
        {
            Id = id;
            Name = name;
            Email = email;
            BirthDate = birthDate;
            BaseSalary = baseSalary;
            Deparment = deparment;
        }
        public void AddSales(SalesRecordModel sr)
        {
            Sales.Add(sr);
        }
        public void RemoveSales(SalesRecordModel sr)
        {
            Sales.Remove(sr);
        }
        public double TotalSales(DateTime initial, DateTime final)
        {
            return Sales.Where(sr => sr.Date >= initial && sr.Date <= final).Sum(sr => sr.Amount);
        }
    }
}
