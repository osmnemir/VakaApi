using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VakaApplication.Data;
using VakaApplication.Services;

namespace VakaApplication.Controllers
{

    // Controllers/SalaryController.cs
    [ApiController]
    [Route("api/[controller]")]
    public class SalaryController : ControllerBase
    {
        private readonly ISalaryService _salaryService;
        private readonly DataContext _dataContext;

        public SalaryController(ISalaryService salaryService, DataContext dataContext)
        {
            _salaryService = salaryService;
            _dataContext = dataContext;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<decimal>> GetSalary(Guid id)
        {
            var employee = await _dataContext.Employees.FirstOrDefaultAsync(e => e.Id == id);

            if (employee == null)
            {
                return NotFound("Employee not found");
            }

            decimal calculatedSalary = _salaryService.CalculateSalary(employee);

            return Ok("Toplam Maaş:"+calculatedSalary);
        }
    }

}
