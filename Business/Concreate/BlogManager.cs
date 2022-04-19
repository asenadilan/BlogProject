using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using Entity.DTOs;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concreate
{
    public class BlogManager: IBlogService
    {
        IBlogDal _blogDal;

        public BlogManager(IBlogDal blogDal)
        {
            _blogDal = blogDal;
        }

        public Blog GetBlogById(int id)
        {
            return _blogDal.Get(b=>b.BlogId == id);
        }

        public List<Blog> GetAll()
        {
            return _blogDal.GetAll();
        }

        public BlogDetailDto GetBlogDetail(int blogId)
        {
            return _blogDal.GetBlogDetail(blogId);
        }

        public List<BlogDetailDto> GetAllWithCategory()
        {
            return _blogDal.GetAllWithCategory();
        }

        public List<Blog> GetAllByCategory(int categoryId)
        {
            return _blogDal.GetAll(b => b.CategoryId == categoryId);
        }
    }
}
