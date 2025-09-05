using System.Linq;
using System.Web.Mvc;
using SehirTanitimSon.Models;

namespace SehirTanitimSon.Controllers
{
    [Authorize]
    public class TuristikYerController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        public ActionResult Index()
        {
            var yerler = db.TuristikYerler.Take(6).ToList();
            return View(yerler);
        }

        [Authorize(Roles = "Admin")]
        public ActionResult Ekle()
        {
            return View();
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public ActionResult Ekle(TuristikYer model)
        {
            if (ModelState.IsValid)
            {
                db.TuristikYerler.Add(model);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(model);
        }

        [Authorize(Roles = "Admin")]
        public ActionResult Duzenle(int id)
        {
            var yer = db.TuristikYerler.Find(id);
            if (yer == null)
                return HttpNotFound();

            return View(yer);
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public ActionResult Duzenle(TuristikYer model)
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
            var yer = db.TuristikYerler.Find(id);
            db.TuristikYerler.Remove(yer);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
