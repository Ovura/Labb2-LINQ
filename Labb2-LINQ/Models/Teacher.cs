using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb2_LINQ.Models
{
    public class Teacher
    {
        [Key]
        public int TeacherId { get; set; }

        public string? TeacherName { get; set; }

        public ICollection<Course>? Courses { get; set; }

        public ICollection<Class>? Classes { get; set; }   

        public ICollection<Student>? Students { get; set; }

    }
}
