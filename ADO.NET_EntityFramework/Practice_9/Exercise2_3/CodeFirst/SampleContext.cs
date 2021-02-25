using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace CodeFirst
{
    public class SampleContext : DbContext
    {
        public SampleContext() : base("MyShop")
        {
            //Database.SetInitializer(new DropCreateDatabaseIfModelChanges<SampleContext>());
        }
        public DbSet<Model.Customer> Customers { get; set; }
        public DbSet<Model.Order> Orders { get; set; }
        public DbSet<Model.VipOrder> VipOrders { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Model.Customer>()
            .Property(c => c.LastName).IsRequired().HasMaxLength(30);
        }

    }
}
