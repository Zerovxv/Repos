using Microsoft.EntityFrameworkCore;
using ExpenseApp.Modules;

namespace ExpenseApp.Modules
{
    public class AppDbContext : DbContext

    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Expense> Expenses { get; set; }
        public DbSet<Item> Items { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options){ }

        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {


        }

        public DbSet<ExpenseApp.Modules.Expenseline> Expenseline { get; set; }




    }
}
