using EXAMEN_PARCIAL.Properties.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Json;

namespace EXAMEN_PARCIAL.Properties.Database
{
    public class AplicationDbContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

        public AplicationDbContext(DbContextOptions<AplicationDbContext> options) : base(options)
        {
            try
            {
                var DbCreator = Database.GetService<IDatabaseCreator>() as RelationalDatabaseCreator;
                if (DbCreator != null)
                {
                    if (!DbCreator.CanConnect()) DbCreator.Create();
                    if (!DbCreator.HasTables()) DbCreator.CreateTables();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
