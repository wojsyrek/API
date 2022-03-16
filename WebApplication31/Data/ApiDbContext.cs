using Microsoft.EntityFrameworkCore;
using WebApplication31.Models;

namespace WebApplication31.Data
{
    public class ApiDbContext : DbContext
    {
        public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options) { }
 
        public DbSet<User> Users {  get; set; }
    }
}
