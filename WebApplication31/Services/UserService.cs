using WebApplication31.Interfaces;
using WebApplication31.Interfaces.Services;
using WebApplication31.Models;
using WebApplication31.Repositories;

namespace WebApplication31.Services
{
    public class UserService : IUserService
    {
        private readonly IRepository<User> _UserRepository;
        public UserService(IRepository<User> UserRepository)
        {
            _UserRepository = UserRepository;
        }

        public IEnumerable<User> GetUsers()
        {
            return _UserRepository.GetUsers();
        }

        public User GetUser(int id)
        {
            return _UserRepository.GetUser(id);
        }
        public void Delete(int id)
        {
            _UserRepository.Delete(id);
        }
        public void Add(User user)
        {
            _UserRepository.Add(user);
        }
    }
}
