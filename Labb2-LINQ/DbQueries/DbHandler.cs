using Labb2_LINQ.Models;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace Labb2_LINQ.DbQueries
{
    public static class DbHandler
    {
        public static string GetTeacherByCourseName(string search)
        {
            using SchoolContext context = new();

            Console.Clear();
            return context.Courses
                .Where(c => c.CourseName.Contains(search))
                .Select(c => c.Teacher.TeacherName)
                .FirstOrDefault();
        }
        public static List<object> GetEveryStudentAndTeacher()
        {
            using SchoolContext context = new();

            List<object> allStudentsTeachers = new();

            foreach (var item in context.Teachers.Include(t => t.Students).Include("Courses.Classes"))
            {
                var classTeachers = new
                {
                    teacherName = item.TeacherName,
                    studentNames = item.Students.Select(s => s.StudentName).ToList(),
                    teacherNames = item.Courses.Select(c => c.Teacher.TeacherName).ToList()
                };

                allStudentsTeachers.Add(classTeachers);
            }
            return allStudentsTeachers;
        }

        public static object GetStudentsByCourseName(string search)
        {
            using SchoolContext context = new SchoolContext();
            List<string> studentNames = new();
            List<string> teacherNames = new();

            var course = context.Courses
                .Where(c => c.CourseName.Contains(search))
                .FirstOrDefault();
            var students = context.Classes
                .Include(c => c.Students)
                .Where(c => c.Courses
                .Contains(course))
                .Select(c => c.Students);
            var teachers = context.Teachers
               .Where(t => t.Courses
               .Contains(course));

            foreach (var item in students)
                foreach (var student in item)
                    studentNames.Add(student.StudentName);
            foreach (Teacher teacher in teachers)
                teacherNames.Add(teacher.TeacherName);

            return new
            {
                courseName = course.CourseName,
                studentNames = studentNames,
                teacherNames = teacherNames
            };
        }

        public static bool ChangeCourseName(string search)
        {
            using SchoolContext context = new();

            var course = context.Courses
                .Where(c => c.CourseName
                .Contains(search))
                .FirstOrDefault();
            Console.WriteLine($"Current name: {course!.CourseName}");
            Console.WriteLine("Enter new name:");
            var newcourseName = Console.ReadLine();
            Debug.Assert(newcourseName != null, nameof(newcourseName) + " != null");
            course.CourseName = newcourseName;
            context.SaveChanges();
            return true;
        }
        public static bool ChangeTeacherForCourse(string search)
        {
            using SchoolContext context = new();

            Console.Clear();
            var course = context.Courses
                .Include(c => c.Teacher)
                .Where(c => c.CourseName
                .Contains(search))
                .FirstOrDefault();

            var teachers = context.Teachers
                .Where(t => t.TeacherId != course.Teacher.TeacherId)
                .ToList();

            Console.WriteLine(course.CourseName);
            Console.WriteLine($"Current teacher: {course.Teacher.TeacherName}");
            Console.WriteLine("Choose new teacher by id:");

            foreach (var teacher in teachers)
                Console.WriteLine($"{teacher.TeacherId}. {teacher.TeacherName}");

            int inputId = Int32.Parse(Console.ReadLine());

            course.Teacher = context.Teachers
                                    .Where(t => t.TeacherId.Equals(inputId))
                                    .FirstOrDefault();
            context.SaveChanges();

            return true;
        }

    }

}
