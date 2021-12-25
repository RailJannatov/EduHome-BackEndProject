using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeProject.Models
{
    public class Skill
    {
        public int Id { get; set; }
        public int LanguageDegree { get; set; }
        public int TeamLeaderDegree { get; set; }
        public int DevelopmentDegree { get; set; }
        public int DesignDegree { get; set; }
        public int InnovationDegree { get; set; }
        public int CommunicationDegree { get; set; }
        public int TeacherDetailId { get; set; }
        public TeacherDetail TeacherDetail { get; set; }
    }
}
