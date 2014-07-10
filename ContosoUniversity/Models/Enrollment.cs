﻿using System.ComponentModel.DataAnnotations;


namespace ContosoUniversity.Models
{

    public enum Grade
    {
        A, B, C, D, F
    }

    public class Enrollment
    {

        public int EnrollmentID { get; set; }
        public int CourseID { get; set; }
        public int StudentID { get; set; }
        [DisplayFormat(NullDisplayText="No Grade")]
        public Grade? Grade { get; set; }
        public virtual Course Course { get; set; }
        public virtual Student Student { get; set; }
    }

}

//foreign key property
//<navigation property name><primary key property name>