﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_Management_Application.DTOs.Common
{
    public class LeaveTypeDto : BaseDto
    {
        public string Name { get; set; }
        public int DeafaultDay { get; set; }
    }
}
