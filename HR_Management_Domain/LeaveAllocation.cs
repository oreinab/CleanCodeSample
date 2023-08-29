using HR_Management_Domain.Common;

namespace HR_Management_Domain
{
    public class LeaveAllocation : BaseDomainEntity
    {
        public int NumberOdDays { get; set; }
        public LeaveType LeaveType { get; set; }
        public int LeaveTypeId { get; set; }
        public int Period { get; set; }
    }
}
