using System.Data.Entity.ModelConfiguration;

namespace NorthwindEfCodeFirstFluentApi.Entities.Mappings
{
    public class CustomerMap :EntityTypeConfiguration<Customer>
    {
        public CustomerMap()
        {
            this.ToTable("Customers");
            this.HasKey(i=>i.CustomerID);

            this.Property(i => i.CustomerID).
                IsRequired().
                HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            this.Property(i => i.CompanyName).
                IsRequired().
                HasMaxLength(40);

            this.Property(i => i.ContactName).
                IsRequired().
                HasMaxLength(30);

            this.Property(i => i.ContactTitle).
                IsRequired().
                HasMaxLength(30);

            this.Property(i => i.Address).
                IsRequired().
                HasMaxLength(30);

            this.Property(i => i.City).
                IsRequired().
                HasMaxLength(15);

            this.Property(i => i.Region).
                IsRequired().
                HasMaxLength(15);

            this.Property(i => i.PostalCode).
                IsRequired().
                HasMaxLength(15);            

            this.Property(i => i.Country).
                IsRequired().
                HasMaxLength(15);

            this.Property(i => i.Phone).
                IsRequired().
                HasMaxLength(15);

            this.Property(i => i.Fax).
                IsRequired().
                HasMaxLength(15);

            this.Property(i => i.Sex).
                IsRequired().
                HasMaxLength(15);

            this.Property(i => i.CustomerID).HasColumnName("CustomerID");
            this.Property(i => i.CompanyName).HasColumnName("CompanyName");
            this.Property(i => i.ContactName).HasColumnName("ContactName");
            this.Property(i => i.ContactTitle).HasColumnName("ContactTitle");
            this.Property(i => i.Address).HasColumnName("Address");
            this.Property(i => i.City).HasColumnName("City");
            this.Property(i => i.Region).HasColumnName("Region");
            this.Property(i => i.PostalCode).HasColumnName("PostalCode");
            this.Property(i => i.Country).HasColumnName("Country");
            this.Property(i => i.Phone).HasColumnName("Phone");
            this.Property(i => i.Fax).HasColumnName("Fax");
            this.Property(i => i.Sex).HasColumnName("Sex");
        }
    }
}
