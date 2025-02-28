using Microsoft.AspNetCore.Mvc;

namespace ControleDeEstoque.Controllers
{
    public class GraficoController : Controller
    {
        public IActionResult PerdasMes() {  return View(); }
        public IActionResult EntradaSaidaMes() {  return View(); }
    }
}
