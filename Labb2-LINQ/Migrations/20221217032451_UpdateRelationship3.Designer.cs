﻿// <auto-generated />
using System;
using Labb2_LINQ;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Labb2LINQ.Migrations
{
    [DbContext(typeof(SchoolContext))]
    [Migration("20221217032451_UpdateRelationship3")]
    partial class UpdateRelationship3
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ClassCourse", b =>
                {
                    b.Property<int>("ClassesClassId")
                        .HasColumnType("int");

                    b.Property<int>("CoursesCourseId")
                        .HasColumnType("int");

                    b.HasKey("ClassesClassId", "CoursesCourseId");

                    b.HasIndex("CoursesCourseId");

                    b.ToTable("ClassCourse");
                });

            modelBuilder.Entity("ClassTeacher", b =>
                {
                    b.Property<int>("ClassesClassId")
                        .HasColumnType("int");

                    b.Property<int>("TeachersTeacherId")
                        .HasColumnType("int");

                    b.HasKey("ClassesClassId", "TeachersTeacherId");

                    b.HasIndex("TeachersTeacherId");

                    b.ToTable("ClassTeacher");
                });

            modelBuilder.Entity("Labb2_LINQ.Models.Class", b =>
                {
                    b.Property<int>("ClassId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ClassId"));

                    b.Property<string>("ClassName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ClassId");

                    b.ToTable("Classes");

                    b.HasData(
                        new
                        {
                            ClassId = 1,
                            ClassName = "Net21"
                        },
                        new
                        {
                            ClassId = 2,
                            ClassName = "Java21"
                        });
                });

            modelBuilder.Entity("Labb2_LINQ.Models.Course", b =>
                {
                    b.Property<int>("CourseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CourseId"));

                    b.Property<string>("CourseName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TeacherId")
                        .HasColumnType("int");

                    b.HasKey("CourseId");

                    b.HasIndex("TeacherId");

                    b.ToTable("Courses");

                    b.HasData(
                        new
                        {
                            CourseId = 1,
                            CourseName = "ReactJs",
                            TeacherId = 2
                        },
                        new
                        {
                            CourseId = 2,
                            CourseName = "Agile",
                            TeacherId = 3
                        },
                        new
                        {
                            CourseId = 3,
                            CourseName = "JavaScript",
                            TeacherId = 1
                        });
                });

            modelBuilder.Entity("Labb2_LINQ.Models.Student", b =>
                {
                    b.Property<int>("StudentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StudentId"));

                    b.Property<int?>("ClassId")
                        .HasColumnType("int");

                    b.Property<int?>("CourseId")
                        .HasColumnType("int");

                    b.Property<string>("StudentName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StudentId");

                    b.HasIndex("ClassId");

                    b.HasIndex("CourseId");

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            StudentId = 1,
                            ClassId = 1,
                            CourseId = 1,
                            StudentName = "John Johns"
                        },
                        new
                        {
                            StudentId = 2,
                            ClassId = 1,
                            CourseId = 2,
                            StudentName = "Peter Pan"
                        },
                        new
                        {
                            StudentId = 3,
                            ClassId = 2,
                            CourseId = 3,
                            StudentName = "Paul Simms"
                        },
                        new
                        {
                            StudentId = 4,
                            ClassId = 2,
                            CourseId = 2,
                            StudentName = "Tina Turner"
                        });
                });

            modelBuilder.Entity("Labb2_LINQ.Models.Teacher", b =>
                {
                    b.Property<int>("TeacherId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TeacherId"));

                    b.Property<string>("TeacherName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TeacherId");

                    b.ToTable("Teachers");

                    b.HasData(
                        new
                        {
                            TeacherId = 1,
                            TeacherName = "Reidar Nilsson"
                        },
                        new
                        {
                            TeacherId = 2,
                            TeacherName = "Tobias Landen"
                        },
                        new
                        {
                            TeacherId = 3,
                            TeacherName = "Anas Alhussain"
                        });
                });

            modelBuilder.Entity("StudentTeacher", b =>
                {
                    b.Property<int>("StudentsStudentId")
                        .HasColumnType("int");

                    b.Property<int>("TeachersTeacherId")
                        .HasColumnType("int");

                    b.HasKey("StudentsStudentId", "TeachersTeacherId");

                    b.HasIndex("TeachersTeacherId");

                    b.ToTable("StudentTeacher");
                });

            modelBuilder.Entity("ClassCourse", b =>
                {
                    b.HasOne("Labb2_LINQ.Models.Class", null)
                        .WithMany()
                        .HasForeignKey("ClassesClassId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Labb2_LINQ.Models.Course", null)
                        .WithMany()
                        .HasForeignKey("CoursesCourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ClassTeacher", b =>
                {
                    b.HasOne("Labb2_LINQ.Models.Class", null)
                        .WithMany()
                        .HasForeignKey("ClassesClassId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Labb2_LINQ.Models.Teacher", null)
                        .WithMany()
                        .HasForeignKey("TeachersTeacherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Labb2_LINQ.Models.Course", b =>
                {
                    b.HasOne("Labb2_LINQ.Models.Teacher", "Teacher")
                        .WithMany("Courses")
                        .HasForeignKey("TeacherId");

                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("Labb2_LINQ.Models.Student", b =>
                {
                    b.HasOne("Labb2_LINQ.Models.Class", null)
                        .WithMany("Students")
                        .HasForeignKey("ClassId");

                    b.HasOne("Labb2_LINQ.Models.Course", "Course")
                        .WithMany("Students")
                        .HasForeignKey("CourseId");

                    b.Navigation("Course");
                });

            modelBuilder.Entity("StudentTeacher", b =>
                {
                    b.HasOne("Labb2_LINQ.Models.Student", null)
                        .WithMany()
                        .HasForeignKey("StudentsStudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Labb2_LINQ.Models.Teacher", null)
                        .WithMany()
                        .HasForeignKey("TeachersTeacherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Labb2_LINQ.Models.Class", b =>
                {
                    b.Navigation("Students");
                });

            modelBuilder.Entity("Labb2_LINQ.Models.Course", b =>
                {
                    b.Navigation("Students");
                });

            modelBuilder.Entity("Labb2_LINQ.Models.Teacher", b =>
                {
                    b.Navigation("Courses");
                });
#pragma warning restore 612, 618
        }
    }
}
