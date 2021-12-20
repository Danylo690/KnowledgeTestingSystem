using BLL.Interfaces;
using DAL.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class QuestionsService : IQuestionsService
    {
        private readonly IQuestionsService _questionsService;

        public QuestionsService(IQuestionsService questionsService)
        {
            _questionsService = questionsService;
        }

        public async Task<Question> CreateAsync(Question question)
        {
            return await _questionsService.CreateAsync(question);
        }

        public async Task<bool> DeleteAsync(int id)
        {
            return await _questionsService.DeleteAsync(id);
        }

        public async Task<IEnumerable<Question>> GetAllAsync()
        {
            return await _questionsService.GetAllAsync();
        }

        public async Task<Question> GetByIdAsync(int id)
        {
            return await _questionsService.GetByIdAsync(id);
        }

        public async Task<bool> UpdateAsync(Question question)
        {
            return await _questionsService.UpdateAsync(question);
        }
    }
}
