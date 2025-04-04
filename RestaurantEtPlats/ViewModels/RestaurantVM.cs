using RestaurantEtPlats.Models;

namespace RestaurantEtPlats.ViewModels
{
    public class RestaurantVM
    {
        public IList<Restaurant> Restaurants { get; set; }  

        public IDictionary<int, int> RestaurantNbPlats = new Dictionary<int, int>();
    }
}
