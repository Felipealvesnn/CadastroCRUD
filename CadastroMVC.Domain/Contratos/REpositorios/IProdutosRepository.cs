using CadastroMVC.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroMVC.Domain.Contratos.REpositorios
{
    public interface IProdutosRepository:IRepository<Produtos>
    {
        IEnumerable<Produtos> GetByNameContains(string contais);
        
    }
}
