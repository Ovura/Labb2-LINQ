using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb2_LINQ.Models
{
    public class Course
    {
        [Key]
        public int CourseId { get; set; }

        public string? CourseName { get; set; }

        public Teacher? Teacher { get; set; }

        public ICollection<Student>? Students { get; set; }

        public ICollection<Class>? Classes { get; set; }

    }
}
