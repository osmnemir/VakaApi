using Xunit;
using Moq;
using VakaApplication.Concrete;
using VakaApplication.Models;
namespace VakaApplication.Tests
{
    

    public class EmployeeTests
    {
        [Fact]
        public void CalculateFixedSalary_ShouldReturnCorrectValue()
        {
            var employee = new Employee
            {
                TC = "12345678901",
                FirstName = "osman",
                LastName = "emir",
                Salary = 5000
            };

            var calculationService = new SalaryService();

            var result = calculationService.CalculateSalary(employee);

            Assert.Equal(5000, result);
        }

       
    }

}
