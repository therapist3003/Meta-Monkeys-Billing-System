//To represent a session with the database

using MetaMonkeysBillingSystem.App.Models;
using Microsoft.EntityFrameworkCore;

namespace MetaMonkeysBillingSystem.App.Data
{
    public class MMStoreDBContext : DbContext
    {
        protected readonly IConfiguration Configuration; // Created as part of obtaining the sqlite connection string

        public MMStoreDBContext(DbContextOptions<MMStoreDBContext> options) : base(options)
        {

        }

        public MMStoreDBContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        // One DbSet for each table in the database
        public DbSet<Customer> Customers { get; set; } = null!;

        public DbSet<Employee> Employees { get; set; } = null!;

        public DbSet<Invoice> Invoices { get; set; } = null!;

        public DbSet<InvoiceItem> InvoicesItems { get; set; } = null!;

        public DbSet<Item> Items { get; set; } = null !;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(Configuration.GetConnectionString("MM_Store_DB"));
        }

    }
}
