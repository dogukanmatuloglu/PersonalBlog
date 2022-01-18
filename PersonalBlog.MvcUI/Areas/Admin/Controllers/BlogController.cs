using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PersonalBlog.Core.Services;
using PersonalBlog.MvcUI.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalBlog.MvcUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BlogController : Controller
    {
        private readonly IBlogService _blogService;
        private readonly IMapper _mapper;

        public BlogController(IBlogService blogService,IMapper mapper)
        {
            _blogService = blogService;
            _mapper = mapper;
        }

        public async Task<IActionResult> Index()
        {
           var Blogs= await _blogService.GetAllAsync();
            return View(_mapper.Map<IEnumerable<BlogDto>>(Blogs));
        }
    }
}
