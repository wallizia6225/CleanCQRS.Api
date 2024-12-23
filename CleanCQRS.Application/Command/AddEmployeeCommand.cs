using CleanCQRS.Core.Entities;
using CleanCQRS.Core.Interfaces;
using MediatR;

namespace CleanCQRS.Application.Command
{
    public record AddEmployeeCommand(EmployeeEntity EmployeeEntity) : IRequest<EmployeeEntity>;

    public class AddEmployeeCommandHandler(IEmployeeRepository employeeRepository) : IRequestHandler<AddEmployeeCommand, EmployeeEntity>
    {
        public async Task<EmployeeEntity> Handle(AddEmployeeCommand request, CancellationToken cancellationToken)
        {
            return await employeeRepository.AddEmployee(request.EmployeeEntity);
        }
    }

}
