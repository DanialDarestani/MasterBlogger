using MB.Contracts.Article;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MB.Contracts.ArticleCategory;

namespace MB.Application.Abstractions.ArticleCategory
{
    public interface IArticleCategoryApplication
    {
        public void Create(EditArticleCategory entity);
        public void Edit(EditArticleCategory entity);
        public void Delete(int articleId);
        public void Restore(int articleId);
        public List<ArticleCategoryViewModel> GetAll();
        public EditArticleCategory Get(int articleId);
    }
}
