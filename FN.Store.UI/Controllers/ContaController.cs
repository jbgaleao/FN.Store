using FN.Store.UI.Data;
using FN.Store.UI.Models;
using System.Linq;
using System.Web.Mvc;

namespace FN.Store.UI.Controllers
{
    public class ContaController : Controller
    {
        private readonly FNStoreDataContext _ctx = new FNStoreDataContext();

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginVM model)
        {
            Usuario usuario = _ctx.Usuarios
                .FirstOrDefault(u => u.Email.ToLower() == model.Email.ToLower());

            if (usuario == null)
            {
                ModelState.AddModelError("Email", "E-mail não lcalizado");
            }
            else
            {
                if (usuario.Senha != model.Senha)
                {
                    ModelState.AddModelError("Senha", "Senha Inválida");
                }
            }


            if (ModelState.IsValid)
            {
                return RedirectToAction("Sobre", "Home");
            }

            return View(model);
        }

        protected override void Dispose(bool disposing)
        {
            _ctx.Dispose();
        }

    }
}
