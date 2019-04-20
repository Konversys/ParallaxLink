using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ParallaxLink.TrainDatabase;
using ParallaxLink.TrainDatabase.Model;

namespace ParallaxLink.Controllers
{
    [Route("")]
    [ApiController]
    public class ParallaxController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<TrainDirection>> Get()
        {
            return DirectionController.GetDirections();
        }
    }
}
