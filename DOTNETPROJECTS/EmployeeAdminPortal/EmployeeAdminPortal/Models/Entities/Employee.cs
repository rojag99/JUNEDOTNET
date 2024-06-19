using Sieve.Attributes;

namespace EmployeeAdminPortal.Models.Entities
{
    public class Employee
    {
        public Guid Id { get; set; }
        public required string Name { get; set; }
        public  string? Email { get; set; }
        [Sieve(CanFilter = true, CanSort = true)] public required string PhoneNumber { get; set; }
        [Sieve(CanFilter=true,CanSort=true)]public required string Salary { get; set; }
    }
}
