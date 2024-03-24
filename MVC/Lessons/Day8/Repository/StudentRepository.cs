using Day8.Models;
using Day8.IRepository;

namespace Day8.Repository
{

    public class StudentRepository : IStudentRepository
    {
        ITIEntities context = new ITIEntities();

        public Guid id { get; set; }

        public StudentRepository()
        {
            id = Guid.NewGuid();
        }

        public List<Student> GetAll() =>
            context.Students.ToList();


        public Student GetById(int id) =>
            context.Students.FirstOrDefault(d => d.Id == id);


        public void Insert(Student student)
        {
            context.Students.Add(student);
            context.SaveChanges();
        }

        public void Edit(int id, Student student)
        {
            var oldEmp = GetById(id);
            oldEmp.Name = student.Name;
            oldEmp.Address = student.Address;
            oldEmp.Age = student.Age;
            oldEmp.Image = student.Image;
            oldEmp.DeptId = student.DeptId;


            context.SaveChanges();
        }

        public void Delete(int id)
        {
            context.Students.Remove(GetById(id));
        }
    }
}
