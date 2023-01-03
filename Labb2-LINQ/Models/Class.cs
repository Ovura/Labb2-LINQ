using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb2_LINQ.Models
{
    public class Class
    {
        [Key]
        public int ClassId { get; set; } 

        public string? ClassName { get; set; }

        public ICollection<Student>? Students { get; set; }

        public ICollection<Teacher>? Teachers { get; set; }

        public ICollection<Course>? Courses { get; set; }

    }
}
