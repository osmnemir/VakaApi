using VakaApplication.Models;

namespace VakaApplication.Services
{
    public class FixedSalaryService : ISalaryService
    {
        public decimal CalculateSalary(Employee employee)
        {
            return employee.Salary; 
        }
    }
}
