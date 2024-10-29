using Framework_01.Domain;
using MB.Domain.ArticleAgg;

namespace MB.Domain.CommentAgg
{
    public class Comment : DomainBase<int>
    {
        public string UserName { get; init; }
        public string Email { get; init; }
        public string Message { get; init; }
        public int Status { get; set; }
        public int ArticleId { get; init; }
        public Article Article { get; init; }

        protected Comment()
        {

        }
        public Comment(string userName, string email, string message, int articleId)
        {
            UserName = userName;
            Email = email;
            Message = message;
            ArticleId = articleId;
            Status = Statuses.New;
        }

        public void Confirm()
        {
            Status = Statuses.Confirmed;
        }
        public void Cancel()
        {
            Status = Statuses.Canceled;
        }
    }
}
