using DAL.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface ITestsRepository
    {
        Task<Test> CreateAsync(Test test);

        Task<IEnumerable<Test>> GetAllAsync();

        Task<Test> GetByIdAsync(int id);

        Task<bool> UpdateAsync(Test test);

        Task<bool> DeleteAsync(int id);
    }
}
