namespace Day1.DTOs
{

    // Hide the structure of the Model (More Secure)  
    // Also Solve the Serialization Problem CYCLE
    public class EmployeeDataWithDepartmentNameDTO
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public string Phone { get; set; }

        public string DepartmentName { get; set; }


    }
}
