using EduHomeProject.DataAccessLayer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeProject.ViewComponents
{
    public class WelcomeToEduhomeViewComponent : ViewComponent
    {
        private readonly AppDbContext _dbContext;

        public WelcomeToEduhomeViewComponent(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var welcomeToEduhome = await _dbContext.WelcomeToEduhome.SingleOrDefaultAsync();

            return View(welcomeToEduhome);
        }
    }
}
