using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeProject.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool isDeleted { get; set; }
        public ICollection<CourseCategory> CourseCategories { get; set; }
        public ICollection<BlogCategory> BlogCategories { get; set; }
    }
}
