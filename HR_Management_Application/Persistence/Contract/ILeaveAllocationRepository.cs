using HR_Management_Application.Persistance.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HR_Management_Domain;

namespace HR_Management_Application.Persistence.Contract
{
    public interface ILeaveAllocationRepository : IGenericRepository<LeaveAllocation>
    {
        Task<LeaveAllocation> GetLeaveAllocationBy(int id);

        Task<List<LeaveAllocation>> GetLeaveAllocationList();

    }
}
