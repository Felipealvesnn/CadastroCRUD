using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CadastroLivroMVC.Models
{
    public class LoginVm
    {
        [Required(ErrorMessage = "O {0} é obrigatório")]
        [StringLength(40, ErrorMessage = "O Limite do {0} é de {1} caracteres")]
        [RegularExpression(@"([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)", ErrorMessage = "Email inválido")]
        public string Email { get; set; }


        [Required(ErrorMessage = "A {0} é obrigatória")]
        [StringLength(40, ErrorMessage = "O Limite da {0} é de {1} caracteres")]
        public string Senha { get; set; }

        public bool PermanecerLogado { get; set; }

        public string ReturnURL { get; set; }
    }
}