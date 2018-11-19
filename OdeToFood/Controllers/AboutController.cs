using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace OdeToFood.Controllers
{
    //[Route("about")]
    //[Route("[controller]")]
    [Route("company/[controller]/[action]")]
    public class AboutController : Controller
    {
        //[Route("address")]
        //[Route("[action]")]
        public string Address()
        {
            return "Ireland";
        }
    }
}