using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DellCustomerServices.Controllers
{
    [Route("api/[controller]")]
    public class CustomersController : Controller
    {

        [Authorize]
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "Dell Laptop Support" , "Dell Desktop Support" , "Dell Hardware Support" };
        }


        [HttpGet("{id}")]
        public string Get(int id)
        {
            return $"Your Requested for the Service Request  - {id}";
        }
    }
}
