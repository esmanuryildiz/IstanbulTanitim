using System.Linq;
using System.Web.Mvc;
using SehirTanitimSon.Models;

namespace SehirTanitimSon.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        public ActionResult Index()
        {
            var sliders = db.Sliders.ToList(); // Veritabanından slider verilerini al
            return View(sliders);              // View'e gönder
        }
        public ActionResult AddSampleSlider()
        {
            db.Sliders.Add(new Slider
            {
                Title = "İstanbul",
                ImageUrl = "https://images.pexels.com/photos/1549326/pexels-photo-1549326.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=2",
                Description = "Tarihi yarımadadan bir kare."
            });

            db.Sliders.Add(new Slider
            {
                Title = "İstanbul",
                ImageUrl = "https://images.pexels.com/photos/3684396/pexels-photo-3684396.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=2",
                Description = "Galata Kulesi"
            });

            db.Sliders.Add(new Slider
            {
                Title = "İstanbul",
                ImageUrl = "https://images.pexels.com/photos/57553/pexels-photo-57553.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=2",
                Description = "İstanbul Boğazı"
            });

            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }

  

    }
