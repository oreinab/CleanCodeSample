using HR_Management.Application.Persistence.Contract;
using HR_Management_Application.Features.LeaveAllocations.Request.Command;
using HR_Management_Application.Persistence.Contract;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_Management_Application.Features.LeaveAllocations.Handler.Commands
{
    public class DeleteLeaveAllocationCommandHandler : IRequestHandler<DeleteLeaveAllocationCommand, Unit>
    {
        private readonly ILeaveAllocationRepository _leaveAllocationRepository;

        public DeleteLeaveAllocationCommandHandler(ILeaveAllocationRepository leaveAllocationRepository)
        {
            _leaveAllocationRepository = leaveAllocationRepository;
        }
        public async Task<Unit> Handle(DeleteLeaveAllocationCommand request, CancellationToken cancellationToken)
        {
            var leavetype = await _leaveAllocationRepository.GetLeaveAllocationBy(request.Id);
            await _leaveAllocationRepository.Delete(leavetype);
            return Unit.Value;
        }
    }
}
