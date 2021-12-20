using BLL.Interfaces;
using DAL.Interfaces;
using DAL.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class TestsService : ITestsService
    {
        private readonly ITestsRepository _testsRepository;

        public TestsService(ITestsRepository testsRepository)
        {
            _testsRepository = testsRepository;
        }

        public async Task<Test> CreateAsync(Test test)
        {
            return await _testsRepository.CreateAsync(test);
        }

        public async Task<bool> DeleteAsync(int id)
        {
            return await _testsRepository.DeleteAsync(id);
        }

        public async Task<IEnumerable<Test>> GetAllAsync()
        {
            return await _testsRepository.GetAllAsync();
        }

        public async Task<Test> GetByIdAsync(int id)
        {
            return await _testsRepository.GetByIdAsync(id);
        }

        public async Task<bool> UpdateAsync(Test test)
        {
            return await _testsRepository.UpdateAsync(test);
        }
    }
}
