using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebSalesMVC.Data;
using WebSalesMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace WebSalesMVC.Services
{
    public class SalesRecordService
    {
        private readonly WebSalesMVCContext _context;

        public SalesRecordService(WebSalesMVCContext context)
        {
            _context = context;
        }
        public async Task<List<SalesRecord>> FindByDateAsync(DateTime? minDate, DateTime? maxDate)
        {
            var result = from obj in _context.SalesRecord select obj;
            if (minDate.HasValue)
            {
                result = result.Where(x => x.Date >= minDate.Value);
            }
            if (maxDate.HasValue)
            {
                result = result.Where(x => x.Date <= maxDate.Value);
            }
            return await result.Include(x => x.Seller).Include(x => x.Seller.Deparment).OrderByDescending(x => x.Date).ToListAsync();
        }
        public async Task<List<IGrouping<DepartmentModel, SalesRecord>>> FindByDateGroupingAsync(DateTime? minDate, DateTime? maxDate)
        {
            var result = from obj in _context.SalesRecord select obj;
            if (minDate.HasValue)
            {
                result = result.Where(x => x.Date >= minDate.Value);
            }
            if (maxDate.HasValue)
            {
                result = result.Where(x => x.Date <= maxDate.Value);
            }
            return await result.Include(x => x.Seller).Include(x => x.Seller.Deparment).OrderByDescending(x => x.Date).GroupBy(x => x.Seller.Deparment).ToListAsync();
        }

    }
}
