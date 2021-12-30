using EduHomeProject.DataAccessLayer;
using EduHomeProject.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeProject.ViewComponents
{
    public class NoticeViewComponent:ViewComponent
    {
        private readonly AppDbContext _dbContext;

        public NoticeViewComponent(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var videoTour = await _dbContext.VIdeoTours.SingleOrDefaultAsync();
            var noticeAreas = await _dbContext.NoticeAreas.ToListAsync();

            var Notice = new NoticeViewModel()
            {
                VIdeoTour = videoTour,
                NoticeArea = noticeAreas
            };

            return View(Notice);
        }
    }
}
