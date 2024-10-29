using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Framework_01.Infrastructure;
using MB.Domain.ArticleAgg;
using Microsoft.EntityFrameworkCore;
using Persistance;

namespace MB.Persistence.EFCore.Repositories
{
    public class ArticleRepository : BaseRepository<int,Article>, IArticleRepository
    {
        protected readonly AppDbContext _context;

        public ArticleRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }

        public List<Article> GetAllViewModel()
        {
            var articles = _context.Articles.Include(x => x.ArticleCategory).Select(x => x).ToList();
            return articles;
        }
    }
}
