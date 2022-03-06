using CadastroLivroMVC.Controllers;
using CadastroLivroMVC.ViewModels.Produto.Index;
using CadastroMVC.Domain.Contratos.REpositorios;
using CadastroMVC.Domain.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace CadastroMVC.Tests.MVC.Controller
{
    [TestClass, TestCategory("Controller/ProdutosController")]
    public class ProdutosControllerTest
    {

        //dado um ProdutosController

        [TestMethod]
        public void MetodoIndexDevaraRetornarAViewComOModeloCorreto()
        {
            //arrange
            var produtosController =
                new ProdutosController(new ProdutoRepositoryFake(), new TipoDeProdutoRepositoryFake());

            //act
            var result = produtosController.Index();
            var model = result.Model as IEnumerable<ProdutoIndexVM>;

            //assert
            Assert.AreEqual(typeof(ViewResult), result.GetType());
            Assert.AreEqual(3, model.Count());
            Assert.IsNotNull(model);
        }


    }

    public class ProdutoRepositoryFake : IProdutosRepository
    {
        public void Add(Produtos entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Produtos entity)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void Edit(Produtos entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Produtos> Retornatodos()
        {
            var tipo1 = new TipoDeProduto() { Id = 1, Nome = "Tipo 1" };
            var tipo2 = new TipoDeProduto() { Id = 2, Nome = "Tipo 2" };
            return new List<Produtos>() {
                new Produtos(){ Id= 1, Nome = "Produto 1", Preco = 1, Qtde = 10, TipoDeProdutoId = tipo1.Id, TipoDeProduto = tipo1  },
                new Produtos(){ Id= 2, Nome = "Produto 2", Preco = 2, Qtde = 20, TipoDeProdutoId = tipo2.Id, TipoDeProduto = tipo2  },
                new Produtos(){ Id= 3, Nome = "Produto 3", Preco = 3, Qtde = 30, TipoDeProdutoId = tipo1.Id, TipoDeProduto = tipo1  },
            };
        }

        public Produtos Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Produtos> GetByNameContains(string contains)
        {
            throw new NotImplementedException();
        }
    }
    public class TipoDeProdutoRepositoryFake : ITipoDeProdutoRepository
    {
        public void Add(TipoDeProduto entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(TipoDeProduto entity)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void Edit(TipoDeProduto entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TipoDeProduto> Retornatodos()
        {
            throw new NotImplementedException();
        }

        public TipoDeProduto Get(int id)
        {
            throw new NotImplementedException();
        }
    }
}
