using System.Linq;
using System.Web.Mvc;
using SehirTanitimSon.Models;

namespace SehirTanitimSon.Controllers
{
    [Authorize]
    public class IlceController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        public ActionResult Index()
        {
            var ilceler = db.Ilceler.Take(6).ToList(); // En fazla 6 ilçe göster
            return View(ilceler);
        }

        [Authorize(Roles = "Admin")]
        public ActionResult Ekle()
        {
            return View();
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public ActionResult Ekle(Ilce model)
        {
            if (ModelState.IsValid)
            {
                db.Ilceler.Add(model);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(model);
        }

        [Authorize(Roles = "Admin")]
        public ActionResult Duzenle(int id)
        {
            var ilce = db.Ilceler.Find(id);
            return View(ilce);
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public ActionResult Duzenle(Ilce model)
        {
            if (ModelState.IsValid)
            {
                db.Entry(model).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(model);
        }

        [Authorize(Roles = "Admin")]
        public ActionResult Sil(int id)
        {
            var ilce = db.Ilceler.Find(id);
            db.Ilceler.Remove(ilce);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
