using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateSalesAppWithLink.Models { 

    public class AppDbContext : DbContext { 

        public DbSet<Customer> Customers { get; set; } 
        public AppDbContext() { }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connStr = @"server=localhost\sqlexpress;" +
                   "database=SalesDb;" +
                   "trusted_connection=true;";
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(connStr);
            }
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
        }
    }
}
    