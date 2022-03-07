using CadastroMVC.Data.EF.Repositories;
using CadastroMVC.Domain.Entities;
using CadastroMVC.Domain.Contratos.REpositorios;
using System.Collections.Generic;
using System.Linq;

namespace CadastroMVC.Data.EF.REpositories
{
    public class ProdutoRepositoryEf : RepositoryEf<Produtos>, IProdutosRepository
    {
        public ProdutoRepositoryEf(DbContexto ctx) : base(ctx)
        {
        }

        public IEnumerable<Produtos> GetByNameContains(string contais)
        {
            return _ctx.Produtos.Where(p=>p.Nome.Contains(contais));
        }
    }

}
