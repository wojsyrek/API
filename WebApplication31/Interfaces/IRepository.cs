namespace WebApplication31.Interfaces
{
    public interface IRepository<T> where T : class
    {
        void Add(T entity);
        void Delete(int id);
        IEnumerable<T> GetUsers();
        T GetUser(int id);
    }
}
