using VakaApplication.Models;
using VakaApplication.Services;

namespace VakaApplication.Concrete
{
    public class SalaryService : ISalaryService
    {
        public decimal CalculateSalary(Employee employee)
        {
            if (employee.DailyWorkedDays > 0)
            {
                // Tip 2 çalışan hesaplama
                return employee.DailyWorkedDays * employee.DailyPrice;
            }
            else if (employee.OvertimeHours > 0)
            {
                // Tip 3 çalışan hesaplama
                return employee.Salary + (employee.OvertimeHours * employee.OvertimePrice);
            }
            else
            {
                // Tip 1 çalışan (sabit maaşlı)
                return employee.Salary;
            }
        }
    }
}
