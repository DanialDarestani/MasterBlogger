using MB.Domain.ArticleAgg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MB.Domain.ArticleCategoryAgg;
using Persistance;
using Framework_01.Infrastructure;
using MB.Domain.CommentAgg;
using Microsoft.EntityFrameworkCore;

namespace MB.Persistence.EFCore.Repositories
{
    public class ArticleCategoryRepository : BaseRepository<int, ArticleCategory>, IArticleCategoryRepository
    {
        protected readonly AppDbContext _context;

        public ArticleCategoryRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
