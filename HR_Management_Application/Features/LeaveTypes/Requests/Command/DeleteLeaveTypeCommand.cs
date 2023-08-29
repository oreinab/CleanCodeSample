using HR_Management_Application.DTOs.LeaveType;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_Management_Application.Features.LeaveTypes.Requests.Command
{
    public class DeleteLeaveTypeCommand : IRequest<Unit>
    {
        public int Id { get; set; }
    }
}
