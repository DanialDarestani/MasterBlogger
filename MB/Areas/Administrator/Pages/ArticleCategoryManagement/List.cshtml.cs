using MB.Application.Abstractions.ArticleCategory;
using MB.Contracts.Article;
using MB.Contracts.ArticleCategory;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MB.API.Areas.Administrator.Pages.ArticleCategoryManagement
{
    public class ListModel : PageModel
    {
        protected readonly IArticleCategoryApplication _articleCategoryApplication;
        public List<ArticleCategoryViewModel> ArticleCategories { get; set; }

        public ListModel(IArticleCategoryApplication articleCategoryApplication)
        {
            _articleCategoryApplication = articleCategoryApplication;
        }
        public void OnGet()
        {
            ArticleCategories = _articleCategoryApplication.GetAll();
        }

        public RedirectToPageResult OnPostRestore(int id)
        {
            _articleCategoryApplication.Restore(id);
            return RedirectToPage("./List");
        }
        public RedirectToPageResult OnPostDelete(int id)
        {
            _articleCategoryApplication.Delete(id);
            return RedirectToPage("./List");
        }
    }
}
