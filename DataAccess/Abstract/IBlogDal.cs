using Core.DataAccess;
using Entity.DTOs;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IBlogDal:IEntityRepository<Blog>
    {
        BlogDetailDto GetBlogDetail(int id);
        List<BlogDetailDto> GetAllWithCategory();
    }
}
