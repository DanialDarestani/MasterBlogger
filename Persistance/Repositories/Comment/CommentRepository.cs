using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework_01.Infrastructure;
using MB.Domain.ArticleAgg;
using MB.Domain.CommentAgg;
using Microsoft.EntityFrameworkCore;
using Persistance;

namespace MB.Persistence.EFCore.Repositories
{
    public class CommentRepository : BaseRepository<int,Comment> , ICommentRepository
        {
        protected readonly AppDbContext _context;

        public CommentRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }
        public List<Comment> GetAllViewModel()
        {
            var comments = _context.Comments.Include(x => x.Article).Select(x => x).ToList();
            return comments;
        }
    }
}
