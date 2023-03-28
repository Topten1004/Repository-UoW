using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using Sample.Domain.Entities;

namespace Sample.Application.Interfaces
{
    public interface IRepositoryBase<T> where T : BaseEntity
    {
        T GetById(int id);
       
        DbSet<T> Table { get; }
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        
        void AddRange(IEnumerable<T> entities);
        void RemoveRange(IEnumerable<T> entities);

        IQueryable<T> All();
        IQueryable<T> Where(Expression<Func<T, bool>> where);
        IQueryable<T> OrderBy<TKey>(Expression<Func<T, TKey>> orderBy, bool isDesc);
    }
}