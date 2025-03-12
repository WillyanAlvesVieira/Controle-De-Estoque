using ControleDeEstoque.Data.Context;
using ControleDeEstoque.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace ControleDeEstoque.Controllers
{
    public class ContaController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ContaController(ApplicationDbContext context)
        {
            _context = context;
        }

        [AllowAnonymous]
        public ActionResult Login(string returnUrl)
        {
            ViewBag.ReturnUrl = returnUrl;
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Login(LoginViewModel login, string returnUrl)
        {
            if (string.IsNullOrEmpty(login.Usuario) || string.IsNullOrEmpty(login.Senha))
            {
                ModelState.AddModelError("", "Usuário e senha são obrigatórios.");
                return View(login);
            }

            var usuarioViewModel = new UsuarioViewModel(_context);
            bool usuarioValido = await usuarioViewModel.ValidarUsuarioAsync(login.Usuario, login.Senha);

            if (usuarioValido)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, login.Usuario),
                };

                var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                var claimsPrincipal = new ClaimsPrincipal(claimsIdentity);

                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, claimsPrincipal);

                if (!string.IsNullOrEmpty(returnUrl) && Url.IsLocalUrl(returnUrl))
                {
                    return Redirect(returnUrl);
                }

                return RedirectToAction("Index", "Home");
            }

            ModelState.AddModelError("", "Usuário ou senha inválidos.");
            return View(login);
        }


        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);

            HttpContext.User = null;

            return RedirectToAction("Login", "Conta");
        }

    }
}
