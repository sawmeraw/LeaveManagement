using System;
using LeaveManagement.Application.DTOs.Common;

public class LeaveAllocationDTO : BaseDTO
{
    public string Name { get; set; }
    public int DefaultDays { get; set; }
}
