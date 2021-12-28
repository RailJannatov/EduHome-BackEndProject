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
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Update(int? id)
        //{
        //    return View();
        //}

    }
}
