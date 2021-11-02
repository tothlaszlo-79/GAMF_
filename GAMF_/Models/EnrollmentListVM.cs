using System.ComponentModel.DataAnnotations;

namespace GAMF_.Models
{
    public class EnrollmentListVM
    {
        [Display(Name ="Tantárgy")]
        public string CourseTitle { get; set; }
        [Display(Name = "Hallgató")]
        public string StudentFullName { get; set; }
        [Display(Name = "Érdemjegy")]
        public string Grade { get; set; }

    }
}
