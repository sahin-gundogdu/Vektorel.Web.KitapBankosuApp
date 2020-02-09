using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vektorel.Web.KitapBankosuApp.Models;

namespace Vektorel.Web.KitapBankosuApp.Areas.Admin.Controllers
{
    public class YazarController : Controller
    {
        // GET: Admin/Yazar
        public ActionResult Index()
        {
            using (KitapBankosuContext ctx = new KitapBankosuContext())
            {
                
                return View(ctx.Yazarlar.ToList());
            }
        }

        [HttpGet]
        public ActionResult YazarEkle()
        {
            return View();
        }

        [HttpPost]
        public ActionResult YazarEkle(FormCollection f)
        {
            using(KitapBankosuContext ctx = new KitapBankosuContext())
            {
                Yazar y = new Yazar();
                y.YazarAd = f["YazarAd"];
                y.YazarSoyad = f["YazarSoyad"];
                y.DogumTarih = Convert.ToDateTime(f["DogumTarih"]);
                ctx.Yazarlar.Add(y);
                ctx.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        public ActionResult YazarDetay(int? id)
        {
            using (KitapBankosuContext ctx = new KitapBankosuContext())
            {
                return View(ctx.Yazarlar.Find(id));
            }
        }
    }
}