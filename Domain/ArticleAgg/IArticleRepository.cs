using Framework_01.Infrastructure;
using MB.Domain.CommentAgg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MB.Domain.ArticleAgg
{
    public interface IArticleRepository : IBaseRepository<int, Article>
    {
        List<Article> GetAllViewModel();
    }
}
