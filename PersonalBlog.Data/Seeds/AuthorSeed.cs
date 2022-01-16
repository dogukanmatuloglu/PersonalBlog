using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PersonalBlog.Core.Models.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalBlog.Data.Seeds
{
    public class AuthorSeed : IEntityTypeConfiguration<Author>
    {
        public void Configure(EntityTypeBuilder<Author> builder)
        {
            builder.HasData(new Author { Id = 1, Name = "Doğukan", Surname = "Matuloğlu", Password = "123456789", SocialLink = "www.pornhub.com" });

        }
    }
}
