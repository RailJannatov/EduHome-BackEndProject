using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeProject.Models
{
    public class Speaker
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SpeakerProfession { get; set; }
        public string SpeakerPosition { get; set; }
        public string SpeakerImageName { get; set; }
        public bool IsDeleted { get; set; }
        [NotMapped]
        public IFormFile  Photo { get; set; }
    }
}
