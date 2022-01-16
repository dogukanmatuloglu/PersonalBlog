using PersonalBlog.Core.Repositories;
using PersonalBlog.Core.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalBlog.Data.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;


        public UnitOfWork(AppDbContext context)
        {
            _context = context;
        }

        public IAuthorRepository Authors => throw new NotImplementedException();

        public IBlogRepository Blogs => throw new NotImplementedException();

        public void Commit()
        {
            _context.SaveChanges();
        }

        public async Task CommitAsync()
        {
           await _context.SaveChangesAsync();
        }
    }
}
