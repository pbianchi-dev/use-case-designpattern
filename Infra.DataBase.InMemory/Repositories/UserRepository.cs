using Domain.Adapters;
using Domain.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Infra.DataBase.InMemory.Repositories
{
    public class UserRepository : IUserRepository
    {
        private static List<User> _users = new List<User>(10);

        public Task<List<User>> GetAll()
        {
            return Task.FromResult(_users);
        }

        public Task<User> Insert(User user)
        {
            int id = 0;

            if (_users.Count ==  0)
            {
                id = 1;
            }
            else
            {
                id = _users.Max(x => x.Id);
                id++;
            }   
            
            user.Id = id;

            _users.Add(user);

            return Task.FromResult(user);
        }
    }
}
