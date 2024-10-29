using Framework_01.Infrastructure;
using MB.Application.Abstractions.Article;
using MB.Application.Abstractions.ArticleCategory;
using MB.Contracts.Article;
using MB.Contracts.ArticleCategory;
using MB.Domain.ArticleAgg;
using MB.Domain.ArticleCategoryAgg;
using MB.Domain.ArticleCategoryAgg.Services;

namespace MB.Application
{
    public class ArticleCategoryApplication : IArticleCategoryApplication
    {
        protected readonly IArticleCategoryRepository _articleCategoryRepository;
        protected readonly IArticleCategoryValidationService _articleCategoryValidationService;
        protected readonly IUnitOfWork _unitOfWork;

        public ArticleCategoryApplication(IArticleCategoryRepository articleCategoryRepository, IUnitOfWork unitOfWork, IArticleCategoryValidationService articleCategoryValidationService)
        {
            _articleCategoryRepository = articleCategoryRepository;
            _articleCategoryValidationService = articleCategoryValidationService;
            _unitOfWork = unitOfWork;
        }

        public void Create(EditArticleCategory entity)
        {
            _unitOfWork.BeginTran();
            var articleCategory = new ArticleCategory(entity.Title, _articleCategoryValidationService);
            _articleCategoryRepository.Create(articleCategory);
            _unitOfWork.CommitTran();
        }

        public void Edit(EditArticleCategory entity)
        {
            _unitOfWork.BeginTran();
            var articleCategory = _articleCategoryRepository.Get(entity.Id);
            articleCategory.Edit(entity.Title);
            _unitOfWork.CommitTran();
        }

        public void Delete(int id)
        {
            _unitOfWork.BeginTran();
            var articleCategory = _articleCategoryRepository.Get(id);
            articleCategory.Delete();
            _unitOfWork.CommitTran();
        }

        public void Restore(int id)
        {
            _unitOfWork.BeginTran();
            var articleCategory = _articleCategoryRepository.Get(id);
            articleCategory.Restore();
            _unitOfWork.CommitTran();
        }

        public List<ArticleCategoryViewModel> GetAll()
        {
            List<ArticleCategory> acl = _articleCategoryRepository.GetAll();
            List<ArticleCategoryViewModel> acvml = new List<ArticleCategoryViewModel>();
            foreach (var ac in acl)
            {
                acvml.Add(new ArticleCategoryViewModel()
                {
                    Id = ac.Id,
                    Title = ac.Title,
                    IsDeleted = ac.IsDeleted,
                    CreationDate = ac.CreationTime.ToString()
                });
            }
            return acvml;
        }

        public EditArticleCategory Get(int articleId)
        {
            var article = _articleCategoryRepository.Get(articleId);
            return new EditArticleCategory()
            {
                Id = article.Id,
                Title = article.Title
            };
        }
    }
}