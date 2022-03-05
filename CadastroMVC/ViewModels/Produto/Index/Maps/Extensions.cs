using CadastroMVC.Domain.Entities;
using System.Collections.Generic;
using System.Linq;

namespace CadastroLivroMVC.ViewModels.Produto.Index.Maps
{
    public static class Extensions
    {
        public static IEnumerable<ProdutoIndexVM> ToprodutoIndexVM(this IEnumerable<Produtos> data) { 

        return data.Select(p => new ProdutoIndexVM()
        {
            Id = p.Id,
            Nome = p.Nome,
            Preco = p.Preco,
            Tipo = p.TipoDeProduto.Nome,
            Qtde = p.Qtde,
            DataCadastro = p.DataCadastro
        });
        }
    }
}