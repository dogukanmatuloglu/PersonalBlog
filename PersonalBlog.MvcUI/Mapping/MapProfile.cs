using AutoMapper;
using PersonalBlog.Core.Models.Concrete;
using PersonalBlog.MvcUI.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalBlog.MvcUI.Mapping
{
    public class MapProfile:Profile
    {
        public MapProfile()
        {
            CreateMap<Blog, BlogDto>();
            CreateMap<BlogDto, Blog>();

        }
    }
}
