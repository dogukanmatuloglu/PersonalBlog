using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PersonalBlog.Core.Models.Concrete;
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
        private readonly IAuthorService _authorService;

        public BlogController(IBlogService blogService,IMapper mapper, IAuthorService authorService)
        {
            _blogService = blogService;
            _mapper = mapper;
            _authorService = authorService;
        }

        public async Task<IActionResult> Index()
        {
           var Blogs= await _blogService.GetAllAsync();
            return View(_mapper.Map<IEnumerable<BlogDto>>(Blogs));
        }
        [HttpPost]
        public async Task<IActionResult> Insert(BlogDto blogDto)
        {
            await _blogService.AddAsync(_mapper.Map<Blog>(blogDto));
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Insert()
        {
            var authors = await _authorService.GetAllAsync();
            return View(authors);
        }

    }
}
