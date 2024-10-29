using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework_01.Domain;
using MB.Domain.ArticleAgg;
using MB.Domain.ArticleCategoryAgg.Services;

namespace MB.Domain.ArticleCategoryAgg
{
    public class ArticleCategory : DomainBase<int>
    {
        public string Title { get; set; }
        public bool IsDeleted { get; set; }
        public ICollection<Article> Articles { get; set; }
        protected ArticleCategory() { }

        public ArticleCategory(string title, IArticleCategoryValidationService articleCategoryValidationService)
        {
            GuardAgainstEmptyTitle(title);
            articleCategoryValidationService.CheckExistence(title);
            Title = title;
            IsDeleted = false;
            Articles = new List<Article>();
        }
        public void Delete()
        {
            IsDeleted = true;
        }
        public void Restore()
        {
            IsDeleted = false;
        }

        public void Edit(string title)
        {
            GuardAgainstEmptyTitle(title);
            Title = title;
        }

        public void GuardAgainstEmptyTitle(string title)
        {
            if (string.IsNullOrWhiteSpace(title))
            {
                throw new ArgumentNullException();
            }
        }
    }
}
