using EzgiBlog.Data.UnitOfWorks;
using EzgiBlog.Entity.Entities;
using EzgiBlog.Service.Services.Abstractions;

namespace EzgiBlog.Service.Services.Concrete
{
    public class ArticleService : IArticleService
    {
        private readonly IUnitOfWork unitOfWork;
        public ArticleService(IUnitOfWork unitOfWork) { }
        public Task<List<Article>> GetAllArticleAsync()
        {
            throw new NotImplementedException();
        }
    }
}
