﻿using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Domain.Infrastructure
{
  public class Repository<T> : IRepository<T> where T : class
  {
    protected readonly DbContext Context;
    protected DbSet<T> DbSet;

    public Repository(OnlineShopContext context)
    {
      Context = context;
      DbSet = context.Set<T>();
    }

    public void Add(T entity)
    {
      Context.Set<T>().Add(entity);

      Save();
    }

    public T Get<TKey>(TKey id)
    {
      return DbSet.Find(id);
    }

    public IQueryable<T> GetAll()
    {
      return DbSet;
    }

    public void Update(T entity)
    {
      Save();
    }

    private void Save()
    {
      Context.SaveChanges();
    }

    public void Delete(T entity)
    {
      DbSet.Remove(entity);
      Save();
    }
  }
}
