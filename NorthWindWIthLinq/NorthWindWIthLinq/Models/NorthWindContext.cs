using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWindWIthLinq.Models
{
    public class NorthWindContext : DbContext {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Product> Products { get; set; } 
        public DbSet<Supplier> Suppliers { get; set; }
        public NorthWindContext() { } 
        public NorthWindContext(DbContextOptions<NorthWindContext>options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            string connectionString = @"server=localhost|sqlexpress;" + "daNorthwind;" +
                "trusted_connection=true;";

            {
                if (!builder.IsConfigured) 
                { builder.UseSqlServer(connectionString); }
            }
        }



        protected override void OnModelCreating(ModelBuilder builder) { builder.Entity<OrderDetails>(p )   }
    }
}
