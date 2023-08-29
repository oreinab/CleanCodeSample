using AutoMapper;
using HR_Management.Application.Persistence.Contract;
using HR_Management_Application.DTOs.LeaveType;
using HR_Management_Application.Features.LeaveTypes.Requests.Command;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_Management_Application.Features.LeaveTypes.Handlers.Commands
{
    public class UpdateLeaveTypeCommandHandler : IRequestHandler<UpdateLeaveTypeCommand, Unit>
    {
        private readonly ILeaveTypeRepository _leaveTypeRepository;
        private readonly IMapper _mapper;

        public UpdateLeaveTypeCommandHandler(ILeaveTypeRepository leaveTypeRepository
            ,IMapper mapper)
        {
            _leaveTypeRepository = leaveTypeRepository;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(UpdateLeaveTypeCommand request, CancellationToken cancellationToken)
        {
            var leaveType = await _leaveTypeRepository.GetLeaveTypeBy(request.LeaveTypeDto.Id);
            _mapper.Map(request.LeaveTypeDto,leaveType);
            await _leaveTypeRepository.Update(leaveType);
            return Unit.Value; 
        }
    }
}
