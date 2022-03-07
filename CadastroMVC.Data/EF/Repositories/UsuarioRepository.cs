using CadastroMVC.Domain.Contratos.REpositorios;
using CadastroMVC.Domain.Entities;
using System.Linq;

namespace CadastroMVC.Data.EF.Repositories
{
    public class UsuarioRepository : RepositoryEf<Usuario>, IUsuarioRepository
    {
        public UsuarioRepository(DbContexto ctx) : base(ctx)
        {
        }

        public Usuario Get(string email)
        {
            return _ctx.Usuarios.FirstOrDefault(u=>u.Email.ToLower()==email.ToLower());
        }
    }
}
