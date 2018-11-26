﻿using System;
using System.Collections.Generic;

namespace BrownleeUniversity.Models
{
    public class Student
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public DateTime EnrollmentDate { get; set; }
        public string EmailAddress { get; set; }

        public List<Enrollment> Enrollments { get; set; }
    }
}
