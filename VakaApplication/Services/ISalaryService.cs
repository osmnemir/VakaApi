using VakaApplication.Models;

namespace VakaApplication.Services
{
    public interface ISalaryService
    {
        decimal CalculateSalary(Employee employee);
    }
}
