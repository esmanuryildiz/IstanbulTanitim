using System.Linq;
using System.Web.Mvc;
using SehirTanitimSon.Models;

namespace SehirTanitimSon.Controllers
{
    [Authorize]
    public class NufusController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // Herkese açık liste
        public ActionResult Index()
        {
            var veri = db.Nufuslar.OrderByDescending(n => n.Yil).ToList();
            return View(veri);
        }

        // Ekleme - sadece admin
        [Authorize(Roles = "Admin")]
        public ActionResult Ekle()
        {
            return View();
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public ActionResult Ekle(Nufus nufus)
        {
            if (ModelState.IsValid)
            {
                db.Nufuslar.Add(nufus);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(nufus);
        }

        // Silme
        [Authorize(Roles = "Admin")]
        public ActionResult Sil(int id)
        {
            var veri = db.Nufuslar.Find(id);
            if (veri != null)
            {
                db.Nufuslar.Remove(veri);
                db.SaveChanges();
            }

            return RedirectToAction("Index");
        }

        // Güncelleme
        [Authorize(Roles = "Admin")]
        public ActionResult Duzenle(int id)
        {
            var veri = db.Nufuslar.Find(id);
            return View(veri);
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public ActionResult Duzenle(Nufus nufus)
        {
            if (ModelState.IsValid)
            {
                db.Entry(nufus).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(nufus);
        }
    }
}
