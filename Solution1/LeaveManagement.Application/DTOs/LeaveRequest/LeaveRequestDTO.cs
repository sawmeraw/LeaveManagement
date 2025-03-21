using System;
using LeaveManagement.Application.DTOs.Common;
using LeaveManagement.Application.DTOs.LeaveType;
using LeaveManagement.Domain;

namespace LeaveManagement.Application.DTOs.LeaveRequest
{

    public class LeaveRequestDTO : BaseDTO
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public LeaveTypeDTO LeaveType { get; set; }
        public int LeaveTypeId { get; set; }
        public DateTime DateRequested { get; set; }
        public string RequestComments { get; set; }
        public DateTime? DateActioned { get; set; }
        public bool? Approved { get; set; }
        public bool Cancelled { get; set; }
    }
}