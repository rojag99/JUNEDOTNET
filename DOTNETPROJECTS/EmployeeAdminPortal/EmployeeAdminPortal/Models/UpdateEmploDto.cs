namespace EmployeeAdminPortal.Models
{
    public class UpdateEmploDto
    {
        public required string Name { get; set; }
        public string? Email { get; set; }
        public required string PhoneNumber { get; set; }
        public required string Salary { get; set; }
    }
}
