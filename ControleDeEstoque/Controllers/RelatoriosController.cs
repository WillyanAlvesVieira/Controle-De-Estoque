using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ControleDeEstoque.Controllers
{
    public class RelatoriosController : Controller
    {
        [Authorize]
        public IActionResult PosicaoEstoque() { return View(); }

        [Authorize]
        public IActionResult Ressuprimento() { return View(); }
    }
}
