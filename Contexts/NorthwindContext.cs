using NorthwindEfCodeFirstFluentApi.Entities;
using NorthwindEfCodeFirstFluentApi.Entities.Map;
using System.Data.Entity;

namespace NorthwindEfCodeFirstFluentApi.Contexts
{
    public class NorthwindContext : DbContext
    {
        public NorthwindContext()//:base("NorthwindContext")
        {
            //her seferinde yeniden oluşturur.
            //Database.SetInitializer<NorthwindContext>(new DropCreateDatabaseAlways<NorthwindContext>());
            Database.SetInitializer<NorthwindContext>(new DropCreateDatabaseIfModelChanges<NorthwindContext>());
            //Database.SetInitializer<NorthwindContext>(new MigrateDatabaseToLatestVersion<NorthwindContext, NorthwindEfCodeFirstFluentApi.Migrations.Configuration>());

        }
        protected override void OnModelCreating(DbModelBuilder builder)
        {
            //Database.SetInitializer<NorthwindContext>(new DropCreateDatabaseAlways<NorthwindContext>());
            builder.Configurations.Add(new CustomerMap());
            builder.Configurations.Add(new OrderMap());
            builder.Configurations.Add(new UserMap());
            builder.Configurations.Add(new PatientMap());
        }

        public DbSet<Customer> Customer { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Patient> Patient { get; set; }
    }
}
