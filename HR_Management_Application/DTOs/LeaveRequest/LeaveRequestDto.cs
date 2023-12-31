﻿using HR_Management_Application.DTOs.Common;
using HR_Management_Application.DTOs.LeaveType;
using HR_Management_Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_Management_Application.DTOs.LeaveRequest
{
    public class LeaveRequestDto : BaseDto
    {
        public LeaveTypeDto LeaveType { get; set; }
        public int LeaveTypeId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string RequestComments { get; set; }
        public DateTime DateRequested { get; set; }
        public DateTime? DateActioned { get; set; }
        public bool? Approved { get; set; }
        public bool? Canceled { get; set; }

    }
}
