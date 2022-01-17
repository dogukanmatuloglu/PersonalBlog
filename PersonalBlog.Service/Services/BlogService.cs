using PersonalBlog.Core.Models.Concrete;
using PersonalBlog.Core.Repositories;
using PersonalBlog.Core.Services;
using PersonalBlog.Core.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalBlog.Service.Services
{
    public class BlogService : Service<Blog>, IBlogService
    {
        public BlogService(IUnitOfWork unitOfWork, IGenericRepository<Blog> repository) : base(unitOfWork, repository)
        {
        }

        public async Task<Blog> GetWithAuthorAsync(int blogid)
        {
           return await _unitOfWork.Blogs.GetWithAuthorAsync(blogid);
        }
    }
}
