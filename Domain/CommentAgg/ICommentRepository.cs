using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework_01.Infrastructure;
using MB.Domain.ArticleAgg;

namespace MB.Domain.CommentAgg
{
    public interface ICommentRepository : IBaseRepository<int, Comment>
    {
        List<Comment> GetAllViewModel();
    }
}
