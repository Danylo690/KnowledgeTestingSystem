using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Interfaces;
using DAL.Models;

namespace DAL.Repositories
{
    public class AnswersRepository : IAnswersRepository
    {
        public Task<Answer> CreateAsync(Answer answer)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Answer>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Answer> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAsync(Answer answer)
        {
            throw new NotImplementedException();
        }
    }
}
