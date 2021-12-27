using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeProject.Models
{
    public class Blog
    {
        public int Id { get; set; }
   
        public string BlogTitle { get; set; }
        [Required]
        [StringLength(20)]
        public string Author { get; set; }
        public DateTime CreateTime { get; set; }
        public int Comments { get; set; }
        public bool IsDeleted { get; set; }
        public string BlogImageName  { get; set; }
        [NotMapped]
        public IFormFile Photo { get; set; }
        public BlogDetail BlogDetail { get; set; }
        public ICollection<BlogCategory> BlogCategories { get; set; }
    }
}
