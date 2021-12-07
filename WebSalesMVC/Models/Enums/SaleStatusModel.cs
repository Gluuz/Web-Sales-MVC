using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebSalesMVC.Models
{
    public enum SaleStatusModel : int
    {
        Pending = 0,
        Billed = 1,
        Canceled = 2
    }
}
