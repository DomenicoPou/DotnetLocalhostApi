using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TaxitripApi.Models;

namespace TaxitripApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TaxiTripController : ControllerBase
    {

        private readonly ILogger<TaxiTripController> _logger;

        public TaxiTripController(ILogger<TaxiTripController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<TaxiTrip> Get()
        {
            var rng = new Random();
            throw new Exception("Not implemented");
        }
    }
}
