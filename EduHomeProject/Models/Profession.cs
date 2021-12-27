using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeProject.Models
{
    public class Profession
    {
        public int Id { get; set; }
        [Required]
        public string ProfessionName { get; set; }
        public bool isDeleted { get; set; }
        public ICollection<TeacherProfession> TeacherProfession { get; set; }

    }
}
