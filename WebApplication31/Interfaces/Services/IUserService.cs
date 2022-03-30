using WebApplication31.Models;

namespace WebApplication31.Interfaces.Services
{
    public interface IUserService
    {
        public void Add(User user);
        public void Delete(int id);
        public IEnumerable<User> GetUsers();
        public User GetUser(int id);

    }
}
