using System.ComponentModel.DataAnnotations;

namespace Teste02.Models
{
    public class UserRegisterViewModel
    {
        [Required(ErrorMessage = "O campo {0} é Obrigatório!")]
        [EmailAddress(ErrorMessage = "O campo {0} está em formato inválido")]
        public string Email { get; set; }

        [Required(ErrorMessage = "O campo {0} é Obrigatório!")]
        [StringLength(100, ErrorMessage = "O campo deve conter entre {2} e {1} caracteres", MinimumLength = 10)]
        public string Senha { get; set; }

        [Compare("Senha", ErrorMessage = "As senhas não conferem.")]
        public string ConfirmaSenha { get; set; }
    }
}
