using ParallaxLink.TrainDatabase.Model;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System;

namespace ParallaxLink.TrainDatabase
{
    public class ParallaxController
    {
        public static List<Category> GetCategories()
        {
            try
            {
                using (var context = new ParallaxContext())
                {
                    return context.Categories.ToList();
                }
            }
            catch
            {
                return null;
            }
        }

        public static List<Product> GetProducts()
        {
            try
            {
                using (var context = new ParallaxContext())
                {
                    return context.Products.ToList();
                }
            }
            catch
            {
                return null;
            }
        }

        public static List<Direction> GetDirections()
        {
            try
            {
                using (var context = new ParallaxContext())
                {
                    return context.Directions.ToList();
                }
            }
            catch (Exception e)
            {
                string f = e.Message;
                return null;
            }
        }

        public static long? GetCheckSUMDirections()
        {
            try
            {
                using (ParallaxContext context = new ParallaxContext())
                {
                    long checksum = context.Checksums.FromSql("CHECKSUM TABLE Directions").AsNoTracking().FirstOrDefault().Hash;
                    return checksum;
                }
            }
            catch
            {
                return null;
            }
        }
    }
}
