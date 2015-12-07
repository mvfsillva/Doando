using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Doando.Models;

namespace Doando.Controllers
{
    public class OngController : Controller
    {
        private ModeloDados db = new ModeloDados();

        // GET: Ong
        public async Task<ActionResult> Index()
        {
            return View(await db.Ong.ToListAsync());
        }

        // GET: Ong/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ong ong = await db.Ong.FindAsync(id);
            if (ong == null)
            {
                return HttpNotFound();
            }
            return View(ong);
        }

        // GET: Ong/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Ong/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "ID_ONG,CNPJ,NOME,SITE,EMAIL,ENDERECO")] Ong ong)
        {
            if (ModelState.IsValid)
            {
                db.Ong.Add(ong);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(ong);
        }

        // GET: Ong/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ong ong = await db.Ong.FindAsync(id);
            if (ong == null)
            {
                return HttpNotFound();
            }
            return View(ong);
        }

        // POST: Ong/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "ID_ONG,CNPJ,NOME,SITE,EMAIL,ENDERECO")] Ong ong)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ong).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(ong);
        }

        // GET: Ong/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ong ong = await db.Ong.FindAsync(id);
            if (ong == null)
            {
                return HttpNotFound();
            }
            return View(ong);
        }

        // POST: Ong/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Ong ong = await db.Ong.FindAsync(id);
            db.Ong.Remove(ong);
            await db.SaveChangesAsync();
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
