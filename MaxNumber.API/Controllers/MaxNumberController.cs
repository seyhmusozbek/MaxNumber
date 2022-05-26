using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Service.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaxNumber.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MaxNumberController : ControllerBase
    {
      
        private readonly ILogger<MaxNumberController> _logger;
        private INumberService _service;

        public MaxNumberController(ILogger<MaxNumberController> logger, INumberService service)
        {
            _logger = logger;
            _service = service;
        }

        [HttpPost]
        public int GetMaxNumber([FromBody] int[] numbers)
        {
            return _service.GetMax(numbers);
        }
    }
}
