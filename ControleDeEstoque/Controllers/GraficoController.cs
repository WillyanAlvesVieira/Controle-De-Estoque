using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ControleDeEstoque.Controllers
{
    public class GraficoController : Controller
    {
        [Authorize]
        public IActionResult PerdasMes() {  return View(); }

        [Authorize]
        public IActionResult EntradaSaidaMes() {  return View(); }
    }
}
