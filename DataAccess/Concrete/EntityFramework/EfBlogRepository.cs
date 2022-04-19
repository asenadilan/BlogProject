using Core.DataAccess.EntityRepository;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using Entity.DTOs;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfBlogRepository: EfEntityRepositoryBase<Blog,Context>, IBlogDal
    {
        public List<BlogDetailDto> GetAllWithCategory()
        {
            using (Context context = new Context())
            {
                var result = from b in context.Blogs
                             join c in context.Categories
                             on b.CategoryId equals c.CategoryId
                             select new BlogDetailDto
                             {
                                 BlogId = b.BlogId,
                                 CategoryId = c.CategoryId,
                                 CategoryName = c.CategoryName,
                                 BlogTitle = b.BlogTitle,
                                 BlogContent = b.BlogContent,
                                 BlogCreateDate = b.BlogCreateDate
                             };
                return result.ToList();
            }
        }

        public BlogDetailDto GetBlogDetail(int id)
        {
            using (Context context = new Context())
            {

                var result = from b in context.Blogs.Where(b => b.BlogId == id)
                             join c in context.Categories
                             on b.CategoryId equals c.CategoryId
                             select new BlogDetailDto
                             {
                                 BlogId = b.BlogId,
                                 CategoryId = c.CategoryId,
                                 CategoryName = c.CategoryName,
                                 BlogTitle = b.BlogTitle,
                                 BlogContent = b.BlogContent,
                                 BlogCreateDate = b.BlogCreateDate
                             };
                return result.FirstOrDefault();
            }
        }
    }
}
