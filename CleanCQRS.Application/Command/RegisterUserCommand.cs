using CleanCQRS.Core.DTO.UserManagment;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCQRS.Application.Command
{
    public record RegisterUserCommand(UserRegisterDto UserRegister) : IRequest<UserRegisterDto>;

    //    public class AddEmployeeCommandHandler(IEmployeeRepository employeeRepository, IMediator mediator) : IRequestHandler<AddEmployeeCommand, EmployeeEntity>

    public class RegiaterUserCommandHandler(IMediator mediator) : IRequestHandler<RegisterUserCommand, UserRegisterDto>
    {
        public Task<UserRegisterDto> Handle(RegisterUserCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }

}
