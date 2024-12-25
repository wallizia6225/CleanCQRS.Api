using CleanCQRS.Application.Command;
using CleanCQRS.Application.Query;
using CleanCQRS.Core.Entities;
using CleanCQRS.Core.Options;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace CleanCQRS.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //#OPTIONSPATTERN 6 (2nd parameter)
    public class EmployeeController(IMediator mediator, IOptions<ConnectionStringsOptions> options) : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> AddEmployee(EmployeeEntity employeeEntity)
        {
            var result = await mediator.Send(new AddEmployeeCommand(employeeEntity));
            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllEmployees()
        {
            //#OPTIONSPATTERN 7 check value
            var checkConString = options.Value.DefaultConnection;
            var result = await mediator.Send(new GetAllEmployeesQuery());
            return Ok(result);
        }
    }
}
