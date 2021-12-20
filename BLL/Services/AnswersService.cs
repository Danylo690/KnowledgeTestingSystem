using BLL.Interfaces;
using DAL.Interfaces;
using DAL.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class AnswersService : IAnswersService
    {
        private readonly IAnswersRepository _answersRepository;

        public AnswersService(IAnswersRepository answersRepository)
        {
            _answersRepository = answersRepository;
        }

        public async Task<Answer> CreateAsync(Answer answer)
        {
            return await _answersRepository.CreateAsync(answer);
        }

        public async Task<bool> DeleteAsync(int id)
        {
            return await _answersRepository.DeleteAsync(id);
        }

        public async Task<IEnumerable<Answer>> GetAllAsync()
        {
            return await _answersRepository.GetAllAsync();
        }

        public async Task<Answer> GetByIdAsync(int id)
        {
            return await _answersRepository.GetByIdAsync(id);
        }

        public async Task<bool> UpdateAsync(Answer answer)
        {
            return await _answersRepository.UpdateAsync(answer);
        }
    }
}
