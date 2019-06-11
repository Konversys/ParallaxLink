using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using ParallaxLink.TrainDatabase;
using ParallaxLink.TrainDatabase.Model;

namespace ParallaxLink.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChecksumController : ControllerBase
    {
        // GET api/checksum/all
        [HttpGet]
        [HttpGet("all")]
        public ActionResult<IEnumerable<Checksum>> GetChecksums()
        {
            List<Checksum> checksums = new List<Checksum>();
            long? product = ParallaxController.GetCheckSUMProducts();
            long? inventory = ParallaxController.GetCheckSUMItems();
            long? direction = ParallaxController.GetCheckSUMDirections();
            if (product != null)
            {
                checksums.Add(new Checksum(Checksum.PRODUCT, product.Value));
            }
            if (inventory != null)
            {
                checksums.Add(new Checksum(Checksum.INVENTORY, inventory.Value));
            }
            if (direction != null)
            {
                checksums.Add(new Checksum(Checksum.DIRECTION, direction.Value));
            }
            return checksums;
        }
    }
}