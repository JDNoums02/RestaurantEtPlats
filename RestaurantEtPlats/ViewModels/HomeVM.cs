using RestaurantEtPlats.Models;

namespace RestaurantEtPlats.ViewModels
{
    public class HomeVM
    {
        public IList<Restaurant> Restaurants { get; set; }
        public IList<Plat> Plats { get; set; }
    }
}
