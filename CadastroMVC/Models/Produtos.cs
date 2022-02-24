using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CadastroLivroMVC.Models
{
    public class Produtos
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "Nome ")]
        public string Nome { get; set; }
        [Required]
        [Display(Name = "Preço ")]
        public decimal Preco { get; set; }
        [Required]
        [Display(Name = "Tipo ")]
        public string Tipo { get; set; }
        [Required]
        [Display(Name = "Quantidade ")]
        public short Qtde { get; set; }
        public DateTime DataCadastro { get; set; } = DateTime.Now;
    }
}