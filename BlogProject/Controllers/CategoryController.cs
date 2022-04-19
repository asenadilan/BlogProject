using Business.Abstract;
using Business.Concreate;
using BusinessLayer.Abstract;
using BusinessLayer.Concreate;
using DataAccess.Concrete.EntityFramework;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogProject.Controllers
{
    public class CategoryController: Controller
    {
        ICategoryService cm = new CategoryManager(new EfCategoryRepository());
        public IActionResult Index()
        {
            var categories = cm.GetAll();
            ViewBag.categories = categories;
            return View();
        }

        public IActionResult Detail(int id)
        {
            IBlogService bm = new BlogManager(new EfBlogRepository());
            var blogs = bm.GetAllByCategory(id);
            ViewBag.blogs = blogs;
            return View();
        }
    }
}
