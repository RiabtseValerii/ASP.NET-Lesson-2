using Lesson_2.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Lesson_2.Controllers
{
    public class HomeController : Controller
    {

        public class City
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string PostalCode { get; set; }
            public string MainImageUrl { get; set; }
        }

        public List<City> cities = new List<City>
        {
            new City { Id = 1, Name = "Zhytomyr", PostalCode = "10000", MainImageUrl = "https://images.trvl-media.com/place/10685/bc1eec0c-0473-457e-91d6-83c3f0307da0.jpg" },
            new City { Id = 2, Name = "Kyiv", PostalCode = "01001", MainImageUrl = "https://content.r9cdn.net/rimg/dimg/27/bb/1e63bfbb-city-15139-1645cdf896a.jpg?width=1366&height=768&crop=true" },
            new City { Id = 3, Name = "Dnipro", PostalCode = "49000", MainImageUrl = "https://ostrava.cz/en/o-meste/international-relations/international-relations/dnipro-1.jpg/@@images/image-1000-56b266f7ad45e8afab0c789891a4be0a.jpeg" },
            new City { Id = 4, Name = "Lviv", PostalCode = "79000", MainImageUrl = "https://www.throughatravellens.com/wp-content/uploads/2024/06/lviv_weekend_itinerary_2.jpg" },
            new City { Id = 5, Name = "Uzhhorod", PostalCode = "88000", MainImageUrl = "https://website-cms.itct.com.ua/uploads/01_Bud_yake_foto_Uzhgorodu_16x9_9586df9f09.jpg" },
            new City { Id = 6, Name = "Odessa", PostalCode = "65000", MainImageUrl = "https://articles.unesco.org/sites/default/files/2023-07/MicrosoftTeams-image30d64838a9a759d3a643f2d1671423590239f1a53a5df87e059ad542782978fa.png" },
            new City { Id = 7, Name = "Kharkiv", PostalCode = "61000", MainImageUrl = "https://upload.wikimedia.org/wikipedia/commons/2/2c/%D0%91%D1%83%D0%B4%D0%B8%D0%BD%D0%BE%D0%BA_%D0%B4%D0%B5%D1%80%D0%B6%D0%BF%D1%80%D0%BE%D0%BC%D0%B8%D1%81%D0%BB%D0%BE%D0%B2%D0%BE%D1%81%D1%82%D1%96%2C_%D0%A5%D0%B0%D1%80%D0%BA%D1%96%D0%B2_DJI_0057.jpg?utm_source=en.wikipedia.org&utm_campaign=index&utm_content=original" },
            new City { Id = 8, Name = "Zaporizhzhia", PostalCode = "69000", MainImageUrl = "https://zaporizhzhia.city/assets/img/main-slide2.jpg" },
            new City { Id = 9, Name = "Poltava", PostalCode = "36000", MainImageUrl = "https://pohcdn.com/sites/default/files/styles/big_gallery_image/public/text_gallery/poltava-3.jpg" },
            new City { Id = 10, Name = "Lutsk", PostalCode = "43000", MainImageUrl = "https://www.missionzeroacademy.eu/wp-content/uploads/2024/12/unnamed-18-1024x768.jpg" }
        };

        public IActionResult PostalCode()
        {
            var ObjectID = Request.RouteValues["id"];
            if (ObjectID != null)
            {
                string city = ObjectID.ToString();
                if (cities.Any(c => c.Name == city))
                {
                    var selectedCity = cities.First(c => c.Name == city);
                    ViewBag.City = selectedCity;
                }
                else
                {
                    ViewBag.PostalCode = "City not found";
                }
            }
            return View();
        }

        public IActionResult Index()
        {
            ViewBag.Cities = cities;
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
