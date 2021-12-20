using DAL.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IQuestionsRepository
    {
        Task<Question> CreateAsync(Question question);

        Task<IEnumerable<Question>> GetAllAsync();

        Task<Question> GetByIdAsync(int id);

        Task<bool> UpdateAsync(Question question);

        Task<bool> DeleteAsync(int id);
    }
}
