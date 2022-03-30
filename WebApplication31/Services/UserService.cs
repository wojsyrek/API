using WebApplication31.Interfaces;
using WebApplication31.Interfaces.Services;
using WebApplication31.Models;
using WebApplication31.Repositories;

namespace WebApplication31.Services
{
    public class UserService : IUserService
    {
        private readonly IRepositoryWorker _repositoryWorker;
        public UserService(IRepositoryWorker repositoryWorker)
        {
            _repositoryWorker = repositoryWorker;
        }

        public IEnumerable<User> GetUsers()
        {
            return _repositoryWorker.UserRepository.GetUsers();
        }

        public User GetUser(int id)
        {
            return _repositoryWorker.UserRepository.GetUser(id);
        }
        public void Delete(int id)
        {
            _repositoryWorker.UserRepository.Delete(id);
        }
        public void Add(User user)
        {
            _repositoryWorker.UserRepository.Add(user);
        }
    }
}
