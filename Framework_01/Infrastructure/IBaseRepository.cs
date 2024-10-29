using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Framework_01.Domain;

namespace Framework_01.Infrastructure
{
    public interface IBaseRepository<in TKey,T> where T : DomainBase<TKey>
    {
        void Create(T entity);
        T Get(TKey id);
        List<T> GetAll();
        bool Exists(Expression<Func<T, bool>> expression);
    }
}
