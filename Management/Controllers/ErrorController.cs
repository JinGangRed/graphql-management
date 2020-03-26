using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Extensions.Attribute;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Management.Controllers
{
    [Route("api/[controller]")]
    public class ErrorController : Controller
    {
        // GET: api/<controller>
        [HiddenAPI]
        [HttpGet]
        public string Get()
        {
            return "发生异常";
        }
    }
}
