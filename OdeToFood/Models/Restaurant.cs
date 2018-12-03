using System.ComponentModel.DataAnnotations;

namespace OdeToFood.Models
{
    public class Restaurant
    {
        public int Id { get; set; }

        [Display(Name="Restaurant name")]
        [Required, MaxLength(80)]
        public string Name { get; set; }

        [Display(Name="Primary cuisine")]
        [Required]
        public CuisineType Cuisine { get; set; }
    }
}
