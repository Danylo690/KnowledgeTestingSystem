using DAL.Models;
using System.Data.Entity;

namespace DAL.Contexts
{
    public class KnowledgeTestingContext : DbContext
    {
        public DbSet<Test> Tests { get; set; }

        public DbSet<Question> Questions { get; set; }

        public DbSet<Answer> Answers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

        }
    }
}
