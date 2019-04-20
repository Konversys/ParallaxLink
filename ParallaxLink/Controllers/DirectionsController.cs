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
        public ActionResult<IEnumerable<TrainDirection>> Get()
        {
            var result = DirectionController.GetDirections();
            return result;
        }
    }
}
