using WebApplication31.Data;
using WebApplication31.Interfaces;
using WebApplication31.Models;

namespace WebApplication31.Repositories
{
    public class RepositoryWorker : IRepositoryWorker
    {
        private readonly ApiDbContext _context;
        public RepositoryWorker(ApiDbContext dbContext)
        {
            _context = dbContext;
        }
        IRepository<User> userRepository = null;
        public IRepository<User> UserRepository
        {
            get
            {
                if (userRepository == null)
                    userRepository = new UserRepository(_context);
                return userRepository;
            }
        }
    }
}
