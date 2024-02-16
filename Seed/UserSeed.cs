using NorthwindEfCodeFirstFluentApi.Contexts;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindEfCodeFirstFluentApi.Entities.Seed
{
    public class UserSeed
    {
        public void AddUser()
        {
            using (var context = new NorthwindContext())
            {
                //Burda içerdeki kayıtları kontrol etmeliyiz.
                context.User.AddOrUpdate<User>(new User()
                {
                    Name = "Hakan",
                    Surname = "",
                    Birth = DateTime.Now,
                    CreateDate = DateTime.Now
                });

                context.User.Add(new User()
                {
                    Name = "Hakan",
                    Surname = "",
                    Birth = DateTime.Now,
                    CreateDate = DateTime.Now
                });
                context.SaveChanges();
            }
        }
    }
}
