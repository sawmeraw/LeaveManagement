using System;
using LeaveManagement.Application.DTOs.Common;

namespace LeaveManagement.Application.DTOs.LeaveRequest
{

    public class LeaveRequestListDTO : BaseDTO
    {
        public LeaveTypeDTO LeaveType { get; set; }
        public DateTime DateRequested { get; set; }
        public bool? Approved { get; set; }
    }
}
