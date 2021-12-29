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
    public class EventController : Controller
    {
        private readonly AppDbContext _dbContext;
        public EventController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<IActionResult>  Index()
        {
            return View();
        }
        public async Task<IActionResult> Create()
        {
            var existCategory = await _dbContext.Categories.Where(x => x.isDeleted == false).ToListAsync();
            ViewBag.categories = existCategory;
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Event @event,int?[] categoryId)
        {
            var existCategory = await _dbContext.Categories.Where(x => x.isDeleted == false).ToListAsync();
            ViewBag.categories = existCategory;
            if (!ModelState.IsValid)
            {
                return NotFound();
            }
            var sameEventInDatabase = await _dbContext.Events.AnyAsync(x => x.Id == @event.Id);
            if(sameEventInDatabase)
            {
                ModelState.AddModelError("", "This event already created");
                return View();
            }
            if(@event.Photo == null)
            {
                ModelState.AddModelError("", "Please choose a image");
                return View();
            }
            else
            {
                if (!@event.Photo.IsImage())
                {
                    ModelState.AddModelError("", "Please choose a image");
                    return View();
                }
                if(!@event.Photo.IsSizeAllowed(4))
                {
                    ModelState.AddModelError("", "Please,choose image under 4 mb");
                    return View();
                }

                var fileName = await FileUtil.GenerateFile(Constants.ImageFolderPath, @event.Photo);
                @event.EventImageName = fileName;
            }
            if(categoryId.Length == 0 || categoryId == null)
            {
                ModelState.AddModelError("", "Please,choose category");
                return View();
            }
            var eventCategories = new List<EventCategory>();
            foreach(var item in categoryId)
            {
                var eventCategory = new EventCategory()
                {
                    CategoryId = (int)item,
                    EventId = @event.Id
                };
                eventCategories.Add(eventCategory);
            }
            @event.EventCategories = eventCategories;
            @event.IsDeleted = false;
            await _dbContext.Events.AddAsync(@event);
            await _dbContext.SaveChangesAsync();
            return RedirectToAction(nameof(Index));

        }
        public async Task<IActionResult> Update(int? id)
        {
            if(id == null)
            {
                return NotFound();
            }
            var categories = await _dbContext.Categories.Where(x => x.isDeleted == false).ToListAsync();
            ViewBag.Categories = categories;
            var @event = await _dbContext.Events.Include(x => x.EventDetail).Include(x => x.EventCategories)
           .FirstOrDefaultAsync(x => x.Id == id && x.IsDeleted == false);
            if (@event == null)
                return NotFound();

            return View(@event);

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id,Event @event,int?[] categoryId)
        {
            var categories = await _dbContext.Categories.Where(x => x.isDeleted == false).ToListAsync();
            ViewBag.Categories = categories;
            if(id == null)
            {
                return NotFound();
            }
            if(@event.Id !=id)
            {
                return NotFound();
            }
            var existEventInDatabase = await _dbContext.Events.Include(x => x.EventDetail).Include(x => x.EventCategories).FirstOrDefaultAsync(x => x.Id == id && x.IsDeleted == false);
            if (existEventInDatabase == null)
            {
                return NotFound();
            }

            if (!ModelState.IsValid)
            {
                return View(existEventInDatabase);
            }

            var isEventExistInDatabase = await _dbContext.Courses.AnyAsync(x => x.Title.ToLower() == @event.Title.ToLower() && x.Id != @event.Id);
            if (isEventExistInDatabase)
            {
                ModelState.AddModelError("", "Change title ");
                return View();
            }

            if (@event.Photo != null)
            {
                if (!@event.Photo.IsImage())
                {
                    ModelState.AddModelError("Photo", "Please,choose image");
                    return View();
                }

                if (!@event.Photo.IsSizeAllowed(4))
                {
                    ModelState.AddModelError("Photo", "Uploaded photo is more than 4mb");
                    return View();
                }

                var path = Path.Combine(Constants.ImageFolderPath, existEventInDatabase.EventImageName);

                if (System.IO.File.Exists(path))
                {
                    System.IO.File.Delete(path);
                }

                var filename = await FileUtil.GenerateFile(Constants.ImageFolderPath, @event.Photo);
                existEventInDatabase.EventImageName = filename;

            }
            else
            {
                @event.EventImageName = existEventInDatabase.EventImageName;
            }

            if (categoryId.Length == 0 || categoryId == null)
            {

                @event.EventCategories = existEventInDatabase.EventCategories;
            }
            else
            {
                var eventCategories = new List<EventCategory>();
                foreach (var item in categoryId)
                {
                    var eventCategory = new EventCategory()
                    {
                        CategoryId = (int)item,
                        EventId = @event.Id
                    };
                    eventCategories.Add(eventCategory);
                }
            }
            existEventInDatabase.EventTime = @event.EventTime;
            existEventInDatabase.EventDetail = @event.EventDetail;
            existEventInDatabase.EventCity = @event.EventCity;
            existEventInDatabase.Title = @event.Title;
            await _dbContext.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var isExistEventinDatabase = await _dbContext.Events.Include(x => x.EventDetail).Include(x => x.EventCategories).FirstOrDefaultAsync(x => x.Id == id && x.IsDeleted == false);
            if (isExistEventinDatabase == null)
            {
                return NotFound();
            }
            return View(isExistEventinDatabase);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeleteEvent(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var existEventInDatabase = await _dbContext.Events.Include(x => x.EventDetail).FirstOrDefaultAsync(x => x.Id == id && x.IsDeleted == false);
            if (existEventInDatabase == null)
            {
                return NotFound();
            }
            var path = Path.Combine(Constants.ImageFolderPath, existEventInDatabase.EventImageName);

            if (System.IO.File.Exists(path))
            {
                System.IO.File.Delete(path);
            }

            _dbContext.Events.Remove(existEventInDatabase);
            await _dbContext.SaveChangesAsync();

            return RedirectToAction("Index");
        }

    }
}
