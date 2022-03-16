namespace WebApplication31.Interfaces
{
    public interface IRepository<T> where T : class
    {
        void Add(T entity);
        void Delete(T entity);
        IEnumerable<T> GetUsers();
        T GetUser(T entity);
    }
}
