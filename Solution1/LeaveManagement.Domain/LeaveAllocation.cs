using System;
using System.Collections.Generic;
using System.Text;

namespace LeaveManagement.Domain
{
    public class LeaveAllocation : BaseDomainEntity
    {
        public int NumberOfDays { get; set; }
        public DateTime DateCreated { get; set; }
        public int LeaveTypeId { get; set; }
        public int Period { get; set; }
    }
}
