using ControleDeEstoque.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ControleDeEstoque.Controllers
{
    public class CadastroController : Controller
    {
        private static List<GrupoProdutoViewModel> _produtos = new List<GrupoProdutoViewModel>()
        {
            new GrupoProdutoViewModel() {Id = 1, Nome = "Livros", Ativo = true},
            new GrupoProdutoViewModel() {Id = 2, Nome = "Mesas", Ativo = true},
            new GrupoProdutoViewModel() {Id = 3, Nome = "Parafusos", Ativo = false}
        };   

        [Authorize]
        public IActionResult GrupoProdutos() {  return View(_produtos); }
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
