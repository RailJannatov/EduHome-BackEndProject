using EduHomeProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeProject.ViewModels
{
    public class FooterViewModel
    {
        public FooterSocialNetwork FooterSocialNetwork { get; set; }
        public FooterContact FooterContact { get; set; }
        public FooterCopyrightDate FooterCopyrightDate { get; set; }
        public Logo Logo { get; set; }
    }
}
