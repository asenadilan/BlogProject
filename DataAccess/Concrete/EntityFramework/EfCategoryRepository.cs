using Core.DataAccess.EntityRepository;
using DataAccess.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCategoryRepository:EfEntityRepositoryBase<Category,Context>, ICategoryDal
    {
       
    }
}
