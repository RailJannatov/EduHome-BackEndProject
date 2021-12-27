using EduHomeProject.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeProject.DataAccessLayer
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Profession> Professions { get; set; }
        public DbSet<TeacherProfession> TeacherProfessions { get; set; }
        public DbSet<SocialAdress> SocialAdresses { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<TeacherDetail> TeacherDetails { get; set; }
        public DbSet<ContactInformation> ContactInformation { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<CourseDetail> CourseDetails { get; set; }
        public DbSet<CourseCategory> CourseCategories { get; set; }
        public DbSet<Category> Categories { get; set; }

    }
}
