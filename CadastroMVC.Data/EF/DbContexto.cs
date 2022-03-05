using CadastroMVC.Domain.Entities;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace CadastroMVC.Data.EF
{
    public class DbContexto : DbContext
    {
        public DbContexto() : base("StoreConn")

        {
            Database.SetInitializer(new DbInitializer());

        }
        public DbSet<Produtos> Produtos { get; set; }
        public DbSet<TipoDeProduto> TipoDeProdutos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            //modelBuilder.Properties<string>().Configure(c => c.HasMaxLength(100));
            modelBuilder.Configurations.Add(new Maps.ProdutoMap());
            modelBuilder.Configurations.Add(new Maps.TipoDeProdutoMap());
            modelBuilder.Configurations.Add(new Maps.UsuarioMap());
        }

    }
}
