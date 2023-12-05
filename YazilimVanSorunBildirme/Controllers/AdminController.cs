using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using YazilimVanSorunBildirme.Models;

namespace YazilimVan.Controllers
{
    public class AdminController : Controller
    {
        private Bir_SikayetEntities db = new Bir_SikayetEntities();

        // GET: Basvurus
        public ActionResult Index()
        {
            var basvuru = db.Basvuru.Include(b => b.Sorun_turu).Include(b => b.Kurum).Include(b => b.Yetkililer);
            return View(basvuru.ToList());
        }

        // GET: Basvurus/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Basvuru basvuru = db.Basvuru.Find(id);
            if (basvuru == null)
            {
                return HttpNotFound();
            }
            return View(basvuru);
        }





        // GET: Cevaplars/Edit/5
        public ActionResult CevapEdit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cevaplar cevaplar = db.Cevaplar.Find(id);
            if (cevaplar == null)
            {
                return HttpNotFound();
            }
            ViewBag.basvuru_id = new SelectList(db.Basvuru, "basvuru_id", "konum", cevaplar.basvuru_id);
            return View(cevaplar);
        }

        // POST: Cevaplars/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CevapEdit([Bind(Include = "cevap_id,cevap_zamani,cevap_metni,basvuru_id,is_active")] Cevaplar cevaplar)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cevaplar).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.basvuru_id = new SelectList(db.Basvuru, "basvuru_id", "konum", cevaplar.basvuru_id);
            return View(cevaplar);
        }




        // GET: Basvurus/Edit/5
        public ActionResult DurumEdit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Basvuru basvuru = db.Basvuru.Find(id);
            if (basvuru == null)
            {
                return HttpNotFound();
            }
            ViewBag.sorun_turu_id = new SelectList(db.Sorun_turu, "sorun_turu_id", "sorun_turu1", basvuru.sorun_turu_id);
            ViewBag.kurum_id = new SelectList(db.Kurum, "kurum_id", "kurum_adi", basvuru.kurum_id);
            ViewBag.yetkili_id = new SelectList(db.Yetkililer, "yetkili_id", "ad", basvuru.yetkili_id);
            return View(basvuru);
        }

        // POST: Basvurus/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DurumEdit([Bind(Include = "basvuru_id,konum,basvuru_zamani,basvuru_durumu,dogrulanan_kisi,sorun_turu_id,kurum_id,yetkili_id,is_active")] Basvuru basvuru)
        {
            if (ModelState.IsValid)
            {
                db.Entry(basvuru).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.sorun_turu_id = new SelectList(db.Sorun_turu, "sorun_turu_id", "sorun_turu1", basvuru.sorun_turu_id);
            ViewBag.kurum_id = new SelectList(db.Kurum, "kurum_id", "kurum_adi", basvuru.kurum_id);
            ViewBag.yetkili_id = new SelectList(db.Yetkililer, "yetkili_id", "ad", basvuru.yetkili_id);
            return View(basvuru);
        }


        // GET: Basvurus/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Basvuru basvuru = db.Basvuru.Find(id);
            if (basvuru == null)
            {
                return HttpNotFound();
            }
            return View(basvuru);
        }

        // POST: Basvurus/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Basvuru basvuru = db.Basvuru.Find(id);
            db.Basvuru.Remove(basvuru);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
