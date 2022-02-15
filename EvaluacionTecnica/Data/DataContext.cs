using EvaluacionTecnica.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace EvaluacionTecnica.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Gender> Genders { get; set; }
        public DbSet<Status> Statuses { get; set; }
        public DbSet<AccountType> AccountTypes { get; set; }
        public DbSet<CurrencyType> CurrencyTypes { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Account> Accounts { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Gender>().HasIndex(x => x.Description).IsUnique();
            modelBuilder.Entity<Status>().HasIndex(x => x.Description).IsUnique();
            modelBuilder.Entity<AccountType>().HasIndex(x => x.Description).IsUnique();
            modelBuilder.Entity<CurrencyType>().HasIndex(x => x.Description).IsUnique();
            modelBuilder.Entity<Customer>().HasIndex(x => x.Identidad).IsUnique();
            modelBuilder.Entity<Customer>().HasIndex(x => x.Code).IsUnique();
            modelBuilder.Entity<Account>().HasIndex(x => x.AccountNumber).IsUnique();
        }
    }
}
