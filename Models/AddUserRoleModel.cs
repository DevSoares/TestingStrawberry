using System.ComponentModel.DataAnnotations;

namespace Teste02.Models
{
    public class AddUserRoleModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Role { get; set; }
    }
}
