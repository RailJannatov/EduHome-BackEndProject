using EduHomeProject.DataAccessLayer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeProject.ViewComponents
{
    public class TeacherViewComponent:ViewComponent
    {
        private readonly AppDbContext _dbContext;
        public TeacherViewComponent(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<IViewComponentResult> InvokeAsync(int take = 4)
        {
            var teachers = await _dbContext.Teachers.Take(take).Include(x=>x.SocialAdresses).ToListAsync();
            return View(teachers);

        }
    }
}
