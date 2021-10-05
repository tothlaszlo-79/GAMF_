using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GAMF_.Models
{
    public enum Grade { A, B, C, D, F }

    public class Enrollment
    {
        public int EnrollmentId { get; set; }
        public int CourseId { get; set; }
        public int StudentId { get; set; }

        [Display(Name = "Eredmény")]
        public Grade? Grade { get; set; }
        [Display(Name = "Kurzusok")]
        public virtual Course Course { get; set; }
        public virtual Student Student { get; set; }


    }
}
