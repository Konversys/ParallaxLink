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
        // GET api/directions/all
        [HttpGet]
        [HttpGet("all")]
        public ActionResult<IEnumerable<DirectionShort>> GetDirections()
        {
            return ParallaxController.GetDirections().ConvertAll(new Converter<Direction, DirectionShort>(DirectionShort.Convert));
        }

        // GET api/directions/valid
        [HttpGet("valid")]
        public ActionResult<IEnumerable<DirectionShort>> GetValidDirections()
        {
            return ParallaxController.GetDirections().Where(x => x.From != null && x.To != null).ToList().ConvertAll(new Converter<Direction, DirectionShort>(DirectionShort.Convert));
        }

        // GET api/directions/checksum
        [HttpGet("checksum")]
        public ActionResult<long?> GetChecksum()
        {
            return ParallaxController.GetCheckSUMDirections();
        }
    }
}
