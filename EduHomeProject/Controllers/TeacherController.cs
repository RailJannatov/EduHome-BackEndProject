using EduHomeProject.DataAccessLayer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeProject.Controllers
{
    public class TeacherController : Controller
    {
        private readonly AppDbContext _dbContext;
        public TeacherController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<IActionResult> Index()
        {
            return View();
        }
        public async Task<IActionResult> TeacherDetail(int? id)
        {
            if(id == null)
            {
                return NotFound();
            }
            var teacherDetail = await _dbContext.Teachers
                
                .Include(x => x.TeacherProfessions)
                .ThenInclude(x=>x.Profession)
                .Include(x => x.TeacherDetail)
                .ThenInclude(x=>x.Skill)
                .Include(x=>x.TeacherDetail)
                .ThenInclude(x=>x.ContactInformation)
                .Include(x=>x.SocialAdresses)
                .FirstOrDefaultAsync(x => x.Id == id && x.isDeleted == false);
            if(teacherDetail == null)
            {
                return NotFound();
            }
            return View(teacherDetail);
        }
        public async Task<IActionResult> Search(string search)
        {
            if (string.IsNullOrEmpty(search))
            {
                return NotFound();
            }

            var teachers = await _dbContext.Teachers.Where(x=> x.Name.ToLower().Contains(search.ToLower()))
                .Include(x => x.TeacherProfessions).ThenInclude(x => x.Profession)
                .Include(x => x.SocialAdresses).ToListAsync();

            return PartialView("_TeacherSearchPartial", teachers);
        }
    }
}
