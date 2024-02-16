using NorthwindEfCodeFirstFluentApi.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindEfCodeFirstFluentApi.Entities.Seed
{
    public class CustomerSeed
    {
        public void AddCustomer()
        {
            using (var context = new NorthwindContext())
            {
                Customer customer = new Customer()
                {
                    CustomerID = 1,
                    CompanyName = "Ord",
                    ContactName = "HTM",
                    ContactTitle = "Director",
                    Address = "kadıköy",
                    City = "İstanbul",
                    Region = "MENA",
                    PostalCode = "1453",
                    Country = "Türkiye",
                    Phone = "0444",
                    Fax = "0555",
                    Sex = ""
                };
                context.Customer.Add(customer);
                context.SaveChanges();
            }
        }
    }
}
