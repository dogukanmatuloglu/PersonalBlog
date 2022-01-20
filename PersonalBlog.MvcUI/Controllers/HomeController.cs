using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalBlog.MvcUI.Controllers
{
    
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var data= Url.Action("Insert", "Blog", new { area = "Admin" },null);
            return View();
        }
    }
}
