using Microsoft.EntityFrameworkCore;
using ParallaxLink.TrainDatabase.Model;

namespace ParallaxLink.TrainDatabase
{
    class ParallaxContext : DbContext
    {
        const string MYSQL_CONNECTION_STRING_LOCAL = "server=localhost;UserId=plx_reader;Password=LtgFoKem;database=parallax;charset=utf8";
        const string MYSQL_CONNECTION_STRING_REMOTE = "server=konverdev.ru;UserId=konver;Password=1833522;database=parallax;charset=utf8";

        public DbSet<Direction> Directions { get; set; }

        public DbSet<Checksum> Checksums { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Inventory> Inventories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL(MYSQL_CONNECTION_STRING_REMOTE);
        }
    }
}