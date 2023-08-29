using HR_Management_Application.DTOs.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_Management_Application.DTOs.LeaveAllocation
{
    public class UpdateLeaveAllocationDto : BaseDto
    {
        public int LeaveTypeId { get; set; }
        public int Period { get; set; }
        public int NumberOdDays { get; set; }
    }
}
