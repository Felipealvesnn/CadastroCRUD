using CadastroMVC.Domain.Entities;
using CadastroMVC.Domain.Helpers;
using System.Collections.Generic;
using System.Data.Entity;

namespace CadastroMVC.Data.EF
{
    internal class DbInitializer : CreateDatabaseIfNotExists<DbContexto>
    {
        protected override void Seed(DbContexto context)
        {
            var alimento = new TipoDeProduto() { Nome = "Alimento" };
            var Higiene = new TipoDeProduto() { Nome = "Higiene" };
            var Limpeza = new TipoDeProduto() { Nome = "Limpeza" };
            var Eletronico = new TipoDeProduto() { Nome = "Eletronico" };

            var produtos = new List<Produtos>() {
                new Produtos() { Nome = "Picanha", Preco = 70.5M, Qtde= 150, TipoDeProduto=alimento},
                new Produtos() { Nome = "Pasta de dente", Preco = 9.5M, Qtde= 250, TipoDeProduto=Higiene},
                new Produtos() { Nome = "Desinfetante", Preco = 8.99M, Qtde= 520, TipoDeProduto=Limpeza},
                new Produtos() { Nome = "Telefone sem fio", Preco = 125.15M, Qtde= 85, TipoDeProduto=Eletronico},
            };

            context.Produtos.AddRange(produtos);
            context.Usuarios.AddRange(
                new List<Usuario>() {

                    new Usuario() { Nome = "Felipe alves", Email = "felipe.@gmail.com", Senha = "123456".Encrypt() },
                    new Usuario() { Nome = "Felipe dois", Email = "felip2.@gmail.com", Senha = "123456".Encrypt() },


                });

            context.SaveChanges();

        }
    }
}
