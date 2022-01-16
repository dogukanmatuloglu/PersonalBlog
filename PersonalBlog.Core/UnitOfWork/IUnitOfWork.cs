using PersonalBlog.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalBlog.Core.UnitOfWork
{
    public interface IUnitOfWork
    {
        IAuthorRepository Authors { get; }
        IBlogRepository Blogs { get; }
        Task CommitAsync();
        void Commit();
    }
}
