using OdevBir.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OderBir.Repository.Common
{
    public class BaseRepository<TSource> : IBaseRepository<TSource> where TSource : class
    {

        private readonly NorthwndContext _northwndContext;

        public BaseRepository(NorthwndContext northwndContext)
        {
            _northwndContext = northwndContext;
        }

        public IQueryable<TSource> GetAll()
        {
            return _northwndContext.Set<TSource>().AsQueryable();
        }

        public IQueryable<TSource> Get(Expression<Func<TSource, bool>> predicate)
        {
            return _northwndContext.Set<TSource>().Where(predicate).AsQueryable();
        }

        public void InsertOneAsync(TSource entity)
        {
            _northwndContext.Set<TSource>().Add(entity);
            _northwndContext.SaveChanges();
        }

        public void UpdateAsync(TSource entity)
        {
            _northwndContext.Set<TSource>().Update(entity);
            _northwndContext.SaveChanges();
        }
        public void DeleteAsync(TSource entity)
        {
            _northwndContext.Set<TSource>().Remove(entity);
            _northwndContext.SaveChanges();
        }
    }
}
