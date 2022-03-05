using CadastroMVC.Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace CadastroMVC.Data.EF.Maps
{
    public class ProdutoMap: EntityTypeConfiguration<Produtos>
    {
        public ProdutoMap()
        {
            //Tabela
            ToTable(nameof(Produtos));

            //PK
            HasKey(pk => pk.Id);

            //Colunas
            Property(c => c.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(c => c.Nome)
                .HasColumnType("varchar")
                .HasMaxLength(100)
                .IsRequired();

            Property(c => c.Preco)
                .HasColumnType("money")
                .HasColumnName("Preco");

            Property(c => c.Qtde)
                .HasColumnName("Quantidade");

            Property(c => c.TipoDeProdutoId);

            Property(c => c.DataCadastro);

            //Relacionamento
            HasRequired(prod => prod.TipoDeProduto)
                .WithMany(tipo => tipo.Produtos)
                .HasForeignKey(fk => fk.TipoDeProdutoId);

        }

    }
}
