using System;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Personnel.DAL;
using Personnel.Domains;
using System.Collections;
using System.Collections.Generic;
using Personnel.DAL.Repositories.Abstract;
namespace Personnel.DAL.Repositories.Concrete
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity:class
    {
        protected DbContext _context;
        private DbSet<TEntity> dbSet;
       public Repository(DbContext context)
       {
           _context=context;
           dbSet=context.Set<TEntity>();
       }
       public void Add(TEntity entity){
           dbSet.Add(entity);
       }
       public void AddRange(IEnumerable<TEntity> entities)
       {
           dbSet.AddRange(entities);
       }
       public IEnumerable<TEntity> GetAll()
       {
           return dbSet.ToList();
       }
       public TEntity GetById(int id)
       {
           return dbSet.Find(id);
       }

       public void Remove(int id)
       {
           dbSet.Remove(GetById(id));
       }
        public void RemoveRange(IEnumerable<TEntity> entities)
        {
            dbSet.RemoveRange(entities);
        }

    }
}