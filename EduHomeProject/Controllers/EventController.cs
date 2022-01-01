using EduHomeProject.DataAccessLayer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeProject.Controllers
{
    public class EventController : Controller
    {
        private readonly AppDbContext _dbContext;
        public EventController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<IActionResult> Index()
        {
            var events = await _dbContext.Events.Include(x => x.EventDetail).Include(x => x.EventCategories).ThenInclude(x => x.Category).ToListAsync();
            return View(events);
        }
        public async Task<IActionResult> Search(string search)
        {
            if (string.IsNullOrEmpty(search))
            {
                return NotFound();
            }

            var events = await _dbContext.Events.Where(x =>x.Title.Contains(search.ToLower()))
             .ToListAsync();

            return PartialView("_EventSearchPartial", events);
        }
    }
}
