using OnionAplication.Interface.Repositories;
using OnionDomain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionAplication.Interface.UnitOfWorks
{
    public interface IUnitOfWork : IAsyncDisposable
    {
        IReadReposirtory<T> GetReadReposirtory<T>() where T : class, IentityBase, new();
        IWriteRepository<T> GetWriteReposirtory<T>() where T : class, IentityBase, new();
        Task<int> SaveAsync();
        int Save();

    }
}
