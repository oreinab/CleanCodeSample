using AutoMapper;
using HR_Management_Application.Features.LeaveAllocations.Request.Command;
using HR_Management_Application.Persistence.Contract;
using MediatR;
using HR_Management_Domain;


namespace HR_Management_Application.Features.LeaveAllocations.Handler.Commands
{
    public class CreateLeaveAllocationCommandHandler : IRequestHandler<CreateLeaveAllocationCommand, int>
    {
        private readonly ILeaveAllocationRepository _leaveAllocationRepository;
        private readonly IMapper _mapper;
        public CreateLeaveAllocationCommandHandler(ILeaveAllocationRepository leaveAllocationRepository
            ,IMapper mapper)
        {
            _leaveAllocationRepository = leaveAllocationRepository;
            _mapper = mapper;
        }

    

        public async Task<int> Handle(CreateLeaveAllocationCommand request, CancellationToken cancellationToken)
        {
            var leaveAllocation = _mapper.Map<HR_Management_Domain.LeaveAllocation> (request.LeaveAllocationDto);
            leaveAllocation = await _leaveAllocationRepository.Add(leaveAllocation);
            return leaveAllocation.Id;


        }
    }
}
