using HR_Management_Application.DTOs.Common;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_Management_Application.Features.LeaveTypes.Requests
{
    public class GetLeaveTypeListRequest :IRequest<List<LeaveTypeDto>>
    {


    }
}
