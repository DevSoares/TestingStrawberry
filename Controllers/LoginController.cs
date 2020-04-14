using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Teste02.Models;
using Teste02.Services;

namespace Teste02.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly UserManagementService _userManagementService;
        private readonly SignInManager<IdentityUser> _signInManager;

        public LoginController(UserManagementService userManagementService,
                                SignInManager<IdentityUser> signInManager)
        {
            _signInManager = signInManager;
            _userManagementService = userManagementService;
        }

        [HttpPost("Registrar")]
        public async Task<ActionResult> Registrar(UserRegisterViewModel viewModel)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState.Values.SelectMany(e => e.Errors));

            var result = await _userManagementService.Create(viewModel);

            if (!result.Succeeded) return BadRequest(result.Errors);

            viewModel.Senha = string.Empty;
            viewModel.ConfirmaSenha = string.Empty;

            return Ok(viewModel);
        }

        [HttpPost("Entrar")]
        public async Task<ActionResult> Login(UserLoginViewModel viewModel)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState.Values.SelectMany(e => e.Errors));

            var result = await _signInManager.PasswordSignInAsync(viewModel.Email, viewModel.Senha, false, true);

            if (!result.Succeeded)
            {
                return BadRequest("Usuário ou senha inválido.");
            }

            return Ok(await _userManagementService.GerarJWT(viewModel.Email));
        }
    }
}