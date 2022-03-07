using CadastroLivroMVC.ViewModels.Produto.Index.Maps;
using CadastroMVC.Data.EF.Repositories;
using CadastroMVC.Data.EF.REpositories;
using CadastroMVC.Domain.Contratos.REpositorios;
using System.Web.Mvc;
using CadastroLivroMVC.ViewModels.Produto.AddEdit;
using CadastroLivroMVC.ViewModels.Produto.AddEdit.Maps;

namespace CadastroLivroMVC.Controllers
{
    [Authorize]
    public class ProdutosController : Controller
    {
        private readonly IProdutosRepository _ProdutoRepository;
        private readonly ITipoDeProdutoRepository _TipoDeProdutosRepository ;

        public ProdutosController(IProdutosRepository produtosRepository, 
            ITipoDeProdutoRepository TipoDeProdutosRepository)
        {
            _ProdutoRepository = produtosRepository;
            _TipoDeProdutosRepository = TipoDeProdutosRepository;
        }
        
        // GET: Produtos
        public ViewResult Index()
        {

            var produtos = _ProdutoRepository.Retornatodos().ToprodutoIndexVM();



            return View(produtos);
        }
        


        [HttpGet]
        public ViewResult AddEdit(int? Id)
        {
            
                var produto = new ProdutoAddEditVM();
                if (Id != null) //se o Id for diferente de 0, ele procura e edita o produto
                {
                    produto = _ProdutoRepository.Get((int)Id).ToProdutoAddEditVM();

                }
                var tipos = _TipoDeProdutosRepository.Retornatodos();
                ViewBag.Tipo = tipos;
                return View(produto);
            
        }

        [HttpPost]
        public ActionResult AddEdit(ProdutoAddEditVM produtoVM)
        {
            var produto = produtoVM.ToProduto();
            if (ModelState.IsValid)
            {
                if (produto.Id == 0)
                {
                    _ProdutoRepository.Add(produto);

                }
                else
                {
                    _ProdutoRepository.Edit(produto);
                }
              

                return RedirectToAction("Index");
            }

            var tipos = _TipoDeProdutosRepository.Retornatodos();
            ViewBag.Tipo = tipos;

            return View(produto);
        }

        public ActionResult DelProd(int id) {

            var produto = _ProdutoRepository.Get(id);
            if (produto == null)
            {
                return HttpNotFound();
            }
            _ProdutoRepository.Delete(produto);
            
            return null;
        }

        protected override void Dispose(bool disposing)
        {
            
        }

    }
}