using Microsoft.AspNetCore.Mvc;

namespace ControleDeEstoque.Controllers
{
    public class RelatoriosController : Controller
    {
        public IActionResult PosicaoEstoque() { return View(); }

        public IActionResult Ressuprimento() { return View(); }
    }
}
