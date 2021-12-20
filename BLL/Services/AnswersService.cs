using BLL.Interfaces;
using DAL.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class AnswersService : IAnswersService
    {
        private readonly IAnswersService _answersService;

        public AnswersService(IAnswersService answersService)
        {
            _answersService = answersService;
        }

        public async Task<Answer> CreateAsync(Answer answer)
        {
            return await _answersService.CreateAsync(answer);
        }

        public async Task<bool> DeleteAsync(int id)
        {
            return await _answersService.DeleteAsync(id);
        }

        public async Task<IEnumerable<Answer>> GetAllAsync()
        {
            return await _answersService.GetAllAsync();
        }

        public async Task<Answer> GetByIdAsync(int id)
        {
            return await _answersService.GetByIdAsync(id);
        }

        public async Task<bool> UpdateAsync(Answer answer)
        {
            return await _answersService.UpdateAsync(answer);
        }
    }
}
