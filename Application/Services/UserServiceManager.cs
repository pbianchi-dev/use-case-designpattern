using Domain.Adapters;
using Domain.Entities;
using Domain.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Services
{
    public class UserServiceManager : IUserService
    {
        private readonly IEmailAdapter _emailAdapter;
        private readonly IUserRepository _userRepository;

        public UserServiceManager(IEmailAdapter emailAdapter, IUserRepository userRepository) =>
            (_emailAdapter, _userRepository) = (emailAdapter, userRepository);

        public async Task<IEnumerable<User>> RecoverAllUsers()
        {
            var users = await _userRepository.GetAll();
            return users;
        }

        public async Task<User> RegisterAUser(User user)
        {
            var ret = await _userRepository.Insert(user);

            //_ = _emailAdapter.SendEmail("", "", "", "");//you can send email alerting the user has been created sucessfully...

            return ret;
        }
    }
}
