using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PersonalBlog.Core.Services
{
    public interface IService<T> where T:class
    {
        Task<T> GetByIdAsync(int id);
        Task<IEnumerable<T>> GetAllAsync();

        Task AddAsync(T entity);

        Task UpdateAsync(T entity);//burada EF Core SaveChangesAsync metodu kullanılacağı için dönüş tipinin void yerine Task olması gerekiyor.
        Task DeleteAsync(T entity);//burada EF Core SaveChangesAsync metodu kullanılacağı için dönüş tipinin void yerine Task olması gerekiyor.
        IQueryable<T> Where(Expression<Func<T, bool>> expression);
        Task<bool> AnyAsync(Expression<Func<T, bool>> expression);
    }
}
