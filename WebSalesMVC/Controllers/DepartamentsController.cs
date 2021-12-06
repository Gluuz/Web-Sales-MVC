using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebSalesMVC.Models;

namespace WebSalesMVC.Controllers
{
    public class DepartmentsController : Controller
    {
        public IActionResult Index()
        {
            List <DepartmentModel> list = new List<DepartmentModel>();
            list.Add(new DepartmentModel { Id = 1, Name = "Eletronics"});
            list.Add(new DepartmentModel { Id = 2, Name = "Wearable"});

            return View(list);
        }
    }
}
