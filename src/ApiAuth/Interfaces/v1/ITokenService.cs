using ApiAuth.Models.v1;

namespace ApiAuth.Interfaces.v1
{
    public interface ITokenService
    {
        string GenerateToken(User user);
    }
}