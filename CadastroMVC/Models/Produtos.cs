using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CadastroLivroMVC.Models
{
    [Table(nameof(Produtos))]
    public class Produtos : Entity
    {
        
        [Required]
        [Column(TypeName ="Varchar")]
        [StringLength(100)]
        [Display(Name = "Nome ")]
        public string Nome { get; set; }
        [Required, Column(TypeName="Money")]
        [Display(Name = "Preço ")]
        public decimal Preco { get; set; }
        [Required]
        [Display(Name = "Quantidade "), Column("Quantidade")]
        public short Qtde { get; set; }
        [Display(Name = "Tipo do produto ")]
        public int TipoDeProdutoId { get; set; }
        [ForeignKey(nameof(TipoDeProdutoId))]
        public virtual TipoDeProduto TipoDeProduto { get; set; }
    }
}