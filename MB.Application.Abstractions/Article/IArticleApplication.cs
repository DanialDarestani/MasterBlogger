using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MB.Contracts.Article;

namespace MB.Application.Abstractions.Article
{
    public interface IArticleApplication
    {
        public void Create(EditArticle entity);
        public void Edit(EditArticle entity);
        public void Delete(int articleId);
        public void Restore(int articleId);
        public List<ArticleViewModel> GetAll();
        public EditArticle Get(int articleId);
    }
}
