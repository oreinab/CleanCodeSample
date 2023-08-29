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
    public class GetLeaveAllocationListRequestHandler : IRequestHandler<GetLeaveAllocationListRequest, List<LeaveAllocationDto>>
    {
        private readonly ILeaveAllocationRepository _leaveAllocationRepository;
        private readonly Mapper _mapper;

        public GetLeaveAllocationListRequestHandler(ILeaveAllocationRepository leaveAllocationRepository
            ,Mapper mapper)
        {
            _leaveAllocationRepository = leaveAllocationRepository;
            _mapper = mapper;
        }
        public async Task<List<LeaveAllocationDto>> Handle(GetLeaveAllocationListRequest request, CancellationToken cancellationToken)
        {
            var LeaveAllocation = await _leaveAllocationRepository.GetLeaveAllocationList();
            return _mapper.Map<List<LeaveAllocationDto>>(LeaveAllocation);
        }
    }
}
