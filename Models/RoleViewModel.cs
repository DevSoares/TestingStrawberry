using System.ComponentModel.DataAnnotations;

namespace Teste02.Models
{
    public class RoleViewModel
    {
        [Required]
        public string Nome { get; set; }
    }
}
