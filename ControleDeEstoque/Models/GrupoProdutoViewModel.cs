using ControleDeEstoque.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace ControleDeEstoque.Models
{
    public class GrupoProdutoViewModel
    {
        private readonly ApplicationDbContext _context;

        public GrupoProdutoViewModel(ApplicationDbContext context)
        {
            _context = context;
        }


        public async Task<bool> Incluir(string login, string senha)
        {
            var usuario = await _context.Usuarios
                .FirstOrDefaultAsync(u => u.Login == login && u.Senha == senha);

            return usuario != null;
        }

        public async Task<bool> Alterar(string login, string senha)
        {
            var usuario = await _context.Usuarios
                .FirstOrDefaultAsync(u => u.Login == login && u.Senha == senha);

            return usuario != null;
        }

        public async Task<bool> Deletar(string login, string senha)
        {
            var usuario = await _context.Usuarios
                .FirstOrDefaultAsync(u => u.Login == login && u.Senha == senha);

            return usuario != null;
        }
    }
}
