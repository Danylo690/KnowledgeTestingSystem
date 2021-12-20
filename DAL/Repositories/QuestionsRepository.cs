using DAL.Contexts;
using DAL.Interfaces;
using DAL.Models;
using System.Collections.Generic;
using System.Data.Entity;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class QuestionsRepository : IQuestionsRepository
    {
        private readonly KnowledgeTestingContext _knowledgeTestingContext;

        public QuestionsRepository(KnowledgeTestingContext knowledgeTestingContext)
        {
            _knowledgeTestingContext = knowledgeTestingContext;
        }

        public async Task<Question> CreateAsync(Question question)
        {
            _knowledgeTestingContext.Questions.Add(question);

            await _knowledgeTestingContext.SaveChangesAsync();

            return question;

        }

        public async Task<bool> DeleteAsync(int id)
        {
            var item = _knowledgeTestingContext.Questions.Attach(new Question { Id = id });
            var result = item != null;

            if (result)
            {
                _knowledgeTestingContext.Entry(item).State = EntityState.Deleted;
                await _knowledgeTestingContext.SaveChangesAsync();
            }

            return result;
        }

        public async Task<IEnumerable<Question>> GetAllAsync()
        {
            return await _knowledgeTestingContext.Questions.ToListAsync();
        }

        public async Task<Question> GetByIdAsync(int id)
        {
            return await _knowledgeTestingContext.Questions.FindAsync(id);
        }

        public async Task<bool> UpdateAsync(Question question)
        {
            var item = _knowledgeTestingContext.Questions.Attach(question);
            _knowledgeTestingContext.Entry(question).State = EntityState.Modified;
            await _knowledgeTestingContext.SaveChangesAsync();

            return item != null;
        }
    }
}
