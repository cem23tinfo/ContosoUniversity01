using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema; // use for data annotation!

namespace Contoso01.Models
{
    public class Course
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)] // data annotation!
        public int CourseID { get; set; }
        public string Title { get; set; }
        public int Credits { get; set; }

        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}