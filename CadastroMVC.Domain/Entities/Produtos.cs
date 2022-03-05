namespace CadastroMVC.Domain.Entities
{
    public class Produtos : Entity
    {


        public string Nome { get; set; }

        public decimal Preco { get; set; }

        public short Qtde { get; set; }

        public int TipoDeProdutoId { get; set; }

        public virtual TipoDeProduto TipoDeProduto { get; set; }
    }
}
