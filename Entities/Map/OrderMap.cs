using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindEfCodeFirstFluentApi.Entities.Map
{
    public class OrderMap : EntityTypeConfiguration<Order>
    {
        public OrderMap()
        {
            this.ToTable("Orders");
            this.HasKey(i => i.OrderId);

            this.Property(i => i.OrderId).
                IsRequired().
                HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);


            this.Property(i => i.OrderId).HasColumnName("OrderId");
            this.Property(i => i.CustomerID).HasColumnName("CustomerID");
            this.Property(i => i.OrderDate).HasColumnName("OrderDate");

            //this.HasOptional(i => i.Customer).WithMany(i => i.Orders).HasForeignKey(i => i.CustomerID);
        }
    }
}
