using HR_Management_Application.DTOs.LeaveRequest;
using MediatR;

namespace HR_Management_Application.Features.LeaveRequests.Request.Queries
{
    public class GetLeavRequestListRequest : IRequest<List<LeaveRequestDto>>
    {
    }
}
