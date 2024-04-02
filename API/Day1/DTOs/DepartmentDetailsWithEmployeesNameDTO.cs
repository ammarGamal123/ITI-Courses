namespace Demo.DTOs
{
    public class DepartmentDetailsWithEmployeesNameDTO
    {
        public int Id { get; set; }
        
        public string DepartmentName { get; set; }

        public string DepartmentManager { get; set; }


        //                                               Important to Not Add with NULL
        public List<string> EmployeesName { get; set; } = new List<string>();
    }
}
