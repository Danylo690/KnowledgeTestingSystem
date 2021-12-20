using BLL.Interfaces;
using DAL.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class TestsService : ITestsService
    {
        private readonly ITestsService _testService;

        public TestsService(ITestsService testsService)
        {
            _testService = testsService;
        }

        public async Task<Test> CreateAsync(Test test)
        {
            return await _testService.CreateAsync(test);
        }

        public async Task<bool> DeleteAsync(int id)
        {
            return await _testService.DeleteAsync(id);
        }

        public async Task<IEnumerable<Test>> GetAllAsync()
        {
            return await _testService.GetAllAsync();
        }

        public async Task<Test> GetByIdAsync(int id)
        {
            return await _testService.GetByIdAsync(id);
        }

        public async Task<bool> UpdateAsync(Test test)
        {
            return await _testService.UpdateAsync(test);
        }
    }
}
