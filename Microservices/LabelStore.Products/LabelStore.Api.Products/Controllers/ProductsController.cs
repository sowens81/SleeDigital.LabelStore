using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LabelStore.Library.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LabelStore.Api.Products.Controllers
{
    [Route("api/[controller]")]
    public class ProductsController : Controller
    {
        // GET: api/values
        [HttpGet]
        [ProducesResponseType(typeof(string), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [Produces("application/json")]
        public IActionResult GetProducts()
        {
            List<Product> products = new List<Product>();

            products.Add(new Product());
            products.Add(new Product());
            products.Add(new Product());
            products.Add(new Product());

            return Ok(products);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(typeof(string), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [Produces("application/json")]
        public IActionResult GetProductById(string id)
        {
            Product product = new Product()
            {
                id = id
            };

            return Ok(product);
        }

        [HttpPost]
        [ProducesResponseType(typeof(string), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [Produces("application/json")]
        public IActionResult AddProduct(Product product)
        {

            if (product.Name == null)
            {
                return BadRequest("Error: Product Name is null or empty");
            }

            if (product.Price == 0)
            {
                return BadRequest("Error: Product Price not provided or set to 0.");
            }

            return Created(product.id, product.id);
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(typeof(string), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [Produces("application/json")]
        public IActionResult DeleteProductById(string id)
        {

            if (id != "abc-123")
            {
                return NotFound($"Not Found: {id} Product Id does not exist.");
            }

            return Accepted();
        }

        [HttpPut("{id}")]
        [ProducesResponseType(typeof(string), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [Produces("application/json")]
        public IActionResult UpdateProductInventoryById(string id, InvetoryQty invetoryQty)
        {
            if (id != "abc-123")
            {
                return NotFound($"Not Found: {id} Product Id does not exist.");
            }

            Product product = new Product()
            {
                Inventory = invetoryQty.Qty
            };

            
            return Accepted(product);
        }
    }
}

