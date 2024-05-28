using Microsoft.EntityFrameworkCore;
using OnionAplication.Interface.Repositories;
using OnionDomain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionPersistance.Repositories
{
    internal class WriteRepository<T> : IWriteRepository<T> where T : class, IentityBase, new()
    {

        private readonly DbContext _dbcontext;
        public WriteRepository(DbContext dbContext)
        {
            _dbcontext = dbContext;
        }
        private DbSet<T> Baglantı { get => _dbcontext.Set<T>(); }

        public async Task AddAsync(T entity)
        {
            await Baglantı.AddAsync(entity);
        }

        public async Task AddRangeAsync(IList<T> entities)
        {
            await Baglantı.AddRangeAsync(entities);
        }

        public async Task HardDelete(T entity)
        {
            await Task.Run(() => Baglantı.Remove(entity));
        }

        public async Task<T> UpdateAsync(T entity)
        {
            await Task.Run(() => Baglantı.Update(entity));
            return entity;
        }
    }
}
