using System.ComponentModel.DataAnnotations.Schema;

namespace Assignment2.Models
{
    public class CourseResult
    {
        public int Id { get; set; }
        public int Degree { get; set; }

        [ForeignKey("Course")]
        public int CourseId { get; set; }
        Course? Course { get; set; }


        [ForeignKey("Trainee")]
        public int TraineeId { get; set; }
        Trainee? Trainee { get; set; }
    }
}
