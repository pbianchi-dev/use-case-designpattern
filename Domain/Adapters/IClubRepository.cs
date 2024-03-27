using Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain.Adapters
{
    public interface IClubRepository
    {
        Task<IEnumerable<Club>> GetAll();

        Task<int> Insert(Club club);
    }
}
