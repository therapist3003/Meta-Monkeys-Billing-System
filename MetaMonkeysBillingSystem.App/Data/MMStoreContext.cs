// Representing a session with the database

using MetaMonkeysBillingSystem.App.Models;
using Microsoft.EntityFrameworkCore;

namespace MetaMonkeysBillingSystem.App.Data
{
    public class MMStoreContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; } = null!;
        public DbSet<Employee> Employees { get; set; } = null!;
        public DbSet<Invoice> Invoices { get; set; } = null!;
        public DbSet<InvoiceItem> InvoiceItems { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer();
        }
    }
}
