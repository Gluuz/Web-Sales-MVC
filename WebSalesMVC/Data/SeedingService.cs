using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebSalesMVC.Models;

namespace WebSalesMVC.Data
{
    public class SeedingService
    {
        private WebSalesMVCContext _context;

        public SeedingService(WebSalesMVCContext context)
        {
             _context = context;
        }
        
        public void Seed()
        {
            if(_context.DepartmentModel.Any() || _context.Seller.Any() || _context.SalesRecord.Any())
            {
                return;
            }

            DepartmentModel d1 = new DepartmentModel(1, "Computers");
            DepartmentModel d2 = new DepartmentModel(2, "Wearable");
            DepartmentModel d3 = new DepartmentModel(3, "Fashion");
            DepartmentModel d4 = new DepartmentModel(4, "Books");

            Seller s1 = new Seller(1, "Johnny Black", "Black@gmail.com", new DateTime(1998, 4, 21), 1000.0, d1);
            Seller s2 = new Seller(2, "Johnny White", "White@gmail.com", new DateTime(1998, 4, 16), 3000.0, d2);
            Seller s3 = new Seller(3, "Johnny Green", "Green@gmail.com", new DateTime(1998, 4, 1), 1400.0, d3);
            Seller s4 = new Seller(4, "Johnny Purple", "Purple@gmail.com", new DateTime(1998, 4, 29), 2000.0, d4);
            Seller s5 = new Seller(5, "Johnny Blue", "Blue@gmail.com", new DateTime(1998, 4, 20), 8000.0, d1);

            SalesRecord r1 = new SalesRecord(1, new DateTime(2018, 09, 25), 11000.0, SaleStatusModel.Billed, s1);
            SalesRecord r2 = new SalesRecord(2, new DateTime(2018, 09, 25), 13000.0, SaleStatusModel.Billed, s2);
            SalesRecord r3 = new SalesRecord(3, new DateTime(2018, 09, 26), 1000.0,  SaleStatusModel.Billed, s3);
            SalesRecord r4 = new SalesRecord(4, new DateTime(2018, 09, 27), 14000.0, SaleStatusModel.Billed, s4);
            SalesRecord r5 = new SalesRecord(5, new DateTime(2018, 09, 28), 15000.0, SaleStatusModel.Billed, s5);
            SalesRecord r6 = new SalesRecord(6, new DateTime(2018, 09, 29), 16000.0, SaleStatusModel.Billed, s1);
            SalesRecord r7 = new SalesRecord(7, new DateTime(2018, 09, 30), 17000.0, SaleStatusModel.Billed, s2);

            _context.DepartmentModel.AddRange(d1, d2, d3, d4);
            _context.Seller.AddRange(s1, s2, s3, s4, s5);
            _context.SalesRecord.AddRange(r1, r2, r3, r4, r5, r6, r7);
            _context.SaveChanges();
        }

   
    }
}
