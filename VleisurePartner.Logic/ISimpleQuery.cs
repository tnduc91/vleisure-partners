using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using VleisurePartner.Domain;

namespace VleisurePartner.Logic
{
    public interface ISimpleQuery<TEntity>
    {
        TProjection Single<TProjection>(Expression<Func<TEntity, bool>> predicate, Expression<Func<TEntity, TProjection>> projection);
        TProjection SingleOrDefault<TProjection>(Expression<Func<TEntity, bool>> predicate, Expression<Func<TEntity, TProjection>> projection);

        IEnumerable<TProjection> AsEnumerable<TProjection>(Expression<Func<TEntity, bool>> predicate, Expression<Func<TEntity, TProjection>> projection);

        bool Any(Expression<Func<TEntity, bool>> predicate);
        bool All(Expression<Func<TEntity, bool>> predicate);
        IEnumerable<TProjection> Distinct<TProjection>(Expression<Func<TEntity, bool>> predicate, Expression<Func<TEntity, TProjection>> projection);
    }

    public class SimpleQuery<TEntity> : ISimpleQuery<TEntity> where TEntity : class
    {
        private readonly IQueryable<TEntity> _set;

        public SimpleQuery(IContext context)
        {
            _set = (context.GetType()
                    .GetProperties()
                    .Single(pi => pi.PropertyType == typeof(IDbSet<TEntity>))
                    .GetValue(context) as IDbSet<TEntity>
                )
                .AsNoTracking();
        }

        public TProjection Single<TProjection>(Expression<Func<TEntity, bool>> predicate, Expression<Func<TEntity, TProjection>> projection)
        {
            return _set.Where(predicate).Select(projection).Single();
        }

        public TProjection SingleOrDefault<TProjection>(Expression<Func<TEntity, bool>> predicate, Expression<Func<TEntity, TProjection>> projection)
        {
            return _set.Where(predicate).Select(projection).SingleOrDefault();
        }

        public IEnumerable<TProjection> AsEnumerable<TProjection>(Expression<Func<TEntity, bool>> predicate, Expression<Func<TEntity, TProjection>> projection)
        {
            return _set.Where(predicate).Select(projection).AsEnumerable();
        }

        public bool Any(Expression<Func<TEntity, bool>> predicate)
        {
            return _set.Any(predicate);
        }

        public bool All(Expression<Func<TEntity, bool>> predicate)
        {
            return _set.All(predicate);
        }

        public IEnumerable<TProjection> Distinct<TProjection>(Expression<Func<TEntity, bool>> predicate, Expression<Func<TEntity, TProjection>> projection)
        {
            return _set.Where(predicate).Select(projection).Distinct().AsEnumerable();
        }
    }
}
