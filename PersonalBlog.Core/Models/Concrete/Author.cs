using PersonalBlog.Core.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalBlog.Core.Models.Concrete
{
    public class Author:BaseEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string SocialLink { get; set; }
        public string Password { get; set; }
        public virtual ICollection<Blog> Blogs { get; set; }
    }
}
