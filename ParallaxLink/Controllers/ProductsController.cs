using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ParallaxLink.TrainDatabase;
using ParallaxLink.TrainDatabase.Model;

namespace ParallaxLink.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        // GET api/products/all
        [HttpGet]
        [HttpGet("all")]
        public ActionResult<IEnumerable<ProductShort>> GetProducts()
        {
            return ParallaxController.GetProducts();
        }
    }
}