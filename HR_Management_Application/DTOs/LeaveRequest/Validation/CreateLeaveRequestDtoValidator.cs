using FluentValidation;
using HR_Management.Application.Persistence.Contract;
using HR_Management_Application.DTOs.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace HR_Management_Application.DTOs.LeaveRequest
{
    public class CreateLeaveRequestDtoValidator : AbstractValidator<CreateLeaveRequestDto>
    {
        private readonly ILeaveTypeRepository _leaveTypeRepository;

        public CreateLeaveRequestDtoValidator(ILeaveTypeRepository leaveTypeRepository)
        {
            _leaveTypeRepository = leaveTypeRepository;

            RuleFor(x => x.StartDate)
               .LessThan(x => x.EndDate).WithMessage("{PropertyName} must befor {ComparisionValue}");

            RuleFor(x => x.EndDate)
               .GreaterThan(x => x.StartDate).WithMessage("{PropertyName} must after {ComparisionValue}");

            RuleFor(x => x.LeaveTypeId)
                .GreaterThan(0)
                .WithMessage("{PropertyName} is not exist ")
                .MustAsync(async (id, token) => 
                {
                    var isExist = await _leaveTypeRepository.Exist(id);
                    return !isExist;
                }).WithMessage("{PropertyName} does not exist");


            
        }
    }
}
