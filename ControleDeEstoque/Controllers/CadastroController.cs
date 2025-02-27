using Microsoft.AspNetCore.Mvc;

namespace ControleDeEstoque.Controllers
{
    public class CadastroController : Controller
    {
        public IActionResult GrupoProduto() {  return View(); }
        public IActionResult MarcaProdutos() { return View(); }
        public IActionResult LocaisArmazenamento() { return View(); }
        public IActionResult UnidadesMedida() { return View(); }
        public IActionResult Produto() { return View(); }
        public IActionResult Pais() { return View(); }
        public IActionResult Estado() { return View(); }
        public IActionResult Cidade() { return View(); }
        public IActionResult Fornecedores() { return View(); }
        public IActionResult PerfilUsuarios() { return View(); }
        public IActionResult Usuario() { return View(); }
    }
}
