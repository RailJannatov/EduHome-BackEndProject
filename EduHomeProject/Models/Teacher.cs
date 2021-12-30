using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeProject.Models
{
    public class Teacher
    {
        public int Id { get; set; }
        [Required]
        [StringLength(20)]
        public string Name { get; set; }
        public string TeacherImageName { get; set; }
        public bool isDeleted { get; set; }   
        public ICollection<TeacherProfession> TeacherProfessions { get; set; }
        public ICollection<SocialAdress> SocialAdresses { get; set; }
        [ForeignKey("TeacherDetails")]
        public TeacherDetail TeacherDetail { get; set; }
        [NotMapped]
        public IFormFile Photo { get; set; }

    }
}
