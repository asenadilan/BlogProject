using BusinessLayer.Abstract;
using BusinessLayer.Concreate;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogProject.Controllers
{
    public class BlogController: Controller
    { 
        IBlogService bm = new BlogManager(new EfBlogRepository());
        public IActionResult Index()
        {
            var blogs = bm.GetAllWithCategory();
            ViewBag.blogs = blogs;
            return View();
        }
        public IActionResult Detail(int id)
        {
           
            var blog = bm.GetBlogDetail(id);
            ViewBag.blog = blog;
            return View();
        }
    }
}
