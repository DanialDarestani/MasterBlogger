using MB.Application.Abstractions.ArticleCategory;
using MB.Contracts.ArticleCategory;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MB.API.Areas.Administrator.Pages.ArticleCategoryManagement
{
    public class CreateModel : PageModel
    {
        protected readonly IArticleCategoryApplication _articleCategoryApplication;

        public CreateModel(IArticleCategoryApplication articleCategoryApplication)
        {
            _articleCategoryApplication = articleCategoryApplication;
        }
        public void OnGet()
        {
        }
        public RedirectToPageResult OnPost(EditArticleCategory Article)
        {
            _articleCategoryApplication.Create(Article);
            return RedirectToPage("./List");
        }
    }
}
