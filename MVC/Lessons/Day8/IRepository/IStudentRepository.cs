using Day8.Models;

namespace Day8.IRepository
{
    public interface IStudentRepository
    {
        Guid id { get; set; }
        List<Student> GetAll();

        Student GetById(int id);

        void Insert(Student student);

        void Edit(int id, Student student);

        void Delete(int id);
    }
}
