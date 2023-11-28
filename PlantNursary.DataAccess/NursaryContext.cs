using Microsoft.EntityFrameworkCore;
using PlantNursary.Entities;

namespace PlantNursary.DataAccess
{
    public class NursaryContext : DbContext
    {
        DbSet<Plant> plants { get; set; }
        DbSet<Line> lines { get; set; } 
        DbSet<Sector> sectors { get; set; }
        DbSet<Field> fields { get; set; }
        DbSet<BreedingSector> breedings { get; set; }
        DbSet<QueenCell> QueenCells { get; set; }
        DbSet<Reservation> reservations { get; set; }
        DbSet<Bed> beds { get; set; }
        DbSet<GreenHouse> greenHouses { get; set; }

        DbSet<Nursary> nurses { get; set; }
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
