using System;

namespace LeaveManagement.Application.DTOs.LeaveType
{

    public class CreateLeaveTypeDTO
    {
        public string Name { get; set; }
        public int DefaultDays { get; set; }
    }
}