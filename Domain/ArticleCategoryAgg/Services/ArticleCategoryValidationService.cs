using System.Data;
using MB.Domain.ArticleCategoryAgg.Exceptions;

namespace MB.Domain.ArticleCategoryAgg.Services
{
    public class ArticleCategoryValidationService : IArticleCategoryValidationService
    {
        protected readonly IArticleCategoryRepository _articleCategoryRepository;

        public ArticleCategoryValidationService(IArticleCategoryRepository articleCategoryRepository)
        {
            _articleCategoryRepository = articleCategoryRepository;
        }
        public void CheckExistence(string title)
        {
            if(_articleCategoryRepository.Exists(x => x.Title == title))
            {
                throw new DuplicatedRecordException("Article Category already exists!");
            }
        }
    }
}
