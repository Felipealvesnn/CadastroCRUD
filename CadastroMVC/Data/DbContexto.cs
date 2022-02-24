using CadastroLivroMVC.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace CadastroLivroMVC.Data
{
    public class DbContexto : DbContext
    {
        public DbContexto() : base(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ProdutosDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
                        
        {
            Database.SetInitializer(new DbInitializer());

        }
        public DbSet<Produtos> Produtos { get; set; }
        


            protected override void OnModelCreating(DbModelBuilder modelBuilder)
            {
                modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

                modelBuilder.Properties<string>().Configure(c => c.HasMaxLength(100));
            }
        
    }
}