using EduHomeProject.Areas.AdminPanel.Data;
using EduHomeProject.DataAccessLayer;
using EduHomeProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeProject.Areas.AdminPanel.Controllers
{
    [Area("AdminPanel")]
    public class TeacherController : Controller
    {
        private readonly AppDbContext _dbContext;
        public TeacherController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

      
        public async Task<IActionResult> Index()
        {
            var teachers = await _dbContext.Teachers.Where(x => x.isDeleted == false).ToListAsync();
           
            return View(teachers);
        }
        public async Task<IActionResult> Create()
        {
            var teacherProffesions = await _dbContext.Professions.Where(x => x.isDeleted == false).ToListAsync();
            ViewBag.Professions = teacherProffesions;

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Teacher teacher , int?[] professionId)
        {
            var teacherProffesions = await _dbContext.Professions.Where(x => x.isDeleted == false).ToListAsync();
            ViewBag.Professions = teacherProffesions;
            if (!ModelState.IsValid)
            {
                return View(teacher);
            }


            if (teacher.Photo == null)
            {
                ModelState.AddModelError("Photo", "Please,choose image");
                return View();
            }

            if (!teacher.Photo.IsImage())
            {
                ModelState.AddModelError("Photo", "Please,choose image");
                return View();
            }

            if (!teacher.Photo.IsSizeAllowed(4))
            {
                ModelState.AddModelError("Photo", "Uploaded photo is more than 4mb");
                return View();
            }
            if (professionId.Length == 0 || professionId == null)
            {
                ModelState.AddModelError("", "Please,Choose profession");
                return View();
            }

            var fileName = await FileUtil.GenerateFile(Constants.ImageFolderPath, teacher.Photo);
            teacher.TeacherImageName = fileName;


            var teacherProfessionList = new List<TeacherProfession>();
            foreach (var item in professionId)
            {
                var teacherProfession = new TeacherProfession
                {
                    ProfessionId = (int)item,
                    TeacherId = teacher.Id
                };
                teacherProfessionList.Add(teacherProfession);
            }
            teacher.TeacherProfessions = teacherProfessionList;

            teacher.isDeleted = false;
            await _dbContext.AddAsync(teacher);
            await _dbContext.SaveChangesAsync();

            return RedirectToAction("Index");
        }
    }
}
