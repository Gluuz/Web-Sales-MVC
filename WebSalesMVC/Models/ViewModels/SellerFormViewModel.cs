using System.Collections.Generic;

namespace WebSalesMVC.Models.ViewModels
{
    public class SellerFormViewModel
    {
        public Seller Seller { get; set; }
        public ICollection<DepartmentModel> Departments { get; set; }
    }
}
