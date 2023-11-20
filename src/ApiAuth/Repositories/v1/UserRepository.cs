using ApiAuth.Interfaces.v1;
using ApiAuth.Models.v1;

namespace ApiAuth.Repositories.v1
{
    public class UserRepository : IUserRepository
    {
        public User GetRoles(string username, string password)
        {
            var users = new List<User>
            {
                new User { Id = 1, Username = "Batman", Password = "Batman", Role = "Manager" },
                new User { Id = 2, Username = "Robin", Password = "Robin", Role = "Employee" }
            };

            return users.FirstOrDefault(x => x.Username.Equals(username, StringComparison.OrdinalIgnoreCase) && x.Password == password);
        }
    }
}