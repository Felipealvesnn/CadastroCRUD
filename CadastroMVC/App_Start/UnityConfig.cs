using CadastroMVC.Data.EF.Repositories;
using CadastroMVC.Data.EF.REpositories;
using CadastroMVC.Domain.Contratos.REpositorios;
using System.Web.Mvc;
using Unity;
using Unity.Mvc5;

namespace CadastroLivroMVC
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
            var container = new UnityContainer();

            container.RegisterType<IProdutosRepository, ProdutoRepositoryEf>();
            container.RegisterType<ITipoDeProdutoRepository, TipoDeProdutoRepositoryEF>();
            container.RegisterType<IUsuarioRepository, UsuarioRepository>();



            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}