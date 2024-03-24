using Day8.IRepository;
using Day8.Models;

namespace Day8.Repository
{
    public class DepartmentRepository : IDepartmentRepository
    {
        ITIEntities context = new ITIEntities();

        public List <Department> GetAll() =>
            context.Departments.ToList();


        public Department GetById(int id) =>
            context.Departments.FirstOrDefault(d => d.Id == id);


        public void Insert(Department department)
        {
            context.Departments.Add(department);
            context.SaveChanges();
        }

        public void Edit (int id , Department department)
        {
            var oldDept = GetById(id);
            oldDept.Name = department.Name;
            oldDept.ManagerName = department.ManagerName;

            context.SaveChanges();
        }

        public void Delete (int id)
        {
            context.Departments.Remove(GetById(id));
        }

        public List <Student> GetStudents (int deptId)
        {
            var students = context.Students
                .Where(s => s.DeptId == deptId).ToList();

            return students;
        } 

        public List<Employee> GetEmployees (int deptId)
        {
            var employees = context.Employees
                .Where(e => e.DeptId == deptId).ToList();

            return employees;
        }


    }
}
