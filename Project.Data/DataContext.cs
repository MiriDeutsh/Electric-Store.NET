
using Microsoft.EntityFrameworkCore;
using Project.Core.Model;
using System.Collections.Generic;

namespace Project.Data

{
    public class DataContext: DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=ElectircShop");
        }

    }
}
