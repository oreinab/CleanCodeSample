﻿using HR_Management_Application.DTOs.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_Management_Application.DTOs.LeaveRequest
{
    public class UpdateLeaveRequestDto : BaseDto
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int LeaveTypeId { get; set; }
        public string RequestComments { get; set; }
        public bool? Canceled { get; set; }
    }
}
