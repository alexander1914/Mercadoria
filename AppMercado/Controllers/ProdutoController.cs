using AppMercado.Context;
using AppMercado.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace AppMercado.Controllers
{
    public class ProdutoController : Controller
    {
        private ProdutoContext db = new ProdutoContext();

        // GET: Produto
        public ActionResult Index()
        {
            return View(db.Produtos.ToList());
        }

        // GET: Produto/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            Produto produto = db.Produtos.Find(id);
            if (produto == null)
                return HttpNotFound();
            return View(produto);
        }

        // GET: Produto/Create
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        // POST: Produto/Create
        [HttpPost]
        public ActionResult Create(Produto produto)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.Produtos.Add(produto);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(produto);
                
            }
            catch
            {
                return View();
            }
        }

        // GET: Produto/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            Produto produto = db.Produtos.Find(id);
            if (produto == null)
                return HttpNotFound();
            return View(produto);
        }

        // POST: Produto/Edit/5
        [HttpPost]
        public ActionResult Edit(Produto produto)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.Entry(produto).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(produto);
            }
            catch
            {
                return View();
            }
        }

        // GET: Produto/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            Produto produto = db.Produtos.Find(id);
            if (produto == null)
                return HttpNotFound();
            return View(produto);
        }

        // POST: Produto/Delete/5
        [HttpPost]
        public ActionResult Delete(int? id, Produto prod)
        {
            try
            {
                Produto produto = new Produto();
                if (ModelState.IsValid)
                {   if (id == null)
                        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                    produto = db.Produtos.Find(id);
                    if (produto == null)
                        return HttpNotFound();
                    db.Produtos.Remove(produto);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(produto);
            }
            catch
            {
                return View();
            }
        }
    }
}
