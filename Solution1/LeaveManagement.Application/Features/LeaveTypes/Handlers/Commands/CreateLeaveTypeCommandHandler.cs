using System;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using LeaveManagement.Application.Features.LeaveTypes.Requests.Commands;
using LeaveManagement.Application.Persistence.Contracts;
using LeaveManagement.Domain;
using MediatR;

namespace LeaveManagement.Application.Features.LeaveTypes.Handlers.Commands
{

    public class CreateLeaveTypeRequestHandler : IRequestHandler<CreateLeaveTypeCommand, int>
    {
        private readonly ILeaveTypeRepository _repo;
        private readonly IMapper _mapper;
        public CreateLeaveTypeRequestHandler(IMapper mapper, ILeaveTypeRepository repo)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public async Task<int> Handle(CreateLeaveTypeCommand request, CancellationToken cancellationToken)
        {
            var leaveType = _mapper.Map<LeaveType>(request.CreateLeaveTypeDTO);

            leaveType = await _repo.Add(leaveType);
            return leaveType.Id;
        }
    }
}