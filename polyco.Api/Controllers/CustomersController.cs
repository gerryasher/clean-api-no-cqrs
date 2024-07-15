using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using polyco.Application.Interfaces;

namespace polyco.Api.Controllers
{
    [Route("[controller]")]
    public class CustomersController : Controller
    {
        private readonly ICustomersService _customerService;

        public CustomersController(ICustomersService customerService)
        {
            _customerService = customerService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var customers = await _customerService.GetAllAsync();
            return Ok(customers);
        }
    }
}