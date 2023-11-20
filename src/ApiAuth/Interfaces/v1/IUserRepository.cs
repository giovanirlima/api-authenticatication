using ApiAuth.Models.v1;

namespace ApiAuth.Interfaces.v1
{
    public interface IUserRepository
    {
        User GetRoles(string username, string password);
    }
}