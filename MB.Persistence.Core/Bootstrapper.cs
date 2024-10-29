using System.ComponentModel.Design;
using Framework_01.Infrastructure;
using MB.Application;
using MB.Application.Abstractions.Article;
using MB.Application.Abstractions.ArticleCategory;
using MB.Application.Abstractions.Comment;
using MB.Domain.ArticleAgg;
using MB.Domain.ArticleCategoryAgg;
using MB.Domain.CommentAgg;
using MB.Persistence.EFCore.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Persistance;

namespace MB.Persistence
{
    public class Bootstrapper
    {
        public static void Config(IServiceCollection Services, string connectionString)
        {
            Services.AddDbContext<AppDbContext>(x => x.UseSqlServer(connectionString));
            Services.AddTransient<IUnitOfWork, UnitOfWork>();
            Services.AddTransient<IArticleRepository, ArticleRepository>();
            Services.AddTransient<IArticleCategoryRepository, ArticleCategoryRepository>();
            Services.AddTransient<ICommentRepository, CommentRepository>();
            Services.AddTransient<IArticleApplication, ArticleApplication>();
            Services.AddTransient<IArticleCategoryApplication, ArticleCategoryApplication>();
            Services.AddTransient<ICommentApplication, CommentApplication>();
        }
    }
}
