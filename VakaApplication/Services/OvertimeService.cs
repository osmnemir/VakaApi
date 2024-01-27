using VakaApplication.Models;

namespace VakaApplication.Services
{
    public class OvertimeService : ISalaryService
    {
        private readonly decimal overtimeHourlyRate;
        private readonly decimal decimalValue;

        public OvertimeService(decimal overtimeHourlyRate, decimal decimalValue)
        {
            this.overtimeHourlyRate = overtimeHourlyRate;
            this.decimalValue = decimalValue;
        }

        public decimal CalculateSalary(Employee employee)
        {
            return employee.Salary + (employee.OvertimeHours * overtimeHourlyRate);
        }
    }
}
