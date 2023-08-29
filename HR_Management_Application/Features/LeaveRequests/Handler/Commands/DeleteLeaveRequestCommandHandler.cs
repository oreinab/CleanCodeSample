using HR_Management.Application.Persistence.Contract;
using HR_Management_Application.Features.LeaveRequests.Request.Commands;
using HR_Management_Application.Persistance.Contract;
using HR_Management_Application.Persistence.Contract;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_Management_Application.Features.LeaveRequests.Handler.Commands
{
    public class DeleteLeaveRequestCommandHandler : IRequestHandler<DeleteLeaveRequestCommand,Unit>
    {
        private readonly ILeaveRequestRepository _leaveRequestRepository;

        public DeleteLeaveRequestCommandHandler(ILeaveRequestRepository leaveRequestRepository)
        {
           _leaveRequestRepository = leaveRequestRepository;
        }
        public async Task<Unit> Handle(DeleteLeaveRequestCommand request, CancellationToken cancellationToken)
        {
            var leaveRequest = await _leaveRequestRepository.GetLeaveRequestBy(request.Id);
            await _leaveRequestRepository.Delete(leaveRequest);
            return Unit.Value;
        }

     
    }
}
