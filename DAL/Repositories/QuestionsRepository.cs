using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class QuestionsRepository : IQuestionsRepository
    {
        public Task<Question> CreateAsync(Question question)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Question>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Question> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAsync(Question question)
        {
            throw new NotImplementedException();
        }
    }
}
