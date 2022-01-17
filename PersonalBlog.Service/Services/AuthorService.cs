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
    public class AuthorService:Service<Author>,IAuthorService
    {
        public AuthorService(IUnitOfWork unitOfWork, IGenericRepository<Author> repository):base(unitOfWork,repository)
        {
           
        }

        public async Task<Author> GetWithBlogAsync(int authorid)
        {
           return await _unitOfWork.Authors.GetWithBlogAsync(authorid);
        }
    }
}
