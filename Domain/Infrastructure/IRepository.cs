using System.Linq;

namespace Domain.Infrastructure
{
  public interface IRepository<T>
  {
    T Get<TKey>(TKey id);
    IQueryable<T> GetAll();
    void Add(T entity);
    void Update(T entity);
    void Delete(T entity);
  }
}