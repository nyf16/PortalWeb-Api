using PortalWeb.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace PortalWeb.Infrastructure.Persistence
{
    public interface IRepository<T> where T : BaseEntity
    {
        T GetById(int Id);

        IQueryable<T> GetAll { get; }

        IQueryable<T> GetAllNoTracking { get; }

        T Get(Expression<Func<T, bool>> expression, params Expression<Func<T, object>>[] includes);

        IQueryable<T> GetMany(Expression<Func<T, bool>> expression, params Expression<Func<T, Object>>[] includes);

        T InsertWithoutCommit(T entity);

        void InsertBulk(IEnumerable<T> entities);

        void Update(T entity);

        void UpdateWithoutCommit(T entity);

        int Delete(T entity);

        int Remove(T entity);

        int Commit();

        void DeleteBulk(IEnumerable<T> entities);

        bool Any(Expression<Func<T, bool>> expression);



    }
}
