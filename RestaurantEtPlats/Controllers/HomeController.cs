using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using RestaurantEtPlats.Models;
using RestaurantEtPlats.ViewModels;

namespace RestaurantEtPlats.Controllers
{
    public class HomeController : Controller
    {
        private IList<Restaurant> Restaurants = RestaurantController.GenererRestaurants();
        private IList<Plat> Plats = PlatController.GenererPlats();

        [Route("/")]
        [Route("/home")]
        [Route("/home/index")]
        public IActionResult Index()
        {
            var restosPlats = new HomeVM();
            restosPlats.Restaurants=Restaurants.OrderByDescending(x => x.Note).Take(3).ToList();
            restosPlats.Plats=Plats.OrderBy(x=>x.Prix).Take(3).ToList();
            return View(restosPlats);
        }
      


       

        
    }
}
