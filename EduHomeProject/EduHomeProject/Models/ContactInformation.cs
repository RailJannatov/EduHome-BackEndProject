using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeProject.Models
{
    public class ContactInformation
    {
        public int Id { get; set; }
        public string Mail { get; set; }
        public string PhoneNumber { get; set; }
        public string Skype { get; set; }
       
        public bool IsDeleted { get; set; }

        [ForeignKey("TeacherDetail")]
        public int TeacherDetailId { get; set; }

        public TeacherDetail TeacherDetail { get; set; }
    }
}

