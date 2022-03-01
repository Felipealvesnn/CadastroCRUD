using CadastroLivroMVC.Data;
using CadastroLivroMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CadastroLivroMVC.Controllers
{
    public class ProdutosController : Controller
    {
        private readonly DbContexto _ctx = new DbContexto();
        // GET: Produtos
        public ViewResult Index()
        {
          
              var produtos = _ctx.Produtos.ToList();
            

            return View(produtos);
        }
        


        [HttpGet]
        public ViewResult AddEdit(int? Id)
        {
            
                Produtos produto = new Produtos();
                if (Id != null) //se o Id for diferente de 0, ele procura e edita o produto
                {
                    produto = _ctx.Produtos.Find(Id);

                }
                var tipos = _ctx.TipoDeProdutos.ToList();
                ViewBag.Tipo = tipos;
                return View(produto);
            
        }

        [HttpPost]
        public ActionResult AddEdit(Produtos produto)
        {
            if (ModelState.IsValid)
            {
                if (produto.Id == 0)
                {
                    _ctx.Produtos.Add(produto);

                }
                else
                {
                    _ctx.Entry(produto).State = System.Data.Entity.EntityState.Modified;
                }
                _ctx.SaveChanges();

                return RedirectToAction("Index");
            }

            var tipos = _ctx.TipoDeProdutos.ToList();
            ViewBag.Tipo = tipos;

            return View(produto);
        }

        public ActionResult DelProd(int id) {

            var produto = _ctx.Produtos.Find(id);
            if (produto == null)
            {
                return HttpNotFound();
            }
            _ctx.Produtos.Remove(produto);
            _ctx.SaveChanges();
            return null;
        }

        protected override void Dispose(bool disposing)
        {
            _ctx.Dispose();
        }
    }
}