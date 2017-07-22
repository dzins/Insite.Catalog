using System;
using System.Collections.Generic;
using System.Linq;
using Insite.Catalog.EF;
using Insite.Catalog.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData;
using Microsoft.AspNetCore.OData.Routing;

namespace Insite.Catalog.Controllers
{
    [EnableQuery]
    [ODataRoute("odata/products")]
    public class ProductsController : Controller
    {
        private readonly EntityContext entityContext;

		public ProductsController(EntityContext sampleContext)
        {
            entityContext = sampleContext;
        }

        // GET: api/Products
        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return entityContext.Products.ToList();
        }

        // GET api/Products/5
        [HttpGet("{productId}")]
        public IActionResult Get(int productId)
        {
			var product = entityContext.Products.Find(productId);
            if (product == null)
            {
                return NotFound();
            }

            return new ObjectResult(product);
        }

        // POST api/Products
        [HttpPost]
        public IActionResult Post([FromBody]Product value)
        {
            var locationUri = $"http://localhost:9091/api/Products/{value.Id}";

			entityContext.Products.Add(value);
			entityContext.SaveChanges();

			return Created(locationUri, value);
        }

        // PUT api/Products/5
        [HttpPut("{productId}")]
        public IActionResult Put(int productId, [FromBody]Product value)
        {
			var product = entityContext.Products.Find(productId);
            if (product == null)
            {
                return NotFound();
            }

            return new NoContentResult();
        }

        // DELETE api/Products/5
        [HttpDelete("{productId}")]
        public IActionResult Delete(int productId)
        {
			var product = entityContext.Products.Find(productId);
			if (product == null)
			{
				return NotFound();
			}

			entityContext.Products.Remove(product);
			entityContext.SaveChanges();

			return new NoContentResult();
        }
    }
}
