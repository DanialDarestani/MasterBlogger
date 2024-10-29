using Framework_01.Infrastructure;
using MB.Application.Abstractions.Article;
using MB.Application.Abstractions.Comment;
using MB.Contracts.Comment;
using MB.Domain.CommentAgg;

namespace MB.Application
{
    public class CommentApplication : ICommentApplication
    {
        protected readonly ICommentRepository _CommentRepository;
        protected readonly IUnitOfWork _unitOfWork;

        public CommentApplication(ICommentRepository CommentRepository, IUnitOfWork unitOfWork)
        {
            _CommentRepository= CommentRepository;
            _unitOfWork = unitOfWork;
        }

        public void Cancel(int id)
        {
            _unitOfWork.BeginTran();
            var comment = _CommentRepository.Get(id);
            comment.Cancel();
            _unitOfWork.CommitTran();
        }

        public void Confirm(int id)
        {
            _unitOfWork.BeginTran();
            var comment = _CommentRepository.Get(id);
            comment.Confirm();
            _unitOfWork.CommitTran();
        }

        public void Create(AddComment entity)
        {
            _unitOfWork.BeginTran();
            var comment = new Comment(entity.UserName,entity.Email,entity.Message,entity.ArticleId);
            _CommentRepository.Create(comment);
            _unitOfWork.CommitTran();
        }

        public List<CommentViewModel> GetAll()
        {
            List<Comment> cl = _CommentRepository.GetAllViewModel();
            List<CommentViewModel> cvml = new List<CommentViewModel>();
            foreach (var c in cl)
            {
                cvml.Add(new CommentViewModel()
                {
                    Id = c.Id,
                    UserName = c.UserName,
                    Email = c.Email,
                    Message = c.Message,
                    Article = c.Article.Title,
                    Status = c.Status,
                    CreationDate = c.CreationTime.ToString()
                });
            }
            return cvml;
        }
    }
}