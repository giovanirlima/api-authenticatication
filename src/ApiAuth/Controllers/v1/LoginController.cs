using ApiAuth.Interfaces.v1;
using ApiAuth.Models.v1;
using Microsoft.AspNetCore.Mvc;

namespace ApiAuth.Controllers.v1
{
    [Route("api/authentications")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly IUserRepository _userRepository;
        private readonly ITokenService _tokenService;

        public LoginController(IUserRepository userRepository, ITokenService tokenService)
        {
            _userRepository = userRepository;
            _tokenService = tokenService;
        }

        [HttpPost]
        public async Task<ActionResult<dynamic>> AuthenticateAsync(User request)
        {
            var user = _userRepository.GetRoles(request.Username, request.Password);

            if (user == null)
                return NotFound(new { Notification = "Usuário ou senha inválidos. " });

            var token = _tokenService.GenerateToken(user);

            return new
            {
                User = user.Username,
                Token = token
            };
        }
    }
}