using System.Collections.Generic;

namespace CadastroMVC.Domain.Entities
{
    public class TipoDeProduto : Entity
    {

        
        public string Nome { get; set; }
        public virtual ICollection<Produtos> Produtos { get; set; }

    }
}
