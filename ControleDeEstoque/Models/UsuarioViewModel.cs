using ControleDeEstoque.Data.Context;
using Microsoft.EntityFrameworkCore;
using System.Data.SqlClient;


namespace ControleDeEstoque.Models
{
    public class UsuarioViewModel
    {
        private readonly ApplicationDbContext _context;

        public UsuarioViewModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<bool> ValidarUsuarioAsync(string login, string senha)
        {
            var usuario = await _context.Usuarios
                .FirstOrDefaultAsync(u => u.Login == login && u.Senha == senha);

            return usuario != null;
        }

    }
}
