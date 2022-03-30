using WebApplication31.Models;

namespace WebApplication31.Interfaces
{
    public interface IRepositoryWorker
    {
        IRepository<User> UserRepository { get; }
    }
}
