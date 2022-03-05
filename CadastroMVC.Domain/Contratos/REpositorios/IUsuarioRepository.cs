using CadastroMVC.Domain.Entities;

namespace CadastroMVC.Domain.Contratos.REpositorios
{
    public interface IUsuarioRepository: IRepository<Usuario>
    {
        Usuario Get(string email);
    }
}
