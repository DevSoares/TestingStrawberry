using System.ComponentModel.DataAnnotations;

namespace Teste02.Models
{
    public class UserLoginViewModel
    {
        [Required(ErrorMessage = "O campo {0} é Obrigatório!")]
        [EmailAddress(ErrorMessage = "O campo {0} está em formato inválido")]
        public string Email { get; set; }

        [Required(ErrorMessage = "O campo {0} é Obrigatório!")]
        [StringLength(100, ErrorMessage = "O campo deve conter entre {2} e {1} caracteres", MinimumLength = 10)]
        public string Senha { get; set; }
    }
}
