﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Developer_Skills_Assessment.DAL.Entities
{
    public class StudentCourse
    {
        public int StudentId { get; set; }
        public Students Student { get; set; }

        public int CourseId { get; set; }
        public Course Course { get; set; }

    }
}
