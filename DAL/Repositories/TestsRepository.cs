using DAL.Contexts;
using DAL.Interfaces;
using DAL.Models;
using System.Collections.Generic;
using System.Data.Entity;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class TestsRepository : ITestsRepository
    {
        private readonly KnowledgeTestingContext _knowledgeTestingContext;

        public TestsRepository(KnowledgeTestingContext knowledgeTestingContext)
        {
            _knowledgeTestingContext = knowledgeTestingContext;
        }

        public async Task<Test> CreateAsync(Test test)
        {
            _knowledgeTestingContext.Tests.Add(test);

            await _knowledgeTestingContext.SaveChangesAsync();

            return test;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var item = _knowledgeTestingContext.Tests.Attach(new Test { Id = id });
            var result = item != null;

            if (result)
            {
                _knowledgeTestingContext.Entry(item).State = EntityState.Deleted;
                await _knowledgeTestingContext.SaveChangesAsync();
            }

            return result;
        }

        public async Task<IEnumerable<Test>> GetAllAsync()
        {
            return await _knowledgeTestingContext.Tests.Include(x => x.Questions).ToListAsync();
        }

        public async Task<Test> GetByIdAsync(int id)
        {
            return await _knowledgeTestingContext.Tests.Include(x => x.Questions).FirstAsync(x => x.Id == id);
        }

        public async Task<bool> UpdateAsync(Test test)
        {
            var item = _knowledgeTestingContext.Tests.Attach(test);
            _knowledgeTestingContext.Entry(test).State = EntityState.Modified;
            await _knowledgeTestingContext.SaveChangesAsync();

            return item != null;
        }
    }
}
