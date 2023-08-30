using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_Management_Application.DTOs.LeaveType.Validation
{
    public class ILeaveTypeDtoValidator : AbstractValidator<ILeaveTypeDto>
    {
        public ILeaveTypeDtoValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("{PropertyName} is empty.")
                .NotNull().WithMessage("{PropertyName} is null.")
                .Length(50).WithMessage("{PropertyName} is more than 50 characters.");

            RuleFor(x => x.DeafaultDay).NotNull().WithMessage("{PropertyName} is Null")
                .GreaterThan(0).WithMessage("{PropertyName} is must be greater than 0")
                .LessThan(100).WithMessage("{PropertyName} is must be less than 100");

        }
                
    }
}
