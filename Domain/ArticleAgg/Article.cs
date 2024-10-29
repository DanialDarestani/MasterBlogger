using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework_01.Domain;
using MB.Domain.ArticleCategoryAgg;
using MB.Domain.CommentAgg;

namespace MB.Domain.ArticleAgg
{
    public class Article : DomainBase<int>
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Content { get; set; }
        public string Image { get; set; }
        public bool IsDeleted { get; set; }
        public int ArticleCategoryId { get; set; }
        public ArticleCategory ArticleCategory { get; set; }
        public ICollection<Comment> Comments { get; set; }

        public Article(string title, string description, string content, string image,
            int articleCategoryId)
        {
            Title = title;
            Description = description;
            Content = content;
            Image = image;
            IsDeleted = false;
            ArticleCategoryId = articleCategoryId;
            Comments = new List<Comment>();
        }
        public Article() { }

        public void Edit(string title, string description, string content, string image,
            int articleCategoryId)
        {
            Title = title;
            Description = description;
            Content = content;
            Image = image;
            ArticleCategoryId = articleCategoryId;
        }

        public void Delete()
        {
            IsDeleted = true;
        }
        public void Restore()
        {
            IsDeleted = false;
        }
    }
}
