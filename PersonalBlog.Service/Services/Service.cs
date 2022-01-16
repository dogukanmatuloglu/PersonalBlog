using PersonalBlog.Core.Repositories;
using PersonalBlog.Core.Services;
using PersonalBlog.Core.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PersonalBlog.Service.Services
{
    public class Service<T> : IService<T> where T : class
    {
        public readonly IUnitOfWork _unitOfWork;
        private readonly IGenericRepository<T> _repository;

        public Service(IUnitOfWork unitOfWork, IGenericRepository<T> repository)
        {
            _unitOfWork = unitOfWork;
            _repository = repository;
        }

        public async Task AddAsync(T entity)
        {
           await _repository.AddAsync(entity);
            await _unitOfWork.CommitAsync();
        }

        public async Task<bool> AnyAsync(Expression<Func<T, bool>> expression)
        {
           return await _repository.AnyAsync(expression);
        }

        public async Task DeleteAsync(T entity)
        {
             _repository.Delete(entity);
            await _unitOfWork.CommitAsync();
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
           return await _repository.GetAllAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public async Task UpdateAsync(T entity)
        {
            _repository.Update(entity);
            await _unitOfWork.CommitAsync();
        }

        public IQueryable<T> Where(Expression<Func<T, bool>> expression)
        {
            return _repository.Where(expression);
        }
    }
}
