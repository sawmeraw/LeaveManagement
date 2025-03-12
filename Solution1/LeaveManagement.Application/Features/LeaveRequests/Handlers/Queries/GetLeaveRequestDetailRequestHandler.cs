using System;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using LeaveManagement.Application.DTOs.LeaveRequest;
using LeaveManagement.Application.Features.LeaveRequests.Requests.Queries;
using LeaveManagement.Application.Persistence.Contracts;
using MediatR;

namespace LeaveManagement.Application.Features.LeaveRequests.Handlers.Queries
{
    public class GetLeaveRequestDetailRequestHandler : IRequestHandler<GetLeaveRequestDetailRequest, LeaveRequestDTO>
    {
        private readonly IMapper _mapper;
        private readonly ILeaveRequestRepository _repo;
        public GetLeaveRequestDetailRequestHandler(ILeaveRequestRepository repo, IMapper mapper)
        {
            _mapper = mapper;
            _repo = repo;
        }

        public async Task<LeaveRequestDTO> Handle(GetLeaveRequestDetailRequest request, CancellationToken cancellationToken)
        {
            var leaveRequest = await _repo.Get(request.Id);
            return _mapper.Map<LeaveRequestDTO>(leaveRequest);
        }
    }
}