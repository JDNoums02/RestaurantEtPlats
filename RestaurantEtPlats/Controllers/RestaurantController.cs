using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestaurantEtPlats.Models;
using RestaurantEtPlats.ViewModels;

namespace RestaurantEtPlats.Controllers
{
    public class RestaurantController : Controller
    {
        public IList<Restaurant> _Restaurants = GenererRestaurants();
        public IList<Plat> _Plats = PlatController.GenererPlats();

        // GET: RestaurantController
        [Route("restaurants")]
        [Route("restaurants/index")]
        public ActionResult Index()
        {
            var resto = new RestaurantVM();
            resto.Restaurants = _Restaurants.OrderBy(x => x.Nom).ToList();
            foreach (var restaurant in _Restaurants)
            {
                if (resto.RestaurantNbPlats.ContainsKey(restaurant.Id))
                {
                    // resto.RestaurantNbPlats[restaurant.Id] += 1;
                    foreach (var plat in _Plats)
                    {
                        if (plat.RestaurantId == restaurant.Id)
                        {
                            resto.RestaurantNbPlats[restaurant.Id] += 1;
                        }
                    }
                }
                else
                {
                    resto.RestaurantNbPlats.Add(restaurant.Id, 0);
                    foreach (var plat in _Plats)
                    {
                        if (plat.RestaurantId == restaurant.Id)
                        {
                            resto.RestaurantNbPlats[restaurant.Id] += 1;
                        }
                    }
                }
            }


            return View(resto);
        }

        public static IList<Restaurant> GenererRestaurants()
        {
            return new List<Restaurant>
{
    new Restaurant { Id = 1, Nom = "Pizzeria Bella", Adresse = "10 Rue des Pâtes, Paris", Telephone = "01 23 45 67 89", Cuisine = "Italienne", Note = 4.5, Ville = "Paris" },
    new Restaurant { Id = 2, Nom = "Bistro du Marché", Adresse = "25 Rue de la Liberté, Lyon", Telephone = "04 56 78 90 12", Cuisine = "Française", Note = 4.7, Ville = "Lyon" },
    new Restaurant { Id = 3, Nom = "Sushi Zen", Adresse = "12 Rue du Japon, Marseille", Telephone = "09 87 65 43 21", Cuisine = "Japonaise", Note = 4.2, Ville = "Marseille" },
    new Restaurant { Id = 4, Nom = "Tacos del Sol", Adresse = "8 Avenida de la Libertad, Barcelone", Telephone = "93 123 45 67", Cuisine = "Mexicaine", Note = 4.3, Ville = "Barcelone" },
    new Restaurant { Id = 5, Nom = "Jardin de Provence", Adresse = "30 Boulevard de la Mer, Nice", Telephone = "04 93 55 78 90", Cuisine = "Méditerranéenne", Note = 4.8, Ville = "Nice" },
    new Restaurant { Id = 6, Nom = "Table de l'Inde", Adresse = "15 Rue des Épices, Toulouse", Telephone = "05 61 23 45 67", Cuisine = "Indienne", Note = 4.4, Ville = "Toulouse" },
    new Restaurant { Id = 7, Nom = "Grill de la Côte", Adresse = "5 Quai des Pêcheurs, Nantes", Telephone = "02 40 67 89 01", Cuisine = "Française", Note = 4.6, Ville = "Nantes" }
};

        }
    }
}
