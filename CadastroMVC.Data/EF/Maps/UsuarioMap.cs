using CadastroMVC.Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;

namespace CadastroMVC.Data.EF.Maps
{
    class UsuarioMap :EntityTypeConfiguration<Usuario>
    {
        public UsuarioMap()
        {
            //Tabela
            ToTable(nameof(Usuario));

            //PK
            HasKey(pk => pk.Id);

            //Colunas
            Property(c => c.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(c => c.Nome)
                .HasColumnType("varchar")
                .HasMaxLength(100)
                .IsRequired();

            Property(c => c.Email)
                .HasColumnType("varchar")
                .HasMaxLength(80)
                .IsRequired()
                .HasColumnAnnotation(IndexAnnotation.AnnotationName, new IndexAnnotation(new IndexAttribute("uq_dbo.Usuario.Email") {IsUnique=true }))
                ;

            Property(c => c.Senha)
                .HasColumnType("char")
                .HasMaxLength(88)
                .IsRequired();

            Property(c => c.DataCadastro);
        }

    }
}
