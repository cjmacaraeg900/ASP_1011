using Microsoft.AspNetCore.Mvc;
using ASP_101.Models;

namespace ASP_101.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var featuredPost = new List<FeaturedViewModel>
            {
                new FeaturedViewModel() {
                    Id = 1,
                    Header = "Characters",
                    Title = "Monkey D Luffy",
                    PostedDate =  DateTime.Now,
                    Description = "AKO AY HUMAHABA",
                    ImageUrl = "luffy.jpeg"
                },

                new FeaturedViewModel()
                {
                    Id = 2,
                     Header = "Videos",
                    Title = "Zoro",
                    PostedDate =  DateTime.Now,
                    Description = "AKO AY MAY ISPADA",
                    ImageUrl = "zoro.jpeg"
                }
            };

            return View(featuredPost);
        }

        public IActionResult About()
        {
            return View("About");
        }

        public IActionResult Privacy()
        {
            return View("Private");
        }

        public IActionResult CJ()
        {
            return View("CJ");
        }


    }

}

