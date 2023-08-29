using HR_Management_Application.DTOs.LeaveRequest;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_Management_Application.Features.LeaveRequests.Request.Commands
{
    public class UpdateLeaveRequestCommand : IRequest<Unit>
    {
        public int Id { get; set; }
        public UpdateLeaveRequestDto UpdateLeaveRequestDto { get; set; }
        public ChangeLeaveRequestApprovedDto updateLeaveRequestApprovedDto { get; set; }
    }
}
