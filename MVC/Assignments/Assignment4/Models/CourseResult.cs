using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Assignment4.Models
{
    public class CourseResult
    {
        public int? Id { get; set; }

        [Range(0, 100)]
        public int Degree { get; set; }

        /*[ForeignKey("Course")]*/
        public int? CourseResultCrsId { get; set; }
        public Course? Course { get; set; }

        /*[ForeignKey("Trainee")]*/
        public int? CourseResultTranId { get; set; }
        public Trainee? Trainee { get; set; }
    }
}
