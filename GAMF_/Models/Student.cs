using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace GAMF_.Models
{
    public class Student
    {
        public int Id { get; set; }

        [Display(Name = "Családnév")]
        [Required(ErrorMessage = "A családnév kitöltése kötelező")]
        public string LastName { get; set; }

        [Display(Name = "Keresztnév")]
        [Required(ErrorMessage = "A keresztnév kitöltése kötelező")]
        public string  FirstMidName { get; set; }

        [Display(Name = "Első jelentkezés")]
        [Required(ErrorMessage = "Az első jelentkezés kitöltése kötelező")]
        public DateTime EnrollmentDate { get; set; }

        [Display(Name = "Jelentkezések")]
        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}
