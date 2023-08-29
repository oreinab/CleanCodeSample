using HR_Management_Application.DTOs.LeaveAllocation;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_Management_Application.Features.LeaveAllocations.Request.Command
{
    public class UpdateLeaveAllocationCommand : IRequest<Unit>
    {
        public LeaveAllocationDto leaveAllocationDto { get; set; }
    }
}
