using Day9.Models;

namespace Day9.IRepository
{
    public interface IEmployeeRepository
    {
        List<Employee> GetAll();

        Employee GetById(int id);

        void Insert(Employee employee);

        void Edit(int id, Employee employee);

        void Delete(Employee employee);

        List<Department> GetDepartments();
    }
}
