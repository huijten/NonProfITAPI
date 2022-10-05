using System.Reflection;

namespace NonProfITAPI.Model
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string CompanyTitle { get; set; }
        public int CompanyId { get; set; }
        public Company Company { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
    }
}
