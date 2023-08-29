using AutoMapper;
using HR_Management_Application.DTOs.LeaveRequest;
using HR_Management_Application.Features.LeaveRequests.Request.Commands;
using HR_Management_Application.Persistence.Contract;
using HR_Management_Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_Management_Application.Features.LeaveRequests.Handler.Commands
{
    public class CreateLeaveReuqestCommandHandler : IRequestHandler <CreateLeaveCommand, int>
    {

        private readonly ILeaveRequestRepository _leaveRequestRepository;
        private readonly IMapper _mapper;
        public CreateLeaveReuqestCommandHandler(ILeaveRequestRepository leaveRequestRepository
            ,IMapper mapper)
        {
            _leaveRequestRepository = leaveRequestRepository;
            _mapper = mapper;
        }

        public async Task<int> Handle(CreateLeaveCommand request, CancellationToken cancellationToken)
        {
            
           var leaveRequest = _mapper.Map<LeaveRequest>(request.LeaveRequestDto);
             leaveRequest = await _leaveRequestRepository.Add(leaveRequest);
            return leaveRequest.Id;

        }
    }
}
