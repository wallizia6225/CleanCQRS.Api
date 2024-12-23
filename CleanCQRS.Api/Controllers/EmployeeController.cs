using CleanCQRS.Application.Command;
using CleanCQRS.Core.Entities;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CleanCQRS.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController(IMediator mediator) : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> AddEmployee(EmployeeEntity employeeEntity)
        {
            var result = await mediator.Send(new AddEmployeeCommand(employeeEntity));
            return Ok(result);
        }
    }
}
