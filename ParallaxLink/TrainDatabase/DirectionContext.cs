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
        public DbSet<TrainDirection> Directions { get; set; }

        const string CONNECTION_STRING_MSSQL = @"data source=konverdev.ru;initial catalog=parallax;persist security info=True;user id=plx_app;password=LtgFoKem;";

        public DirectionContext() : base()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(CONNECTION_STRING_MSSQL);
        }
    }
}
