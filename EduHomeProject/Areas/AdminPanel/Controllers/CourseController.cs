using EduHomeProject.Areas.AdminPanel.Data;
using EduHomeProject.Areas.AdminPanel.ViewModels;
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
    public class CourseController : Controller
    {

        private readonly AppDbContext _dbContext;
        public CourseController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<IActionResult> Index()
        {
            var CoursesInDb = await _dbContext.Courses.Where(x => x.isDeleted == false).ToListAsync();

            return View(CoursesInDb);
        }
        public async Task<IActionResult> Create()
        {
            var existCategory = await _dbContext.Categories.Where(x => x.isDeleted == false).ToListAsync();
            ViewBag.categories = existCategory;
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Course course, int?[] categoryId)
        {
            var existCategory = await _dbContext.Categories.Where(x => x.isDeleted == false).ToListAsync();
            ViewBag.categories = existCategory;
            if (!ModelState.IsValid)
            {
                return View(course);
            }
            var existCourseInDatabase = await _dbContext.Courses.Where(x => x.isDeleted == false).AnyAsync(x => x.Title.ToLower() == course.Title.ToLower());
            if (existCourseInDatabase)
            {
                return Content("we have that course");
            }
            if (course.CourseDetail.StudentsCount < 0)
            {
                ModelState.AddModelError("", "Students must be higher than 0");
                return View();
            }
            if (course.Photo == null)
            {
                ModelState.AddModelError("", "Photo must be upload");
                return View();
            }

            if (!course.Photo.IsImage())
            {
                ModelState.AddModelError("Photo", "it is not image,Please Upload a photo");
                return View();
            }
            if (!course.Photo.IsSizeAllowed(4))
            {
                ModelState.AddModelError("Photo", "Size isn't right,Please choose under 4mb photo");
                return View();
            }

            if (categoryId.Length == 0 || categoryId == null)
            {
                ModelState.AddModelError("", "Please,Choose category");
                return View();
            }
            var fileName = await FileUtil.GenerateFile(Constants.ImageFolderPath, course.Photo);
            course.CourseImageName = fileName;

            var courses = new List<CourseCategory>();
            foreach (var item in categoryId)
            {
                var courseCategory = new CourseCategory
                {
                    CategoryId = (int)item,
                    CourseId = course.Id
                };
                courses.Add(courseCategory);
            }
            course.CourseCategories = courses;

            course.isDeleted = false;
            await _dbContext.AddAsync(course);
            await _dbContext.SaveChangesAsync();

            return RedirectToAction(nameof(Index));

        }
        public async Task<IActionResult> Detail(int? id)
        {
            if(id == null)
            {
                return NotFound();
            }
            var existCourseInDatabase = await _dbContext.Courses.Include(x => x.CourseDetail).Include(x => x.CourseCategories).ThenInclude(x=>x.Category)
             .FirstOrDefaultAsync(x => x.Id == id && x.isDeleted == false);
            if (existCourseInDatabase == null)
            {
                return NotFound();
            }
            return View(existCourseInDatabase);
        }
        public async Task<IActionResult> Update(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var existCategory = await _dbContext.Categories.Where(x => x.isDeleted == false).ToListAsync();
            ViewBag.categories = existCategory;
            var existCourseinDatabase = await _dbContext.Courses.Include(x => x.CourseDetail).Include(x => x.CourseCategories).FirstOrDefaultAsync(x => x.Id == id && x.isDeleted == false);
            if (existCourseinDatabase == null)
            {
                return NotFound();
            }
            return View(existCourseinDatabase);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id, Course course, int?[] categoryId)
        {
            var existCategory = await _dbContext.Categories.Where(x => x.isDeleted == false).ToListAsync();
            ViewBag.categories = existCategory;
            if (id == null)
            {
                return NotFound();
            }
            if (course.Id != id)
            {
                return NotFound();
            }
         
            var isCourseExistInDatabase = await _dbContext.Courses.AnyAsync(x => x.Title.ToLower() == course.Title.ToLower() && x.Id != course.Id);
            if (isCourseExistInDatabase)
            {
                ModelState.AddModelError("", "Change title ");
                return View();
            }
            var existCourseinDatabase = await _dbContext.Courses.Include(x => x.CourseDetail).Include(x => x.CourseCategories).FirstOrDefaultAsync(x => x.Id == id && x.isDeleted == false);
            if(existCourseinDatabase == null)
            {
                return NotFound();
            }

            if (!ModelState.IsValid)
            {
                return View(existCourseinDatabase);
            }
            if (course.Photo != null)
            {
                if (!course.Photo.IsImage())
                {
                    ModelState.AddModelError("Photo", "Please,choose image");
                    return View();
                }

                if (!course.Photo.IsSizeAllowed(4))
                {
                    ModelState.AddModelError("Photo", "Uploaded photo is more than 4mb");
                    return View();
                }

                var path = Path.Combine(Constants.ImageFolderPath, existCourseinDatabase.CourseImageName);

                if (System.IO.File.Exists(path))
                {
                    System.IO.File.Delete(path);
                }

                var filename = await FileUtil.GenerateFile(Constants.ImageFolderPath, course.Photo);
                existCourseinDatabase.CourseImageName = filename;

            }
            else
            {
                course.CourseImageName = existCourseinDatabase.CourseImageName;
            }

            if (categoryId.Length == 0 ||  categoryId == null)
            {

                course.CourseCategories = existCourseinDatabase.CourseCategories;
            }
            else
            {

                var courseCategories = new List<CourseCategory>();
                foreach (var item in categoryId)
                {
                    var courseCategory = new CourseCategory();
                    courseCategory.CategoryId = (int)item;
                    courseCategory.CourseId = course.Id;
                    courseCategories.Add(courseCategory);
                }
                existCourseinDatabase.CourseCategories = courseCategories;
            }
            existCourseinDatabase.CourseDetail= course.CourseDetail;
            existCourseinDatabase.CourseDescription = course.CourseDescription;
            existCourseinDatabase.Title = course.Title;
            await _dbContext.SaveChangesAsync();
            
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Delete(int? id)
        {
            if(id == null)
            {
                return NotFound();
            }

            var isExistCourseinDatabase = await _dbContext.Courses.Include(x => x.CourseDetail).Include(x => x.CourseCategories).FirstOrDefaultAsync(x => x.Id == id && x.isDeleted == false);
            if(isExistCourseinDatabase == null)
            {
                return NotFound();
            }
            return View(isExistCourseinDatabase);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeleteCourse(int? id)
        {
            if(id == null)
            {
                return NotFound();
            }
            var existCourseinDatabase = await _dbContext.Courses.Include(x=>x.CourseDetail)
             .FirstOrDefaultAsync(x => x.Id == id && x.isDeleted == false);
            if (existCourseinDatabase == null)
            {
                return NotFound();
            }
            var path = Path.Combine(Constants.ImageFolderPath, existCourseinDatabase.CourseImageName);

            if (System.IO.File.Exists(path))
            {
                System.IO.File.Delete(path);
            }
            _dbContext.Courses.Remove(existCourseinDatabase);
            await _dbContext.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
