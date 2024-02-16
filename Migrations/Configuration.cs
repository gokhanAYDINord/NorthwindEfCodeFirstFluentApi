namespace NorthwindEfCodeFirstFluentApi.Migrations
{
    using NorthwindEfCodeFirstFluentApi.Entities;
    using NorthwindEfCodeFirstFluentApi.Entities.Seed;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using System.Linq.Expressions;

    internal sealed class Configuration : DbMigrationsConfiguration<NorthwindEfCodeFirstFluentApi.Contexts.NorthwindContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            //AutomaticMigrationDataLossAllowed= false;
        }

        //update-database çalışması ile db yi update eder.
        protected override void Seed(NorthwindEfCodeFirstFluentApi.Contexts.NorthwindContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
            CustomerSeed customerSeed = new CustomerSeed();
            customerSeed.AddCustomer();
        }

       
    }
}
