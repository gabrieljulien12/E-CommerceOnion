using OnionAplication.Interface.Repositories;
using OnionAplication.Interface.UnitOfWorks;
using OnionPersistance.Context;
using OnionPersistance.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionPersistance.UnitOfWorks
{
    public class UnitOfWork : IUnitOfWork
    {
       private readonly AppDbContext _appDbContext;
        public UnitOfWork(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public async ValueTask DisposeAsync() =>  await _appDbContext.DisposeAsync();


        public int Save() => _appDbContext.SaveChanges();
        

        public async Task<int> SaveAsync() => await _appDbContext.SaveChangesAsync();


        IReadReposirtory<T> IUnitOfWork.GetReadReposirtory<T>() => new ReadRepository<T>(_appDbContext);
        

        IWriteRepository<T> IUnitOfWork.GetWriteReposirtory<T>() => new WriteRepository<T>(_appDbContext);
       
    }
}
