using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalBlog.Core.Models
{
    public class Blog
    {

        public string Title { get; set; }
        public string Content { get; set; }
        public string İmage { get; set; }
        public int AuthorId { get; set; }
        public virtual Author Author { get; set; }

    }
}
