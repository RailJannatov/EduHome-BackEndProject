using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeProject.Models
{
    public class Event
    {
        public int Id { get; set; }
        public string EventImageName { get; set; }
        public string Title { get; set; }
        public DateTime EventTime { get; set; }
        public string EventCity { get; set; }
        public bool IsDeleted { get; set; }
        [NotMapped]
        public IFormFile Photo { get; set; }
        public EventDetail EventDetail { get; set; }
        public ICollection<EventCategory> EventCategories { get; set; }
    }
}
