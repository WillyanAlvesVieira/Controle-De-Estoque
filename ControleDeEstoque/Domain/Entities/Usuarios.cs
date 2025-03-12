using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace ControleDeEstoque.Domain.Entities
{
    public class Usuarios
    {
        public int Id { get; set; }
        public string Senha { get; set; }
        public string Login { get; set; }
    }
}
