using Microsoft.EntityFrameworkCore;
using PersonalBlog.Core.Models.Concrete;
using PersonalBlog.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalBlog.Data.Repositories
{
    public class BlogRepository : GenericRepository<Blog>, IBlogRepository
    {
        private AppDbContext _dbContext { get => _context; }
      

        public BlogRepository(AppDbContext context):base(context)
        {
                   
        }
        

        public async Task<Blog> GetWithAuthorAsync(int blogid)
        {
            return await _dbContext.Blogs.Include(x => x.Author).SingleAsync(x => x.Id == blogid);
        }
    }
} 
