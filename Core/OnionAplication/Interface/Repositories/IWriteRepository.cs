using OnionDomain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionAplication.Interface.Repositories
{
    public interface IWriteRepository<T> where T : class,IentityBase, new()
    {
        Task AddAsync ( T entity); 
        Task AddRangeAsync (IList<T> entities);
        Task<T>UpdateAsync (T entity);
        Task HardDelete (T entity);
        Task HardDeleteAsync( IList<T> entity);
    }
}
