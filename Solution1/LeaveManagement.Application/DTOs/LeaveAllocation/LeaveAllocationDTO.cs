using System;
using LeaveManagement.Application.DTOs.Common;
using LeaveManagement.Application.DTOs.LeaveType;

namespace LeaveManagement.Application.DTOs.LeaveAllocation
{
    public class LeaveAllocationDTO : BaseDTO
    {
        public LeaveTypeDTO LeaveTypeDTO { get; set; }
        public int LeaveTypeId { get; set; }
        public string Name { get; set; }
        public int DefaultDays { get; set; }
    }
}