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
    public class FooterViewComponent:ViewComponent
    {
        private readonly AppDbContext _dbContext;
        public FooterViewComponent(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var footerSocialLinks = await _dbContext.FooterSocialNetwork.SingleOrDefaultAsync();
            var footerContact = await _dbContext.FooterContact.SingleOrDefaultAsync();
            var footerCopyrightDate = await _dbContext.FooterCopyrightDates.SingleOrDefaultAsync();
            var logo = await _dbContext.Logos.SingleOrDefaultAsync();
            var footer = new FooterViewModel()
            {
                FooterSocialNetwork = footerSocialLinks,
                FooterContact = footerContact,
                FooterCopyrightDate = footerCopyrightDate,
                Logo = logo
            };
            return View(footer);
        }
    }
}
