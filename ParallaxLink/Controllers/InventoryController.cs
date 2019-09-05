using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using ParallaxLink.TrainDatabase;
using ParallaxLink.TrainDatabase.Model;

namespace ParallaxLink.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InventoryController : ControllerBase
    {
        // GET api/inventory/all
        [HttpGet]
        [HttpGet("all")]
        public ActionResult<IEnumerable<InventoryShort>> GetDirections()
        {
            return ParallaxController.GetInventories();
        }
    }
}