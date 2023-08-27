using AutoMapper;
using HR_Management_Application.DTOs.LeaveRequest;
using HR_Management_Application.Features.LeaveRequests.Request.Queries;
using HR_Management_Application.Persistence.Contract;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_Management_Application.Features.LeaveRequests.Handler
{
    public class GetLeavRequestListRequestHandler :
        IRequestHandler<GetLeavRequestListRequest, List<LeaveRequestDto>>
    {
        private readonly ILeaveRequestRepository _leaveRequestRepository;
        private readonly IMapper _mapper;

        public GetLeavRequestListRequestHandler(ILeaveRequestRepository leaveRequestRepository,IMapper mapper)
        {
            _leaveRequestRepository = leaveRequestRepository;
            _mapper = mapper;
        }

        public  async Task<List<LeaveRequestDto>> Handle(GetLeavRequestListRequest request, CancellationToken cancellationToken)
        {
           var leavRequests = await _leaveRequestRepository.GetAll();
            return _mapper.Map<List<LeaveRequestDto>>(leavRequests);
        }
    }
}
