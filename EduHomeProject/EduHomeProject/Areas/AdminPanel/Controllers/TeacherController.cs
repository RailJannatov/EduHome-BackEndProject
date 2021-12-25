using EduHomeProject.Areas.AdminPanel.Data;
using EduHomeProject.DataAccessLayer;
using EduHomeProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
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
        public async Task<IActionResult> Update(int? id)
        {
            var teacherProffesions = await _dbContext.Professions.Where(x => x.isDeleted == false).ToListAsync();
            ViewBag.Professions = teacherProffesions;
            if (id == null)
            {
                return NotFound();
            }
            var teacher = await _dbContext.Teachers.Include(x => x.TeacherDetail)
              .ThenInclude(x => x.Skill).Include(x => x.TeacherDetail)
              .ThenInclude(x => x.ContactInformation).Include(x => x.TeacherProfessions)
              .ThenInclude(x => x.Profession).FirstOrDefaultAsync(x => x.Id == id && x.isDeleted == false);

            if(teacher == null)
            {
                return NotFound();
            }
            return View(teacher);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id,Teacher teacher,int?[] professionId)
        {
            if(id == null)
            {
                return NotFound();
            }
            if(id != teacher.Id)
            {
                return NotFound();
            }
            var existTeacherInDatabase = await _dbContext.Teachers.Include(x => x.TeacherDetail)
            .ThenInclude(x => x.Skill).Include(x => x.TeacherDetail)
            .ThenInclude(x => x.ContactInformation).Include(x => x.TeacherProfessions)
            .ThenInclude(x => x.Profession).FirstOrDefaultAsync(x => x.Id == id && x.isDeleted == false);

            if (existTeacherInDatabase == null)
            {
                return NotFound();
            }


            if (!ModelState.IsValid)
            {
                return View(existTeacherInDatabase);
            }

            if (teacher.Photo != null)
            {
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

                var path = Path.Combine(Constants.ImageFolderPath,  existTeacherInDatabase.TeacherImageName);

                if (System.IO.File.Exists(path))
                {
                    System.IO.File.Delete(path);
                }

                var filename = await FileUtil.GenerateFile(Constants.ImageFolderPath,teacher.Photo);
                existTeacherInDatabase.TeacherImageName = filename;
            }

            if (professionId.Length == 0 || professionId == null)
            {

                teacher.TeacherProfessions = existTeacherInDatabase.TeacherProfessions;
            }
            else
            {

                var teacherProfessions = new List<TeacherProfession>();
                foreach (var item in professionId)
                {
                    var teacherProfession = new TeacherProfession();
                    teacherProfession.ProfessionId = (int)item;
                    teacherProfession.TeacherId = teacher.Id;
                    teacherProfessions.Add(teacherProfession);
                }
                existTeacherInDatabase.TeacherProfessions = teacherProfessions;
            }
           
            existTeacherInDatabase.Name = teacher.Name;
            existTeacherInDatabase.TeacherDetail = teacher.TeacherDetail;
            existTeacherInDatabase.TeacherDetail.Skill = teacher.TeacherDetail.Skill;
            existTeacherInDatabase.TeacherDetail.ContactInformation = teacher.TeacherDetail.ContactInformation; 

            await _dbContext.SaveChangesAsync();

            return RedirectToAction("Index");

        }     
        public async Task<IActionResult> Detail(int? id)
        {
            if(id == null)
            {
                return NotFound();
            }

            var existTeacher = await _dbContext.Teachers
                .Include(x => x.TeacherDetail)
                .ThenInclude(x => x.Skill)
                .Include(x => x.TeacherDetail)
                .ThenInclude(x => x.ContactInformation)
                .Include(x => x.TeacherProfessions)
                .ThenInclude(x => x.Profession)
                .FirstOrDefaultAsync(x => x.Id == id && x.isDeleted == false);
            if (existTeacher == null)
            {
                return NotFound();
            }

            return View(existTeacher);
        }
        public async Task<IActionResult> Delete(int? id)
        {
            if(id == null)
            {
                return NotFound();
            }
            var existTeacherInDatabase = await _dbContext.Teachers
            .FirstOrDefaultAsync(x => x.Id == id && x.isDeleted == false);
            if(existTeacherInDatabase == null)
            {
                return NotFound();
            }
            return View(existTeacherInDatabase);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]

        public async Task<IActionResult> DeleteTeacher(int? id)
        {
            if(id == null)
            {
                return NotFound();
            }
            var existTeacherInDatabase = await _dbContext.Teachers
                .FirstOrDefaultAsync(x => x.Id == id && x.isDeleted == false);
            if (existTeacherInDatabase == null)
            {
                return NotFound();
            }
            var path = Path.Combine(Constants.ImageFolderPath, existTeacherInDatabase.TeacherImageName);

            if (System.IO.File.Exists(path))
            {
                System.IO.File.Delete(path);
            }
             _dbContext.Teachers.Remove(existTeacherInDatabase);
            await _dbContext.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
           
        }
    }
}
