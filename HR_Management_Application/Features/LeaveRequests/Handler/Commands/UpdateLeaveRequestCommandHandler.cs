using AutoMapper;
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
    public class UpdateLeaveRequestCommandHandler : IRequestHandler<UpdateLeaveRequestCommand, Unit>
    {
        private readonly ILeaveRequestRepository _leaveRequestRepository;
        private readonly IMapper _mapper;
        public UpdateLeaveRequestCommandHandler(ILeaveRequestRepository leaveRequestRepository
            ,IMapper mapper)
        {
            _leaveRequestRepository = leaveRequestRepository;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(UpdateLeaveRequestCommand request, CancellationToken cancellationToken)
        {
            var leaveRequest = await _leaveRequestRepository.GetLeaveRequestBy(request.Id);
            if (request.UpdateLeaveRequestDto != null)
            {
                _mapper.Map(request.UpdateLeaveRequestDto, leaveRequest);
                await _leaveRequestRepository.Update(leaveRequest);
            }

            else if(request.updateLeaveRequestApprovedDto != null )
            {
                await _leaveRequestRepository.ChangeApprovedStatus(leaveRequest, request.updateLeaveRequestApprovedDto.Approved);
            }
            return Unit.Value;
        }
    }
}
