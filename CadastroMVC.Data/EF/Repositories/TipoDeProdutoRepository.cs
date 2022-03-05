using CadastroMVC.Domain.Contratos.REpositorios;
using CadastroMVC.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroMVC.Data.EF.Repositories
{
   public  class TipoDeProdutoRepository :RepositoryEf<TipoDeProduto>, ITipoDeProdutoRepository
    {
    }
}
