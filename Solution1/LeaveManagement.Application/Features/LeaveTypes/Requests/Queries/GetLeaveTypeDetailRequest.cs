using LeaveManagement.Application.DTOs;
using LeaveManagement.Application.DTOs.LeaveType;
using MediatR;

public class GetLeaveTypeDetailRequest : IRequest<LeaveTypeDTO>
{
    public int Id { get; set; }
}