using FluentValidation;
using FluentValidation.Validators;
using HR_Management_Application.DTOs.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_Management_Application.DTOs.LeaveRequest
{
    public class UpdateLeaveRequestDtoValidator : AbstractValidator<UpdateLeaveRequestDto>
    {
        public UpdateLeaveRequestDtoValidator()
        {
            RuleFor(x => x.StartDate).NotEmpty().WithMessage("{Property} is not empty")
                .NotNull().WithMessage("{Property} is not empty")
                .GreaterThan(DateTime.Now).WithMessage("{Property} is not empty");

                
        }
    }
}
