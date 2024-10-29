using Framework_01.Infrastructure;
using MB.Domain.ArticleAgg;
using MB.Domain.CommentAgg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MB.Domain.ArticleCategoryAgg
{
    public interface IArticleCategoryRepository : IBaseRepository<int, ArticleCategory>
    {
    }
}
