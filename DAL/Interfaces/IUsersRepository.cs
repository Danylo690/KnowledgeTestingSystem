using DAL.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IUsersRepository
    {
        Task<User> CreateAsync(User user);

        Task<IEnumerable<User>> GetAllAsync();

        Task<IdentityUser> GetIdentityUserAsync(User user);

        Task<bool> DeleteAsync(int id);

        Task<bool> UpdateAsync(User user);

        void Initialize();
    }
}
