using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ControleDeEstoque.Controllers
{
    public class CadastroController : Controller
    {
        [Authorize]
        public IActionResult GrupoProdutos() {  return View(); }
        [Authorize]
        public IActionResult MarcaProdutos() { return View(); }
        [Authorize]
        public IActionResult LocaisArmazenamento() { return View(); }
        [Authorize]
        public IActionResult UnidadesMedida() { return View(); }
        [Authorize]
        public IActionResult Produto() { return View(); }
        [Authorize]
        public IActionResult Pais() { return View(); }
        [Authorize]
        public IActionResult Estado() { return View(); }
        [Authorize]
        public IActionResult Cidade() { return View(); }
        [Authorize]
        public IActionResult Fornecedores() { return View(); }
        [Authorize]
        public IActionResult PerfilUsuarios() { return View(); }
        [Authorize]
        public IActionResult Usuario() { return View(); }
    }
}
