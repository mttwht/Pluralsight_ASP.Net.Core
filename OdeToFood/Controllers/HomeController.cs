using Microsoft.AspNetCore.Mvc;
using OdeToFood.Models;

namespace OdeToFood.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //return Content("Home => Index");

            var model = new Restaurant { Id = 1, Name = "Token" };
            
            return new ObjectResult(model);
        }
    }
}
