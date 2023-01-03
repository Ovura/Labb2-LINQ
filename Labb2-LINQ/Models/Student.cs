﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb2_LINQ.Models
{
    public class Student
    {
        [Key]
        public int  StudentId { get; set; }

        public string? StudentName { get; set; }

        public Course? Course { get; set; }

        public Class? Class { get; set; }

        public ICollection<Teacher>? Teachers { get; set; }


    }
}
