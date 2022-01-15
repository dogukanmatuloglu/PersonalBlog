using Microsoft.EntityFrameworkCore;

using PersonalBlog.Core.Models.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PersonalBlog.Data
{
    class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) :base(options)
        {

        }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Blog> Blogs { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());//herbir libary bizim için bir assembly dir 
            //bu metod bizim için reflection sayesinde IEntityTypeConfiguration implemente edilmiş sınıfları bulur.
        }
    }
}
