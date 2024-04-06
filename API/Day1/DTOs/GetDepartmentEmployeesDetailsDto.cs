namespace Demo.DTOs
{
    public class GetDepartmentEmployeesDetailsDto
    {
        public int DeptId { get; set; }
        public string DeptName { get; set; }
        public string DeptManager { get; set; }

        public List<string> EmployeesName { get; set; } = new List<string>();
    }
}
