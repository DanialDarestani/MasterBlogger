using System.Collections.Generic;
using MB.Application.Abstractions.Article;
using MB.Contracts.Article;
using MB.Domain.ArticleAgg;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MB.Presentation.MVCCore.Pages
{
    public class IndexModel : PageModel
    {
        protected readonly IArticleApplication _articleApplication;
        public List<Article> Articles;
        public IndexModel(IArticleApplication articleApplication)
        {
            _articleApplication = articleApplication;
        }

        public void OnGet()
        {
            /*Articles = _articleApplication.GetAll();*/
        }
    }
}