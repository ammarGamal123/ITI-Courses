using Day9.Models;

namespace Day9.IRepository
{
    public interface IDepartmentRepository
    {
        // CRUD Operations

        List<Department> GetAll();

        Department GetById(int id);

        void Insert (Department department);

        void Edit (int id , Department department);

        void Delete (int id);

        List<Student> GetStudents(int deptId);

        List<Employee> GetEmployees(int deptId);

    }
}
