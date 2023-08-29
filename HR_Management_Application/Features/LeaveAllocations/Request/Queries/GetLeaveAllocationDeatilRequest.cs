using HR_Management_Application.DTOs.LeaveAllocation;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_Management_Application.Features.LeaveAllocation.Request.Queries
{
    public class GetLeaveAllocationDeatilRequest : IRequest<LeaveAllocationDto>
    {
        public int id { get; set; }
    }
}
