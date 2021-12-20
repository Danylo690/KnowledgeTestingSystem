using DAL.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IAnswersRepository
    {
        Task<Answer> CreateAsync(Answer answer);

        Task<IEnumerable<Answer>> GetAllAsync();

        Task<Answer> GetByIdAsync(int id);

        Task<bool> UpdateAsync(Answer answer);

        Task<bool> DeleteAsync(int id);
    }
}
