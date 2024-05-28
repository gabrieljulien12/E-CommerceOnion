using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore.Query;
using OnionAplication.Interface.Repositories;
using OnionDomain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OnionPersistance.Repositories
{
    public class ReadRepository<T> : IReadReposirtory<T> where T : class, IentityBase, new()
    {
        private readonly DbContext _dbcontext;
        public ReadRepository(DbContext context)
        {
            _dbcontext = context;
        }

        private DbSet<T> Baglantı
        {
            get => _dbcontext.Set<T>();
        }

        public async Task<IList<T>> GetAllAsync(Expression<Func<T, bool>>? predicate = null, Func<IQueryable<T>, IIncludableQueryable<T, object>>? inculude = null, Func<IQueryable<T>, IOrderedQueryable<T>>? orderby = null, bool enableTracking = false)
        {
            IQueryable<T> queryable = Baglantı;
            if (!enableTracking) queryable = queryable.AsNoTracking();
            if (inculude is not null) queryable = inculude(queryable);
            if (predicate is not null) queryable = queryable.Where(predicate);
            if (orderby is not null)
                return await orderby(queryable).ToListAsync();
            return await queryable.ToListAsync();

        }

        public  async Task<IList<T>> GetAllByPagingAsync(Expression<Func<T, bool>>? predicate = null, Func<IQueryable<T>, IIncludableQueryable<T, object>>? inculude = null, Func<IQueryable<T>, IOrderedQueryable<T>>? orderby = null, bool enableTracking = false, int currentpage = 1, int pagesize = 3)
        {
            IQueryable<T> queryable = Baglantı;
            if (!enableTracking) queryable = queryable.AsNoTracking();
            if (inculude is not null) queryable = inculude(queryable);
            if (predicate is not null) queryable = queryable.Where(predicate);
            if (orderby is not null)
                return await orderby(queryable).Skip((currentpage -1) *pagesize).Take(pagesize).ToListAsync();

            return await queryable.Skip((currentpage - 1) * pagesize).Take(pagesize).ToListAsync();
        }
        public async Task<T> GetAsync(Expression<Func<T, bool>> predicate, Func<IQueryable<T>, IIncludableQueryable<T, object>>? inculude = null, bool enableTracking = false)
        {
            IQueryable<T> queryable = Baglantı;
            if (!enableTracking) queryable = queryable.AsNoTracking();
            if (inculude is not null) queryable = inculude(queryable);

            //queryable.Where(predicate);

            return await queryable.FirstOrDefaultAsync(predicate);
        }

        public async Task<int> CountAsync(Expression<Func<T, bool>>? predicate = null)
        {
            Baglantı.AsNoTracking();
            if (predicate is not null) Baglantı.Where(predicate);

            return await Baglantı.CountAsync();
        }

        public IQueryable<T> Find(Expression<Func<T, bool>> predicate, bool enableTracking = false)
        {
            if (!enableTracking) Baglantı.AsNoTracking();
            return Baglantı.Where(predicate);

        }
    }
}
