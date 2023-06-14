using FN.Store.UI.Data;
using FN.Store.UI.Models;
using System.Linq;
using System.Web.Mvc;
using System.Web.Security;

namespace FN.Store.UI.Controllers
{
    public class ContaController : Controller
    {
        private readonly FNStoreDataContext _ctx = new FNStoreDataContext();

        [HttpGet]
        public ActionResult Login(string returnURL)
        {
            LoginVM model = new LoginVM() { ReturnURL = returnURL };
            return View(model);
        }


        [HttpPost]
        public ActionResult Login(LoginVM model)
        {
            Usuario usuario = _ctx.Usuarios
                .FirstOrDefault(u => u.Email.ToLower() == model.Email.ToLower());

            if (usuario == null)
            {
                ModelState.AddModelError("Email", "E-mail não Localizado");
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
                FormsAuthentication.SetAuthCookie(model.Email, model.PermanecerLogado);

                if (!string.IsNullOrEmpty(model.ReturnURL) && Url.IsLocalUrl(model.ReturnURL))
                {
                    return Redirect(model.ReturnURL);
                }
                return RedirectToAction("Index", "Home");
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
            _ctx.Dispose();
        }

    }
}
