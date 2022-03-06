using CadastroLivroMVC.Models;
using CadastroMVC.Data.EF.Repositories;
using CadastroMVC.Domain.Contratos.REpositorios;
using CadastroMVC.Domain.Helpers;
using System.Web.Mvc;
using System.Web.Security;

namespace CadastroLivroMVC.Controllers
{
    public class ContaController : Controller
    {
        private readonly IUsuarioRepository _usuarioRepository;
        public ContaController(IUsuarioRepository usuariodependencia)
        {
            _usuarioRepository = usuariodependencia;
        }
        // GET: Conta
        [HttpGet]
        public ActionResult Login(string returnURL)
        {
            var model = new LoginVm() { ReturnURL = returnURL };
            return View(model);
        }
        [HttpPost]

        public ActionResult Login(LoginVm model) {

            var usuario = _usuarioRepository.Get(model.Email);
            if (usuario == null)
            {
                ModelState.AddModelError("Email", "O email não foi localizado");
            }
            else {
                if (usuario.Senha != model.Senha.Encrypt())
                    ModelState.AddModelError("SEnha", "senha é invalida");

            }

            if (ModelState.IsValid) {

                FormsAuthentication.SetAuthCookie(model.Email, model.PermanecerLogado);
                if (!string.IsNullOrEmpty(model.ReturnURL)&& Url.IsLocalUrl(model.ReturnURL)) {
                    return Redirect(model.ReturnURL);
                }
                return RedirectToAction("Index", "Produtos");

            }
            return View(model);
        }
        [HttpGet]

        public ActionResult LogOut()
        {

            FormsAuthentication.SignOut();

            return RedirectToAction("Login");
        }


        protected override void Dispose(bool disposing)
        {
            _usuarioRepository.Dispose();
        }
    }
}