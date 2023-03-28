using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using Sample.Application.Interfaces;
using Sample.Domain.Entities;
using Sample.Infrastructure.Context;

namespace Sample.Infrastructure.Repositories
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : BaseEntity
    {
        private readonly ApplicationDbContext _dbContext;

        public DbSet<T> Table { get; }

        protected RepositoryBase(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
            Table = dbContext.Set<T>();
        }

        public T GetById(int id)
        {
            return Table.Find(id);
        }

        public void Add(T entity)
        {
            Table.Add(entity);
        }

        public void Update(T entity)
        {
            Table.Update(entity);
        }

        public void Delete(T entity)
        {
            Table.Remove(entity);
        }

        public void AddRange(IEnumerable<T> entities)
        {
            Table.AddRange(entities);
        }

        public void RemoveRange(IEnumerable<T> entities)
        {
            Table.RemoveRange(entities);
        }

        public IQueryable<T> All()
        {
            return Table;
        }

        public IQueryable<T> Where(Expression<Func<T, bool>> where)
        {
            return Table.Where(where);
        }

        public IQueryable<T> OrderBy<TKey>(Expression<Func<T, TKey>> orderBy, bool isDesc)
        {
            return isDesc ? Table.OrderByDescending(orderBy) : Table.OrderBy(orderBy);
        }
    }
}