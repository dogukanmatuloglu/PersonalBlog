using PersonalBlog.Core.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalBlog.Core.Models
{
    public class Author:BaseEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string SocialLink { get; set; }
        public virtual ICollection<Blog> Blogs { get; set; }
    }
}
