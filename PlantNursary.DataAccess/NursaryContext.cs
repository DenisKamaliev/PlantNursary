using Microsoft.EntityFrameworkCore;
using PlantNursary.Entities;

namespace PlantNursary.DataAccess
{
    public class NursaryContext : DbContext
    {
        public DbSet<Plant> Plants { get; set; }
        public DbSet<Line> Lines { get; set; }
        public DbSet<Sector> Sectors { get; set; }
        public DbSet<Field> Fields { get; set; }
        public DbSet<BreedingSector> Breedings { get; set; }
        public DbSet<QueenCell> QueenCells { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Bed> Beds { get; set; }
        public DbSet<GreenHouse> GreenHouses { get; set; }
        public DbSet<Nursary> Nurses { get; set; }

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
