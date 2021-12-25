using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeProject.Models
{
    public class SocialAdress
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public string SocialLogo { get; set; }
    
        public int TeacherId { get; set; }
        public Teacher Teacher { get; set; }
    }
}
