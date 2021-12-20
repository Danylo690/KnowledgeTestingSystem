using DAL.Contexts;
using DAL.Interfaces;
using DAL.Models;
using System.Collections.Generic;
using System.Data.Entity;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class AnswersRepository : IAnswersRepository
    {
        private readonly KnowledgeTestingContext _knowledgeTestingContext;

        public AnswersRepository(KnowledgeTestingContext knowledgeTestingContext)
        {
            _knowledgeTestingContext = knowledgeTestingContext;
        }

        public async Task<Answer> CreateAsync(Answer answer)
        {
            _knowledgeTestingContext.Answers.Add(answer);

            await _knowledgeTestingContext.SaveChangesAsync();

            return answer;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var item = _knowledgeTestingContext.Answers.Attach(new Answer { Id = id });
            var result = item != null;

            if (result)
            {
                _knowledgeTestingContext.Entry(item).State = EntityState.Deleted;
                await _knowledgeTestingContext.SaveChangesAsync();
            }

            return result;
        }

        public async Task<IEnumerable<Answer>> GetAllAsync()
        {
            return await _knowledgeTestingContext.Answers.ToListAsync();
        }

        public async Task<Answer> GetByIdAsync(int id)
        {
            return await _knowledgeTestingContext.Answers.FindAsync(id);
        }

        public async Task<bool> UpdateAsync(Answer answer)
        {
            var item = _knowledgeTestingContext.Answers.Attach(answer);
            _knowledgeTestingContext.Entry(answer).State = EntityState.Modified;
            await _knowledgeTestingContext.SaveChangesAsync();

            return item != null;
        }
    }
}
