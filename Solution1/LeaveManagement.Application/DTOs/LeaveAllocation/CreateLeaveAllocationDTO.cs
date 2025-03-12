using System;
using LeaveManagement.Application.DTOs.Common;

namespace LeaveManagement.Application.DTOs.LeaveAllocation
{

    public class CreateLeaveAllocationDTO : BaseDTO
    {
        public int LeaveTypeId { get; set; }
        public string Name { get; set; }
        public int DefaultDays { get; set; }
    }
}