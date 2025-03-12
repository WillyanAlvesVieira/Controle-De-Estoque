using System.ComponentModel.DataAnnotations;

namespace ControleDeEstoque.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "O campo Usuário é obrigatório.")]
        public string Usuario { get; set; }

        [Required(ErrorMessage = "O campo Senha é obrigatório.")]
        [DataType(DataType.Password)]
        public required string Senha { get; set; }

        public bool LembrarMe { get; set; }
    }
}
