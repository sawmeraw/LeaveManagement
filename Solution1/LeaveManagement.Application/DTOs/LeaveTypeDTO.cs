using System;
using LeaveManagement.Application.DTOs.Common;

namespace LeaveManagement.Application.DTOs
{

    public class LeaveTypeDTO : BaseDTO
    {
        public string Name { get; set; }
        public int DefaultDays { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
