// <auto-generated />
using System;
using EduHomeProject.DataAccessLayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EduHomeProject.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20211226112553_AddCourseDetail")]
    partial class AddCourseDetail
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EduHomeProject.Models.ContactInformation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Mail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Skype")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TeacherDetailId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TeacherDetailId")
                        .IsUnique();

                    b.ToTable("ContactInformation");
                });

            modelBuilder.Entity("EduHomeProject.Models.Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CourseDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CourseImageName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("EduHomeProject.Models.CourseDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AboutCourse")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Certification")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<string>("HowToApply")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.ToTable("CourseDetails");
                });

            modelBuilder.Entity("EduHomeProject.Models.Profession", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ProfessionName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("isDeleted")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Professions");
                });

            modelBuilder.Entity("EduHomeProject.Models.Skill", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CommunicationDegree")
                        .HasColumnType("int");

                    b.Property<int>("DesignDegree")
                        .HasColumnType("int");

                    b.Property<int>("DevelopmentDegree")
                        .HasColumnType("int");

                    b.Property<int>("InnovationDegree")
                        .HasColumnType("int");

                    b.Property<int>("LanguageDegree")
                        .HasColumnType("int");

                    b.Property<int>("TeacherDetailId")
                        .HasColumnType("int");

                    b.Property<int>("TeamLeaderDegree")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TeacherDetailId")
                        .IsUnique();

                    b.ToTable("Skills");
                });

            modelBuilder.Entity("EduHomeProject.Models.SocialAdress", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("SocialLogo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TeacherId")
                        .HasColumnType("int");

                    b.Property<string>("Url")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("TeacherId");

                    b.ToTable("SocialAdresses");
                });

            modelBuilder.Entity("EduHomeProject.Models.Teacher", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int?>("TeacherDetails")
                        .HasColumnType("int");

                    b.Property<string>("TeacherImageName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("isDeleted")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("TeacherDetails")
                        .IsUnique()
                        .HasFilter("[TeacherDetails] IS NOT NULL");

                    b.ToTable("Teachers");
                });

            modelBuilder.Entity("EduHomeProject.Models.TeacherDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AboutMeDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Degree")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Experience")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Faculty")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Hobbies")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int>("TeacherId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("TeacherDetails");
                });

            modelBuilder.Entity("EduHomeProject.Models.TeacherProfession", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ProfessionId")
                        .HasColumnType("int");

                    b.Property<int>("TeacherId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProfessionId");

                    b.HasIndex("TeacherId");

                    b.ToTable("TeacherProfessions");
                });

            modelBuilder.Entity("EduHomeProject.Models.ContactInformation", b =>
                {
                    b.HasOne("EduHomeProject.Models.TeacherDetail", "TeacherDetail")
                        .WithOne("ContactInformation")
                        .HasForeignKey("EduHomeProject.Models.ContactInformation", "TeacherDetailId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TeacherDetail");
                });

            modelBuilder.Entity("EduHomeProject.Models.CourseDetail", b =>
                {
                    b.HasOne("EduHomeProject.Models.Course", "Course")
                        .WithMany()
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");
                });

            modelBuilder.Entity("EduHomeProject.Models.Skill", b =>
                {
                    b.HasOne("EduHomeProject.Models.TeacherDetail", "TeacherDetail")
                        .WithOne("Skill")
                        .HasForeignKey("EduHomeProject.Models.Skill", "TeacherDetailId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TeacherDetail");
                });

            modelBuilder.Entity("EduHomeProject.Models.SocialAdress", b =>
                {
                    b.HasOne("EduHomeProject.Models.Teacher", "Teacher")
                        .WithMany("SocialAdresses")
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("EduHomeProject.Models.Teacher", b =>
                {
                    b.HasOne("EduHomeProject.Models.TeacherDetail", "TeacherDetail")
                        .WithOne("Teacher")
                        .HasForeignKey("EduHomeProject.Models.Teacher", "TeacherDetails");

                    b.Navigation("TeacherDetail");
                });

            modelBuilder.Entity("EduHomeProject.Models.TeacherProfession", b =>
                {
                    b.HasOne("EduHomeProject.Models.Profession", "Profession")
                        .WithMany("TeacherProfession")
                        .HasForeignKey("ProfessionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EduHomeProject.Models.Teacher", "Teacher")
                        .WithMany("TeacherProfessions")
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Profession");

                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("EduHomeProject.Models.Profession", b =>
                {
                    b.Navigation("TeacherProfession");
                });

            modelBuilder.Entity("EduHomeProject.Models.Teacher", b =>
                {
                    b.Navigation("SocialAdresses");

                    b.Navigation("TeacherProfessions");
                });

            modelBuilder.Entity("EduHomeProject.Models.TeacherDetail", b =>
                {
                    b.Navigation("ContactInformation");

                    b.Navigation("Skill");

                    b.Navigation("Teacher");
                });
#pragma warning restore 612, 618
        }
    }
}
