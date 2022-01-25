using PersonalBlog.Core.Models.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalBlog.MvcUI.DTOs
{
    public class BlogDto
    {
        public int Id { get; set; }

        public string Title { get; set; }
        public string Content { get; set; }
        public string İmage { get; set; }
        public int AuthorId { get; set; }
        public Author Author { get; set; }


    }
}
