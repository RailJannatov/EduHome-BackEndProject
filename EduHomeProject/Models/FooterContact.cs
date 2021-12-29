using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeProject.Models
{
    public class FooterContact
    {
        public int Id { get; set; }
        public string Address { get; set; }
        public string MainNumber { get; set; }
        public string SubNumber { get; set; }
        public string MainMail { get; set; }
        public string SubMail { get; set; }
    }
}
