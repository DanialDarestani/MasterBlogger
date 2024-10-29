using MB.Contracts.Article;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MB.Contracts.Comment;

namespace MB.Application.Abstractions.Comment
{
    public interface ICommentApplication
    {
        void Create(AddComment entity);
        List<CommentViewModel> GetAll();
        void Confirm(int id);
        void Cancel(int id);
    }
}
