namespace Assignment1.Models
{
    public class StudentSampleData
    {
        private List<Student> students = new List<Student>();

        public StudentSampleData()
        {
            students.Add(

                new Student {
                    Id = 1,
                    Name = "Ammar Hammad",
                    Address = "Boosh",
                    Image = "Ammar.jpg"
                });

            students.Add(
                new Student {
                    Id = 2,
                    Name = "Abdulaziz Ahmed",
                    Address = "Berkit Ameeen",
                    Image = "Abdulaziz.jpg"
                });
            students.Add(
                new Student {
                    Id = 3,
                    Name = "Ahmed Yasser",
                    Address = "Elmarg",
                    Image = "Ahmed.jpg"
                });
            
        }


        public List<Student> getStudentsData() => students;
        

        public Student getStudentById(int id) => students?.FirstOrDefault(s => s.Id == id);
    }
}
