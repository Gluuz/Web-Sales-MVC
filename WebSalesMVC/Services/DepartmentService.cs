using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebSalesMVC.Data;
using WebSalesMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace WebSalesMVC.Services
{
    public class DepartmentService
    {
        private readonly WebSalesMVCContext _context;

        public DepartmentService(WebSalesMVCContext context)
        {
            _context = context;
        }
        public async Task<List<DepartmentModel>> FindAllSync()
        {
            return await _context.DepartmentModel.OrderBy(x => x.Name).ToListAsync();
        }
    }
}
