using AutoMapper;
using HR_Management_Application.DTOs.LeaveAllocation;
using HR_Management_Application.Features.LeaveAllocation.Request.Queries;
using HR_Management_Application.Persistence.Contract;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_Management_Application.Features.LeaveAllocation.Handler.Queries
{
    public class GetLeaveAllocationDeatilRequestHandler : IRequestHandler<GetLeaveAllocationDeatilRequest, LeaveAllocationDto>
    {
        private readonly ILeaveAllocationRepository _leaveAllocationRepository;
        private readonly Mapper _mapper;

        public GetLeaveAllocationDeatilRequestHandler(ILeaveAllocationRepository leaveAllocationRepository
            ,Mapper mapper)
        {
            _leaveAllocationRepository = leaveAllocationRepository;
            _mapper = mapper;
        }
        public async Task<DTOs.LeaveAllocation.LeaveAllocationDto> Handle(GetLeaveAllocationDeatilRequest request, CancellationToken cancellationToken)
        {
            var leaveAllocationDeatil = await _leaveAllocationRepository.GetLeaveAllocationBy(request.id);
            return _mapper.Map<LeaveAllocationDto >(leaveAllocationDeatil);
        }
    }
}
