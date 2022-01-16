using PersonalBlog.Core.Models.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalBlog.Core.Repositories
{
    public interface IBlogRepository:IGenericRepository<Blog>
    {
        Task<Blog> GetWithAuthorAsync(int blogid);
    }
}
