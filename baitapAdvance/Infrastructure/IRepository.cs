using Microsoft.EntityFrameworkCore;
namespace Infrastructure;

public interface IRepository<T> where T : class
{
    void Add(T entity);
    void Remove(T entity);
    IEnumerable<T> GetAll();
    T GetById(int id);
}

