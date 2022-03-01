using CadastroLivroMVC.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace CadastroLivroMVC.Data
{
    public class DbContexto : DbContext
    {
        public DbContexto() : base("StoreConn")
                        
        {
            Database.SetInitializer(new DbInitializer());

        }
        public DbSet<Produtos> Produtos { get; set; }
        public DbSet<TipoDeProduto> TipoDeProdutos { get; set; }



        protected override void OnModelCreating(DbModelBuilder modelBuilder)
            {
                modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

                modelBuilder.Properties<string>().Configure(c => c.HasMaxLength(100));
            }
        
    }
}