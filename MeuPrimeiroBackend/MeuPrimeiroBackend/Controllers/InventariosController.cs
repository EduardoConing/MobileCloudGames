using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MeuPrimeiroBackend.Models;
using MeuPrimeiroBackend.Models.Contexto;

namespace MeuPrimeiroBackend.Controllers
{
    public class InventariosController : Controller
    {
        private MeuContexto db = new MeuContexto();

        // GET: Inventarios
        public ActionResult Index()
        {
            var inventarios = db.Inventarios.Include(i => i._Jogador);
            return View(inventarios.ToList());
        }

        // GET: Inventarios/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Inventario inventario = db.Inventarios.Find(id);
            if (inventario == null)
            {
                return HttpNotFound();
            }
            return View(inventario);
        }

        // GET: Inventarios/Create
        public ActionResult Create()
        {
            ViewBag.JogadorID = new SelectList(db.Jogadors, "JogadorID", "Nickname");
            return View();
        }

        // POST: Inventarios/Create
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "InventarioID,JogadorID")] Inventario inventario)
        {
            if (ModelState.IsValid)
            {
                db.Inventarios.Add(inventario);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.JogadorID = new SelectList(db.Jogadors, "JogadorID", "Nickname", inventario.JogadorID);
            return View(inventario);
        }

        // GET: Inventarios/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Inventario inventario = db.Inventarios.Find(id);
            if (inventario == null)
            {
                return HttpNotFound();
            }
            ViewBag.JogadorID = new SelectList(db.Jogadors, "JogadorID", "Nickname", inventario.JogadorID);
            return View(inventario);
        }

        // POST: Inventarios/Edit/5
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "InventarioID,JogadorID")] Inventario inventario)
        {
            if (ModelState.IsValid)
            {
                db.Entry(inventario).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.JogadorID = new SelectList(db.Jogadors, "JogadorID", "Nickname", inventario.JogadorID);
            return View(inventario);
        }

        // GET: Inventarios/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Inventario inventario = db.Inventarios.Find(id);
            if (inventario == null)
            {
                return HttpNotFound();
            }
            return View(inventario);
        }

        // POST: Inventarios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Inventario inventario = db.Inventarios.Find(id);
            db.Inventarios.Remove(inventario);
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
