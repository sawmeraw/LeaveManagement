using System;
using System.Collections.Generic;
using LeaveManagement.Application.DTOs;
using LeaveManagement.Application.DTOs.LeaveType;
using MediatR;

namespace LeaveManagement.Application.Features.LeaveTypes.Requests
{

    public class GetLeaveTypeListRequest : IRequest<List<LeaveTypeDTO>>
    {

    }

}
