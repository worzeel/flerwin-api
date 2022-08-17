using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace flerwin_api.Controllers
{
    [ApiController]
    [Route("MyTest")]
    public class MyTestController : Controller
    {
        [HttpGet]
        public string Get()
        {
            return "asdf";
		}

        [HttpGet]
        [Route("two")]
        public string GetTwo()
        {
            return "this is two";
		} 
    }
}

