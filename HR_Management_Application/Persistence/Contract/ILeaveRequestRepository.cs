using HR_Management_Application.Persistance.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HR_Management_Domain;
using HR_Management_Application.DTOs.LeaveRequest;

namespace HR_Management_Application.Persistence.Contract
{
     public interface ILeaveRequestRepository : IGenericRepository<LeaveRequest>
    {
        Task<LeaveRequest> GetLeaveRequestBy(int id);
        Task<List<LeaveRequest>> GetAllLeaveRequestList();
        Task Add(LeaveRequestDto leaveRequestDto);
        Task ChangeApprovedStatus(LeaveRequest leaveRequest, bool? ApprovalStatus);
    }
}
