using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OdeToFood.Models;

namespace OdeToFood.Services
{
    public class InMemoryRestaurantData : IRestaurantData
    {
        List<Restaurant> _restaurants;

        public InMemoryRestaurantData()
        {
            _restaurants = new List<Restaurant>
            {
                new Restaurant { Id = 1, Name = "Token" },
                new Restaurant { Id = 2, Name = "Home" },
                new Restaurant { Id=3, Name="Matt's kitchen" },
            };
        }

        public IEnumerable<Restaurant> GetAll() => _restaurants.OrderBy(r => r.Name);
    }
}
