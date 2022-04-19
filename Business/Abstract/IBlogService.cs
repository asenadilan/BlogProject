﻿using Entity.DTOs;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IBlogService
    {
        List<Blog> GetAll();
        List<Blog> GetAllByCategory(int categoryId);
        Blog GetBlogById(int id);
        BlogDetailDto GetBlogDetail(int blogId);
        List<BlogDetailDto> GetAllWithCategory();

    }
}