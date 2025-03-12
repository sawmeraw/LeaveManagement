using System;
using LeaveManagement.Application.DTOs.LeaveAllocation;
using MediatR;

namespace LeaveManagement.Application.Features.LeaveAllocations.Requests.Commands
{

    public class CreateLeaveAllocationCommand : IRequest<int>
    {
        public CreateLeaveAllocationDTO LeaveAllocationDTO { get; set; }
    }
}