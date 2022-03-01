using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CadastroLivroMVC.Models
{
    [Table(nameof(TipoDeProduto))]
    public class TipoDeProduto : Entity
    {
        
        [Required, Column(TypeName ="Varchar"), StringLength(100)]
        public string Nome { get; set; }
        public virtual ICollection<Produtos> Produtos { get; set; }
        
    }
}