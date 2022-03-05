using CadastroMVC.Domain.Contratos.REpositorios;
using CadastroMVC.Domain.Entities;
using System.Linq;

namespace CadastroMVC.Data.EF.Repositories
{
    public class UsuarioRepository : RepositoryEf<Usuario>, IUsuarioRepository
    {
        public Usuario Get(string email)
        {
            return _ctx.Usuarios.FirstOrDefault(u=>u.Email.ToLower()==email.ToLower());
        }
    }
}
