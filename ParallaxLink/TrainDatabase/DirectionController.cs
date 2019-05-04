using ParallaxLink.TrainDatabase.Model;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System;

namespace ParallaxLink.TrainDatabase
{
    public class DirectionController
    {
        public static List<Direction> GetDirections()
        {
            try
            {
                using (var context = new DirectionContext())
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
                using (DirectionContext context = new DirectionContext())
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
