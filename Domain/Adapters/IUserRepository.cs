using Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain.Adapters
{
    public interface IUserRepository
    {
        Task<List<User>> GetAll();

        Task<User> Insert(User user);
    }
}
