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
        public void Delete(User user)
        {
            _dbContext.Remove(user);
            _dbContext.SaveChanges();
        }
        public IEnumerable<User> GetUsers()
        {
            return _dbContext.Users.ToList();
        }
        public User GetUser(User user)
        {
            return _dbContext.Users.Find(user);
        }

    }
}
