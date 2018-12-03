using Microsoft.AspNetCore.Mvc;
using OdeToFood.Services;
using OdeToFood.ViewModels;

namespace OdeToFood.Controllers
{
    public class HomeController : Controller
    {
        private IRestaurantData _restaurantData;
        private IGreeter _greeter;

        public HomeController(IRestaurantData restaurantData,
                              IGreeter greeter)
        {
            _restaurantData = restaurantData;
            _greeter = greeter;
        }

        public IActionResult Index()
        {
            var model = new HomeIndexViewModel {
                Restaurants = _restaurantData.GetAll(),
                MessageOfTheDay = _greeter.GetMessageOfTheDay(),
            };

            return View(model);
        }

        public IActionResult Details(int id)
        {
            var model = _restaurantData.Get(id);

            if (model == null)
            {
                //return NotFound(123);
                return RedirectToAction(nameof(Index));
            }
            
            return View(model);
        }

        public IActionResult Create()
        {
            return View();
        }
    }
}
