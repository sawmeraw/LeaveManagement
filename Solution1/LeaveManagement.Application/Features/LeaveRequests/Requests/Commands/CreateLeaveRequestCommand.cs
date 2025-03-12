using System;
using LeaveManagement.Application.DTOs.LeaveRequest;
using MediatR;

namespace LeaveManagement.Application.Features.LeaveRequests.Requests.Commands
{

    public class CreateLeaveRequestCommand : IRequest<int>
    {
        public LeaveRequestDTO LeaveRequestDTO { get; set; }
    }
}