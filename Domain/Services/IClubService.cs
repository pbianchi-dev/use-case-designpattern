using Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain.Services
{
    public interface IClubService
    {
        Task<IEnumerable<Club>> RecoverAllClubs();

        Task<int> RegisterAClub(Club club);
    }
}
