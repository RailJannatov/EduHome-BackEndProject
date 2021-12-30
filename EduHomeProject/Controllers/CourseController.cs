using EduHomeProject.DataAccessLayer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeProject.Controllers
{
    public class CourseController : Controller
    {
        private readonly AppDbContext _dbContext;
        public CourseController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<IActionResult> Index()
        {
            return View();
        }
        public async Task<IActionResult> CourseDetail(int? id)
        {
            if(id == null)
            {
                return NotFound();
            }
            var courses = await _dbContext.Courses
                .Include(x => x.CourseCategories)
                .ThenInclude(x => x.Category)
                .Include(x => x.CourseDetail)
                .FirstOrDefaultAsync(x => x.Id == id && x.isDeleted == false);
            if(courses == null)
            {
                return NotFound();
            }
            return View(courses);

        }
    }
}
