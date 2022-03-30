using Microsoft.EntityFrameworkCore;
using WebApplication31.Data;
using WebApplication31.Interfaces;
using WebApplication31.Models;

namespace WebApplication31.Repositories
{
    public class UserRepository : IRepository<User>
    {
        private readonly ApiDbContext _dbContext;

        public UserRepository(ApiDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        
        public void Add(User user)
        {
            _dbContext.Add(user);
            _dbContext.SaveChanges();
        }
        public void Delete(int id)
        {
            var user = _dbContext.Users.FirstOrDefault(u => u.Id == id);
            if (user != null)
            {
                _dbContext.Users.Remove(user);
                _dbContext.SaveChanges();
            }
        }
        public IEnumerable<User> GetUsers()
        {
            return _dbContext.Users.ToList();
        }
        public User? GetUser(int id)
        {
            return _dbContext.Users.SingleOrDefault(u => u.Id == id);
        }

    }
}
