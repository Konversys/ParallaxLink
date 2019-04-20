using ParallaxLink.TrainDatabase.Model;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System;

namespace ParallaxLink.TrainDatabase
{
    public class DirectionController
    {
        public static List<TrainDirection> GetDirections()
        {
            try
            {
                using (var context = new DirectionContext())
                {
                    return context.Directions.ToList();
                }
            }
            catch
            {
                return new List<TrainDirection>();
            }
        }

        public static int? GetCheckSUMDirections()
        {
            try
            {
                using (var context = new DirectionContext())
                {
                    using (var command = context.Database.GetDbConnection().CreateCommand())
                    {
                        command.CommandText = "SELECT CHECKSUM_AGG(BINARY_CHECKSUM([value], name, from_, to_)) as checksum FROM Directions";
                        context.Database.OpenConnection();
                        using (var reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                reader.Read();
                                return reader.GetInt32(0);
                            }
                            else
                            {
                                return null;
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                return null;
            }
        }
    }
}
