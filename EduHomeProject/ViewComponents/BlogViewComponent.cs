﻿using EduHomeProject.DataAccessLayer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeProject.ViewComponents
{
    public class BlogViewComponent:ViewComponent
    {
        private readonly AppDbContext _dbContext;
        public BlogViewComponent(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var blogs = await _dbContext.Blogs.ToListAsync();
            return View(blogs);
        }
    }
}
