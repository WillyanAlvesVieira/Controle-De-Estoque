using Microsoft.AspNetCore.Mvc;

namespace ControleDeEstoque.Controllers
{
    public class OperacoesController : Controller
    {
        public IActionResult EntradaEstoque() { return View(); }
        public IActionResult SaidaEstoque() { return View(); }
        public IActionResult LancPerdaProduto() { return View(); }
        public IActionResult Inventario() { return View(); }
    }
}
