using VakaApplication.Models;

namespace VakaApplication.Services
{
    public class DailyRateService : ISalaryService
    {
        private readonly decimal dailyRate;
        private readonly decimal decimalValue;

        public DailyRateService(decimal dailyRate, decimal decimalValue)
        {
            this.dailyRate = dailyRate;
            this.decimalValue = decimalValue;
        }

        public decimal CalculateSalary(Employee employee)
        {
            return employee.DailyWorkedDays * dailyRate;
        }
    }
}
