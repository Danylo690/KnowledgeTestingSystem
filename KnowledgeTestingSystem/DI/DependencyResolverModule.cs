using BLL.Interfaces;
using BLL.Services;
using DAL.Interfaces;
using DAL.Repositories;
using Ninject.Modules;

namespace KnowledgeTestingSystem.DI
{
    public class DependencyResolverModule : NinjectModule
    {
        public override void Load()
        {
            Bind<ITestsService>().To<TestsService>();
            Bind<IAnswersService>().To<AnswersService>();
            Bind<IQuestionsService>().To<QuestionsService>();

            Bind<ITestsRepository>().To<TestsRepository>();
            Bind<IQuestionsRepository>().To<QuestionsRepository>();
            Bind<IAnswersRepository>().To<AnswersRepository>();
        }
    }
}