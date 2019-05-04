using Microsoft.EntityFrameworkCore;
using ParallaxLink.TrainDatabase.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParallaxLink.TrainDatabase
{
    class DirectionContext : DbContext
    {
        const string MYSQL_CONNECTION_STRING = "server=localhost;UserId=plx_reader;Password=LtgFoKem;database=parallax;charset=utf8";

        public DbSet<Direction> Directions { get; set; }

        public DbSet<Checksum> Checksums { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL(MYSQL_CONNECTION_STRING);
        }
    }
}
