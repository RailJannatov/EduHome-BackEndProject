using EduHomeProject.DataAccessLayer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeProject.ViewComponents
{
        public class BannerViewComponent : ViewComponent
        {
            private readonly AppDbContext _dbContext;

            public BannerViewComponent(AppDbContext dbContext)
            {
                _dbContext = dbContext;
            }

        public async Task<IViewComponentResult> InvokeAsync(string key)
        {
            var banner = await _dbContext.Banners.FirstOrDefaultAsync(x => x.Key == key);

            return View(banner);
        }
    }
}
