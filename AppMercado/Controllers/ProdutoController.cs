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

        // GET: Produto/Detalhes do Produto
        public ActionResult Details(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            Produto produto = db.Produtos.Find(id);
            if (produto == null)
                return HttpNotFound();
            return View(produto);
        }

        // GET: Produto/Criando o Produto
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        // POST: Produto/Criando o Produto
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

        // GET: Produto/Atualizando Produto
        public ActionResult Edit(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            Produto produto = db.Produtos.Find(id);
            if (produto == null)
                return HttpNotFound();
            return View(produto);
        }

        // POST: Produto/Atualizando Produto
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

        // GET: Produto/Excluindo o Produto
        public ActionResult Delete(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            Produto produto = db.Produtos.Find(id);
            if (produto == null)
                return HttpNotFound();
            return View(produto);
        }

        // POST: Produto/Excluindo o Produto
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
