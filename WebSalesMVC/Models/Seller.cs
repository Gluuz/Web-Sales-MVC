using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebSalesMVC.Models
{
    public class Seller
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="{0} Required")]
        [StringLength(60, MinimumLength = 3, ErrorMessage = "{0} size must be between {2} and {1}")]
        public string Name { get; set; }

        [Required(ErrorMessage = "{0} Required")]
        [StringLength(100, MinimumLength = 10, ErrorMessage = "Enter a valid {0}")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }


        [Display(Name = "Birth Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime BirthDate { get; set; }

        [Required(ErrorMessage = "{0} Required")]
        [Range(100.0, 50000.0, ErrorMessage = "Enter a valid {0}")]
        [Display(Name = "Base Salary")]
        [DisplayFormat(DataFormatString = "{0:F2}")]
        public double BaseSalary { get; set; }

        public DepartmentModel Deparment { get; set; }

        [Display(Name = "Department Id")]
        public int DepartmentId { get; set; }

        public ICollection<SalesRecord> Sales { get; set; } = new List<SalesRecord>();

        public Seller()
        {
        }

        public Seller(int id, string name, string email, DateTime birthDate, double baseSalary, DepartmentModel deparment)
        {
            Id = id;
            Name = name;
            Email = email;
            BirthDate = birthDate;
            BaseSalary = baseSalary;
            Deparment = deparment;
        }
        public void AddSales(SalesRecord sr)
        {
            Sales.Add(sr);
        }
        public void RemoveSales(SalesRecord sr)
        {
            Sales.Remove(sr);
        }
        public double TotalSales(DateTime initial, DateTime final)
        {
            return Sales.Where(sr => sr.Date >= initial && sr.Date <= final).Sum(sr => sr.Amount);
        }
    }
}
