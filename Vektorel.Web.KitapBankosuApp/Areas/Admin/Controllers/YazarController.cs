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
        KitapBankosuContext ctx = new KitapBankosuContext();
        // GET: Admin/Yazar
        public ActionResult Index()
        {
            return View(ctx.Yazarlar.ToList());
        }

        [HttpGet]
        public ActionResult YazarEkle()
        {
            return View();
        }

        [HttpPost]
        public ActionResult YazarEkle(FormCollection f)
        {
            Yazar y = new Yazar();
            y.YazarAd = f["YazarAd"];
            y.YazarSoyad = f["YazarSoyad"];
            y.DogumTarih = Convert.ToDateTime(f["DogumTarih"]);
            ctx.Yazarlar.Add(y);
            ctx.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult YazarDetay(int? id)
        {
            return View(ctx.Yazarlar.Find(id));
        }

        public ActionResult YazarSil(int? id)
        {
            Yazar yz = ctx.Yazarlar.Find(id);
            ctx.Yazarlar.Remove(yz);
            ctx.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                ctx.Dispose();
            }
        }
    }
}