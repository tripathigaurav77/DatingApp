namespace API.Interfaces
{
    public interface IUnitOfWork
    {
        IUserRepository UserRepository { get; }
        IMessageRepository MessageRepository { get; }
        ILikeRepository LikesRepository { get; }
        Task<bool> Complete();
        bool HasChanges();
    }
}