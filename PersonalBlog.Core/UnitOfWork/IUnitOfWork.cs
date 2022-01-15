using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalBlog.Core.UnitOfWork
{
    interface IUnitOfWork
    {
        Task CommitAsync();
        void Commit();
    }
}
