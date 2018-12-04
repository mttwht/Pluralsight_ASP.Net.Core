using Microsoft.EntityFrameworkCore;
using OdeToFood.Models;

namespace OdeToFood.Data
{
    public class OdeToFoodDbContext : DbContext
    {
        public OdeToFoodDbContext(DbContextOptions options)
            : base(options)
        {

        }

        public DbSet<Restaurant> Restaurants { get; set; }
    }
}
