using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeProject.Models
{
    public class TeacherDetail
    {
        public int Id { get; set; }
        public string AboutMeDescription { get; set; }
        public string Degree { get; set; }
        public string Hobbies { get; set; }
        public string Faculty { get; set; }
        public string Experience { get; set; }
        public bool IsDeleted { get; set; }
        [ForeignKey("Teachers")]
        public int TeacherId { get; set; }
        public Teacher Teacher { get; set; }
        public Skill Skill { get; set; }
        public ContactInformation ContactInformation { get; set; }

    

    }
}
