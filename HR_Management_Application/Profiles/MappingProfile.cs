using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using HR_Management_Application.DTOs;
using HR_Management_Application.DTOs.Common;
using HR_Management_Application.DTOs.LeaveRequest;
using HR_Management_Domain;

namespace HR_Management_Application.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile() 
        {
            CreateMap<LeaveRequest,LeaveRequestDto>().ReverseMap();
            CreateMap<LeaveRequest, LeaveRequestDto>().ReverseMap();
            CreateMap<LeaveAllocation, LeaveAllocationDto>().ReverseMap();
            CreateMap<LeaveType,LeaveTypeDto>().ReverseMap();
        }
    }
}
