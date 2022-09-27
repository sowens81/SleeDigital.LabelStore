using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System.Net.Http.Headers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Logging;
using System.Reflection.Emit;
using LabelStore.Shipping.Models;

namespace LabelStore.Shipping.Api.Controllers
{
    [ApiController]
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class ShippingController : ControllerBase
    {
        private readonly ILogger _logger;

        public ShippingController(ILogger<ShippingController> logger)
        {
            _logger = logger;
        }

        [ApiVersion("1.0")]
        [HttpGet]
        [ProducesResponseType(typeof(string), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [Produces("application/json")]
        public IActionResult GetShipping()
        {
            string timeNow = DateTime.UtcNow.ToLongTimeString();
            _logger.LogInformation($"GetShipping - Resource Requested {timeNow}");

            return Ok("GET ALL shipping resource.");

        }

        [ApiVersion("1.0")]
        [HttpGet("{id}")]
        [ProducesResponseType(typeof(string), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [Produces("application/json")]
        public IActionResult GetShippingById(string id)
        {
            string timeNow = DateTime.UtcNow.ToLongTimeString();
            _logger.LogInformation($"GetShipping - Resource Requested for Id {id} : {timeNow}");

            return Ok($"GET shipping resource with id {id}");

        }

        [ApiVersion("1.0")]
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [Produces("application/json")]
        public IActionResult PostShipping(Shipment shipment)
        {
            string timeNow = DateTime.UtcNow.ToLongTimeString();
            _logger.LogInformation($"PostShipping - Resource Posted : {timeNow}");

            _logger.LogInformation($"Adding shipment to queue... : {timeNow}");
            try
            {
                // add shippment to service bus queue
                return Accepted(shipment);
            }
            catch (Exception ex)
            {
                _logger.LogInformation($"Unable to add to queue : {ex} : {timeNow}");
                return BadRequest();
            }

            
        }
    }
}

