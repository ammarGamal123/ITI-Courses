using System.ComponentModel.DataAnnotations;

namespace Day6.Models
{
    public class UniqueNameAttribute : ValidationAttribute
    {
        public string Msg { get; set; }
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if (value == null)
            {
                return null;
            }
            string newName = value.ToString();
            ITIEntities context = new ITIEntities();
            Student student = context.Students.FirstOrDefault(s => s.Name == newName);
            
            if (student != null) {
                return new ValidationResult("Name Must Be Unique");
            }

            return ValidationResult.Success;
        }
    }
}
