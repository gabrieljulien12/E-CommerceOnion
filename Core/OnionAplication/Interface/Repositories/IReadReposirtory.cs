using Microsoft.EntityFrameworkCore.Query;
using OnionDomain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OnionAplication.Interface.Repositories
{
    public interface IReadReposirtory<T> where T : class,IentityBase,new ()
    {
        Task<IList<T>> GetAllAsync(Expression<Func<T, bool>>? predicate = null,//Filter
            Func<IQueryable<T>,IIncludableQueryable<T,object>>? inculude = null,//include
            Func<IQueryable<T>,IOrderedQueryable<T>>? orderby =null,//sıralama
            bool enableTracking =false);// izlemegi kapatmak bize perfomans iyileşmesi saglar ancak veri degişimini ve testi zorlastırır
        Task<IList<T>> GetAllByPagingAsync(Expression<Func<T, bool>>? predicate = null,
            Func<IQueryable<T>, IIncludableQueryable<T, object>>? inculude = null,
            Func<IQueryable<T>, IOrderedQueryable<T>>? orderby = null,
            bool enableTracking = false, int currentpage = 1, int pagesize =3);//sayfaları sıralar
        Task<T> GetAsync(Expression<Func<T, bool>> predicate, Func<IQueryable<T>, IIncludableQueryable<T, object>>? inculude = null, bool enableTracking = false);
        IQueryable<T> Find(Expression<Func<T,bool>> predicatei,bool enableTracking = false);
        Task<int> CountAsync(Expression<Func<T, bool>>? predicate = null);// yapılan sorguda dönen kayıtın sayısını temsil edilmesi için yazılmıstır
    }
}
