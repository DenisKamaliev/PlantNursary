using Microsoft.EntityFrameworkCore;

namespace PlantNursary.DataAccess
{
    public class NursaryContext : Microsoft.EntityFrameworkCore.DbContext
    {
        private readonly string _connectionString = "Host=localhost;Port=5432;Database=nursarydb;Username=postgres;Password=admin";

        public NursaryContext()
        { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(_connectionString);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            

        }
    }
    }
