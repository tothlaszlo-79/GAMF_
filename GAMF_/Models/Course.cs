using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace GAMF_.Models
{
    public class Course
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CourseId { get; set; }
        [Display(Name = "Kurzus név")]
        public string Title { get; set; }

        [Display(Name = "Kredit")]
        public int Credits { get; set; }

        [Display(Name ="Vizsgák")]
        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }

    
}
