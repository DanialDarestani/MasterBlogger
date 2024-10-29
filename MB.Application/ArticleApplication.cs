using Framework_01.Infrastructure;
using MB.Application.Abstractions.Article;
using MB.Contracts.Article;
using MB.Domain.ArticleAgg;

namespace MB.Application
{
    public class ArticleApplication : IArticleApplication
    {
        protected readonly IArticleRepository _articleRepository;
        protected readonly IUnitOfWork _unitOfWork;

        public ArticleApplication(IArticleRepository articleRepository, IUnitOfWork unitOfWork)
        {
            _articleRepository = articleRepository;
            _unitOfWork = unitOfWork;
        }

        public void Create(EditArticle entity)
        {
            _unitOfWork.BeginTran();
            var article = new Article(entity.Title,entity.Description,entity.Content,entity.Image,entity.ArticleCategoryId);
            _articleRepository.Create(article);
            _unitOfWork.CommitTran();
        }

        public void Edit(EditArticle entity)
        {
            _unitOfWork.BeginTran();
            var article = _articleRepository.Get(entity.Id);
            article.Edit(entity.Title,entity.Description,entity.Content,entity.Image,entity.ArticleCategoryId);
            _unitOfWork.CommitTran();
        }

        public void Delete(int id)
        {
            _unitOfWork.BeginTran();
            var article = _articleRepository.Get(id);
            article.Delete();
            _unitOfWork.CommitTran();
        }

        public void Restore(int id)
        {
            _unitOfWork.BeginTran();
            var article = _articleRepository.Get(id);
            article.Restore();
            _unitOfWork.CommitTran();
        }

        public List<ArticleViewModel> GetAll()
        {
            List<Article> al = _articleRepository.GetAllViewModel();
            List<ArticleViewModel> avml = new List<ArticleViewModel>();
            foreach (var a in al)
            {
                avml.Add(new ArticleViewModel()
                {
                    Id = a.Id,
                    Title = a.Title,
                    ArticleCategory = a.ArticleCategory.Title,
                    IsDeleted = a.IsDeleted,
                    CreationDate = a.CreationTime.ToString(),
                });
            }
            return avml;
        }

        public EditArticle Get(int articleId)
        {
            var article = _articleRepository.Get(articleId);
            return new EditArticle()
            {
                Id = article.Id,
                Title = article.Title,
                Description = article.Description,
                Content = article.Content,
                Image = article.Image,
                ArticleCategoryId = article.ArticleCategoryId
            };
        }
    }
}
