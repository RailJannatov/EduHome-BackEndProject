using EduHomeProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeProject.ViewModels
{
    public class NoticeViewModel
    {
        public VIdeoTour VIdeoTour { get; set; }
        public List<NoticeArea> NoticeArea { get; set; }
    }
}
