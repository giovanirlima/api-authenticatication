using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ApiAuth.Controllers.v1
{
    [Route("api/auth")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        [HttpGet]
        [Route("Anonymous")]
        [AllowAnonymous]
        public string Anonymous() =>
            "Anônimo";

        [HttpGet]
        [Authorize]
        [Route("Authenticated")]
        public string Authenticated() =>
            $"Autenticado - {User.Identity.Name}";

        [HttpGet]
        [Route("Employee")]
        [Authorize(Roles = "Employee, Manager")]
        public string Employee() =>
            "Funcionário";

        [HttpGet]
        [Route("Manager")]
        [Authorize(Roles = "Manager")]
        public string Manager() =>
            "Gerente";
    }
}