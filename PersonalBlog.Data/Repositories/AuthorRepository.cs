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
    public class AuthorRepository : GenericRepository<Author>, IAuthorRepository
    {
        public AppDbContext dbContext { get => _context; }


        public AuthorRepository(AppDbContext context):base(context)
        {
      
        }
        public async Task<Author> GetWithBlogAsync(int authorid)
        {
            return await dbContext.Authors.Include(x => x.Blogs).SingleOrDefaultAsync(x => x.Id == authorid);
        }
    }
}
