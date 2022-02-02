using System.Collections;
using System.Collections.Generic;
using System.Linq;
public interface IRepository<TEntity> where  TEntity:class
{
    TEntity GetById(int id);
    IEnumerable<TEntity> GetAll();
    void Add(TEntity entity);
    void Remove(int id);
    void AddRange(IEnumerable<TEntity> entities);
    void RemoveRange(IEnumerable<TEntity> entities);

}