using System.Collections.Generic;
using System.Threading.Tasks;
using Data.Models;

namespace Data.Repository
{
    public interface IUsersRepository
    {
         Task<IEnumerable<User>> GetUsers();
    }
}