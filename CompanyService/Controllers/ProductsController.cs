using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CompanyService.Controllers
{
    [RoutePrefix("api/products")]
    public class ProductsController : ApiController
    {
        [HttpGet]
        public IHttpActionResult GetProducts()
        {
            return Ok(
                new[]
                {
                new { Name = "Product1", Value = 1 },
                new { Name = "Product2", Value = 2 }
                }
                );
        }

        [HttpGet]
        public IHttpActionResult GetSubProducts(int productId)
        {
            if(productId == 1)
            return Ok(
                new[]
                {
                new { Name = "SubProduct1", Value = 7 },
                new { Name = "SubProduct2", Value = 8 },
                new { Name = "SubProduct3", Value = 8 }
                }
                );

            return Ok(
                new[]
                {
                            new { Name = "SubProduct4", Value = 4 },
                            new { Name = "SubProduct5", Value = 5 },
                            new { Name = "SubProduct6", Value = 6 }
                }
                );
        }
    }
}
