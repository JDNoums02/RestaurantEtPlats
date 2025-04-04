using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestaurantEtPlats.Models;

namespace RestaurantEtPlats.Controllers
{
    public class PlatController : Controller
    {
        public IList<Plat> _Plats = GenererPlats();

        // GET: PlatController

        [Route("plats")]
        [Route("plats/index")]
        [Route("plats/{categorie?}")]
        public ActionResult Index(string? categorie)
        {
            var plats = _Plats.OrderBy(x => x.Nom).ToList();
            ViewBag.categorie = null;
            if (categorie != null)
            {
                ViewBag.categorie = categorie;
                var platsCategorie = plats.Where(x => x.Categorie.Equals(categorie)).ToList();
                if (platsCategorie.Any())
                {
                    return View(platsCategorie);
                }
            }
            return View(plats);
        }

        // GET: PlatController/Details/5
        [Route("details/{id:int}")]
        public ActionResult Details(int? id)

        {
            if (id != null)
            {
                var plat = _Plats.FirstOrDefault(x => x.Id == id);
                return plat == null ? NotFound() : View(plat);
            }


            return NotFound();
        }

        public static IList<Plat> GenererPlats()
        {
            return new List<Plat>
            {
                new Plat
                {
                    Id = 1,
                    Nom = "Pizza Margherita",
                    Prix = 8.50,
                    Categorie = "Pizzas",
                    CheminImage = "/images/pizzap.jpg",
                    RestaurantId = 1,
                },
                new Plat
                {
                    Id = 2,
                    Nom = "Pasta Carbonara",
                    Prix = 12.00,
                    Categorie = "Pâtes",
                    CheminImage = "/images/pates.jpg",
                    RestaurantId = 1,
                },
                new Plat
                {
                    Id = 3,
                    Nom = "Burger Classique",
                    Prix = 9.00,
                    Categorie = "Burgers",
                    CheminImage = "/images/burger.jpg",
                    RestaurantId = 2,
                },
                new Plat
                {
                    Id = 4,
                    Nom = "Ratatouille Provençale",
                    Prix = 11.50,
                    Categorie = "Végétarien",
                    CheminImage = "/images/salade.jpg",
                    RestaurantId = 3,
                },
                new Plat
                {
                    Id = 5,
                    Nom = "Tacos Mexicain",
                    Prix = 7.50,
                    Categorie = "Mexicain",
                    CheminImage = "/images/mexican.jpg",
                    RestaurantId = 2,
                },
                new Plat
                {
                    Id = 6,
                    Nom = "Salade César",
                    Prix = 8.00,
                    Categorie = "Salades",
                    CheminImage = "/images/salade.jpg",
                    RestaurantId = 6,
                },
                new Plat
                {
                    Id = 7,
                    Nom = "Sushi Rolls",
                    Prix = 15.00,
                    Categorie = "Sushis",
                    CheminImage = "/images/sushi.jpg",
                    RestaurantId = 4,
                },
                new Plat
                {
                    Id = 8,
                    Nom = "Steak Frites",
                    Prix = 18.00,
                    Categorie = "Viandes",
                    CheminImage = "/images/viande.jpg",
                    RestaurantId = 3,
                },
                new Plat
                {
                    Id = 9,
                    Nom = "Poulet Curry",
                    Prix = 13.00,
                    Categorie = "Indien",
                    CheminImage = "/images/poulet.jpg",
                    RestaurantId = 2,
                },
                new Plat
                {
                    Id = 9,
                    Nom = "Poulet Curry",
                    Prix = 13.00,
                    Categorie = "Indien",
                    CheminImage = "/images/poulet.jpg",
                    RestaurantId = 2,
                },
                new Plat
                {
                    Id = 10,
                    Nom = "Lasagne Bolognaise",
                    Prix = 12.50,
                    Categorie = "Pâtes",
                    CheminImage = "/images/pates.jpg",
                    RestaurantId = 6,
                },
                new Plat
                {
                    Id = 11,
                    Nom = "Paella de Mariscos",
                    Prix = 17.00,
                    Categorie = "Espagnol",
                    CheminImage = "/images/img1.jpg",
                    RestaurantId = 4,
                },
                new Plat
                {
                    Id = 12,
                    Nom = "Quiche Lorraine",
                    Prix = 9.50,
                    Categorie = "Quiches",
                    CheminImage = "/images/quiches.jpg",
                    RestaurantId = 3,
                },
                new Plat
                {
                    Id = 13,
                    Nom = "Soupe Pho",
                    Prix = 10.00,
                    Categorie = "Asiatique",
                    CheminImage = "/images/soupe.jpg",
                    RestaurantId = 5,
                },
                new Plat
                {
                    Id = 14,
                    Nom = "Côtelettes d'Agneau",
                    Prix = 20.00,
                    Categorie = "Viandes",
                    CheminImage = "/images/viande.jpg",
                    RestaurantId = 3,
                },
                new Plat
                {
                    Id = 15,
                    Nom = "Crêpes Suzette",
                    Prix = 6.50,
                    Categorie = "Desserts",
                    CheminImage = "/images/crepes.jpg",
                    RestaurantId = 1,
                },
            };
        }
    }
}
