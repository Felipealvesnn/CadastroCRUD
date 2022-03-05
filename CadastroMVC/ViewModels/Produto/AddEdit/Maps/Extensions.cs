using CadastroMVC.Domain.Entities;

namespace CadastroLivroMVC.ViewModels.Produto.AddEdit.Maps
{
    public static class Extensions
    {
        public static ProdutoAddEditVM ToProdutoAddEditVM(this Produtos model)
        {

            return new ProdutoAddEditVM()
            {

                Id = model.Id,
                Nome = model.Nome,
                Preco = model.Preco,
                TipoDeProdutoId = model.TipoDeProdutoId,
                Qtde = model.Qtde,
                DataCadastro = model.DataCadastro

            };

        }
        public static Produtos ToProduto(this ProdutoAddEditVM model)
        {
            return new Produtos()
            {
                Id = model.Id,
                Nome = model.Nome,
                Preco = model.Preco,
                TipoDeProdutoId = model.TipoDeProdutoId,
                Qtde = model.Qtde,
                DataCadastro = model.DataCadastro
            };

        }
    }
}