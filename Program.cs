using NorthwindEfCodeFirstFluentApi.Contexts;
using NorthwindEfCodeFirstFluentApi.Entities;
using System;
using System.Linq;

namespace NorthwindEfCodeFirstFluentApi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //AddCustomer();
            AllUser();
            Console.ReadLine();
        }

        static void AllUser()
        {
            using (var context = new NorthwindContext())
            {
                IQueryable<User> user = from users in context.User
                                              select users;

                foreach (var item in user)
                {
                    Console.WriteLine($"{item.Name}-{item.Surname}-{item.Adres3}");
                }
            }
        }

        static void AllCustomer()
        {
            using (var context = new NorthwindContext())
            {
                IQueryable<Patient> patient = from customer in context.Patient
                                                 select customer;

                foreach (var item in patient)
                {
                    Console.WriteLine($"{item.Name}-{item.Surname}-{item.Adres3}");
                }
            }
        }
        static void AddCustomer()
        {
            using (var context = new NorthwindContext())
            {
                Customer customer = new Customer()
                {            
                    CustomerID= 1,
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
                    Sex=""  
                };
                context.Customer.Add(customer);
                context.SaveChanges();
            }
        }
    }
}
