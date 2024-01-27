using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VakaApplication.Data;
using VakaApplication.Models;

namespace VakaApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : Controller
    {
        private readonly DataContext _dataContext;

        public EmployeesController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        [HttpGet]
        public async Task<IActionResult> GetEmployees()
        {
            return Ok(await _dataContext.Employees.ToListAsync());
        }
        [HttpGet]
        [Route("{id:guid}")]
        public async Task<IActionResult> GetEmployee([FromRoute]Guid id)
        {
            var empyolee = await _dataContext.Employees.FindAsync(id);
            if (empyolee == null)
            {
                return NotFound();
            }
            return Ok(empyolee);
        }


        [HttpPost]
        public async Task< IActionResult> AddEmpyolee(AddEmpyoleRequest addEmpyoleRequest)
        {
            var empyolee = new Employee()
            {
                Id = Guid.NewGuid(),
                TC = addEmpyoleRequest.TC,
                FirstName = addEmpyoleRequest.FirstName,
                LastName = addEmpyoleRequest.LastName,
                Salary = addEmpyoleRequest.Salary,
                DailyWorkedDays=addEmpyoleRequest.DailyWorkedDays,
                OvertimeHours= addEmpyoleRequest.OvertimeHours,
            };
            await _dataContext.Employees.AddAsync(empyolee);
            await _dataContext.SaveChangesAsync();
            return Ok(empyolee);
        }


    }
}
