using CadastroLivroMVC.Models;
using System.Collections.Generic;
using System.Data.Entity;

namespace CadastroLivroMVC.Data
{
    internal class DbInitializer : CreateDatabaseIfNotExists<DbContexto>
    {
        protected override void Seed(DbContexto context)
        {
            var produtos = new List<Produtos>() {
                new Produtos() { Nome = "Picanha", Preco = 70.5M, Qtde= 150, Tipo = "Alimento"},
                new Produtos() { Nome = "Pasta de dente", Preco = 9.5M, Qtde= 250, Tipo = "Higiene"},
                new Produtos() { Nome = "Desinfetante", Preco = 8.99M, Qtde= 520, Tipo = "Limpeza"},
                new Produtos() { Nome = "Telefone sem fio", Preco = 125.15M, Qtde= 85, Tipo = "Eletronico"},
            };

            context.Produtos.AddRange(produtos);
            context.SaveChanges();

        }
    }
}