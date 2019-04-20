using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ParallaxLink.TrainDatabase;
using ParallaxLink.TrainDatabase.Model;

namespace ParallaxLink.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DirectionsController : ControllerBase
    {
        // GET api/directions
        [HttpGet]
        [HttpGet("generic")]
        public ActionResult<IEnumerable<TrainDirection>> GetDirections()
        {
            return DirectionController.GetDirections();
        }

        [HttpGet("checksum")]
        public ActionResult<int> GetChecksum()
        {
            var result = DirectionController.GetCheckSUMDirections();
            if (result == null)
            {
                return -1;
            }
            else
            {
                return result;
            }
        }
    }
}
