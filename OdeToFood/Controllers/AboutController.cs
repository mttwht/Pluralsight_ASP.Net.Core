using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace OdeToFood.Controllers
{
    public class AboutController : Controller
    {
        public string Address()
        {
            return "Ireland";
        }
    }
}