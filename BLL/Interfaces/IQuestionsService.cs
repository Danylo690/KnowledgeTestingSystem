using DAL.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IQuestionsService
    {
        Task<Question> CreateAsync(Question question);

        Task<IEnumerable<Question>> GetAllAsync();

        Task<Question> GetByIdAsync(int id);

        Task<bool> UpdateAsync(Question question);

        Task<bool> DeleteAsync(int id);
    }
}
