﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeProject.Models
{
    public class BlogDetail
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string LeaveAReply { get; set; }
        public bool IsDeleted { get; set; }
        [ForeignKey("Blog")]
        public int BlogId { get; set; }
        public Blog Blog { get; set; }
    }
}
