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
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<BlogDetail> BlogDetails { get; set; }
        public DbSet<BlogCategory> BlogCategories { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<EventDetail> EventDetails { get; set; }
        public DbSet<Speaker> Speakers { get; set; }
        public DbSet<EventSpeaker> EventSpeakers { get; set; }
        public DbSet<EventCategory> EventCategories { get; set; }
        public DbSet<SliderImages> SliderImages { get; set; }
        public DbSet<WelcomeToEduhome> WelcomeToEduhome { get; set; }
        public DbSet<NoticeArea> NoticeAreas { get; set; }
        public DbSet<VIdeoTour> VIdeoTours { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<FooterSocialNetwork> FooterSocialNetwork { get; set; }
        public DbSet<FooterContact> FooterContact { get; set; }
        public DbSet<FooterCopyrightDate> FooterCopyrightDates { get; set; }
        public DbSet<Logo> Logos { get; set; }
        public DbSet<Subscribe> Subscribes { get; set; }
        public DbSet<Banner> Banners { get; set; }

    }
}
