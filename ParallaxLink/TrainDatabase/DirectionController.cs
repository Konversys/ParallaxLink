using ParallaxLink.TrainDatabase.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
    }
}
