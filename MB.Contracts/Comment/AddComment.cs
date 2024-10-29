namespace MB.Contracts.Comment;

public class AddComment
{
    public string UserName { get; init; }
    public string Email { get; init; }
    public string Message { get; init; }
    public int ArticleId { get; init; }
}