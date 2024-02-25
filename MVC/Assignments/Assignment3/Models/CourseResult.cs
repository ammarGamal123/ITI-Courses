using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Assignment3.Models
{
    public class CourseResult
    {
        public int? Id { get; set; }

        [Range(0, 100)]
        public int Degree { get; set; }

        [ForeignKey("Course")]
        public int? CourseId { get; set; }
        public Course? Course { get; set; }

        [ForeignKey("Trainee")]
        public int? TraineeId { get; set; }
        public Trainee? Trainee { get; set; }
    }
}
