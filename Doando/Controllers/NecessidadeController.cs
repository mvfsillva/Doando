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
    public class NecessidadeController : Controller
    {
        private ModeloDados db = new ModeloDados();

        // GET: Necessidade
        public async Task<ActionResult> Index()
        {
            return View(await db.Necessidade.ToListAsync());
        }

        // GET: Necessidade/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Necessidade necessidade = await db.Necessidade.FindAsync(id);
            if (necessidade == null)
            {
                return HttpNotFound();
            }
            return View(necessidade);
        }

        // GET: Necessidade/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Necessidade/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "ID_NECESSIDADE,DESCRICAO,TITULO,PRIORIDADE,DATA,ID_ONG,CNPJ")] Necessidade necessidade)
        {
            if (ModelState.IsValid)
            {
                db.Necessidade.Add(necessidade);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(necessidade);
        }

        // GET: Necessidade/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Necessidade necessidade = await db.Necessidade.FindAsync(id);
            if (necessidade == null)
            {
                return HttpNotFound();
            }
            return View(necessidade);
        }

        // POST: Necessidade/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "ID_NECESSIDADE,DESCRICAO,TITULO,PRIORIDADE,DATA,ID_ONG,CNPJ")] Necessidade necessidade)
        {
            if (ModelState.IsValid)
            {
                db.Entry(necessidade).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(necessidade);
        }

        // GET: Necessidade/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Necessidade necessidade = await db.Necessidade.FindAsync(id);
            if (necessidade == null)
            {
                return HttpNotFound();
            }
            return View(necessidade);
        }

        // POST: Necessidade/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Necessidade necessidade = await db.Necessidade.FindAsync(id);
            db.Necessidade.Remove(necessidade);
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
