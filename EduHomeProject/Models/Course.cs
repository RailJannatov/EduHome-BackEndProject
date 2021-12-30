using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeProject.Models
{ 
    public class Course
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        public string CourseDescription { get; set; }
        public string CourseImageName { get; set; }
        public CourseDetail CourseDetail { get; set; }
        public bool isDeleted  { get; set; }
        public ICollection<CourseCategory> CourseCategories { get; set; }
        [NotMapped]
        public IFormFile  Photo { get; set; }
    }
}
