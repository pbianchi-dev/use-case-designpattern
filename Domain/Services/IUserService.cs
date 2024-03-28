using Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain.Services
{
    public interface IUserService
    {
        Task<IEnumerable<User>> RecoverAllUsers();

        Task<User> RegisterAUser(User user);
    }
}
