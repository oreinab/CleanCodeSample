using HR_Management_Application.Persistance.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HR_Management_Domain;
namespace HR_Management_Application.Persistence.Contract
{
     public interface ILeaveRequestRepository : IGenericRepository<LeaveRequest>
    {

    }
}
