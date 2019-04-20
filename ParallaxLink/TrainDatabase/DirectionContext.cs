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

        const string CONNECTION_STRING_MSSQL = @"Server=localhost\SQLEXPRESS;Database=myDataBase;User Id = plx_user;Password=LtgFoKem;";

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
