using System;
using System.Collections.Generic;

namespace Contoso01.Models
{

    public enum Grade
    {
        A,B,C,D,F
    }
    public class Enrollment
    {
        public int EnrollmentID { get; set; }
        public int CourseID { get; set; }
        public int StudentID { get; set; }
        public Grade? Grade { get; set; } // ? means nullable!

        public virtual Course Course { get; set; } //virtual means forfeign key
        public virtual Student Student { get; set; }
    }
}