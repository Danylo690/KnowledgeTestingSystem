using BLL.Interfaces;
using DAL.Interfaces;
using DAL.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class QuestionsService : IQuestionsService
    {
        private readonly IQuestionsRepository _questionsRepository;

        public QuestionsService(IQuestionsRepository questionsRepository)
        {
            _questionsRepository = questionsRepository;
        }

        public async Task<Question> CreateAsync(Question question)
        {
            return await _questionsRepository.CreateAsync(question);
        }

        public async Task<bool> DeleteAsync(int id)
        {
            return await _questionsRepository.DeleteAsync(id);
        }

        public async Task<IEnumerable<Question>> GetAllAsync()
        {
            return await _questionsRepository.GetAllAsync();
        }

        public async Task<Question> GetByIdAsync(int id)
        {
            return await _questionsRepository.GetByIdAsync(id);
        }

        public async Task<bool> UpdateAsync(Question question)
        {
            return await _questionsRepository.UpdateAsync(question);
        }
    }
}
