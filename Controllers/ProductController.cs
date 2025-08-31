using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace fisrtAPIDotet.Controllers
{
    [Route("api/[controller]")]
    public class ProductController : Controller
    {
        [HttpGet]
        public string Get()
        {
            return "Http Get Request";

        }

        [HttpGet("Categories")]
        public string GetCategories()
        {
            return "Http get Request2";
        }

        [HttpPost()]
        public string Create()
        {
            return " Http Post Request";
        }

        [HttpPut("{id}")]
        public string Edit(int id)
        {
            return "Http Put Request";
        }

        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return "Http Delete Request";
        }
       
    }
}




