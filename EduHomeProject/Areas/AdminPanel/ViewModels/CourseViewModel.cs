using EduHomeProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeProject.Areas.AdminPanel.ViewModels
{
    public class CourseViewModel
    {
        public Course Course { get; set; }
        public ICollection<Course> Courses { get; set; }
        public CourseCategory CourseCategory { get; set; }
        public ICollection<CourseCategory> CourseCategories { get; set; }

    }
}
