using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using LeaveManagement.Application.DTOs;
using LeaveManagement.Application.DTOs.LeaveType;
using LeaveManagement.Application.Persistence.Contracts;
using MediatR;

public class GetLeaveTypeDetailRequestHandler : IRequestHandler<GetLeaveTypeDetailRequest, LeaveTypeDTO>
{
    private readonly ILeaveTypeRepository _repo;
    private readonly IMapper _mapper;
    public GetLeaveTypeDetailRequestHandler(ILeaveTypeRepository repo, IMapper mapper)
    {
        _repo = repo;
        _mapper = mapper;
    }
    public async Task<LeaveTypeDTO> Handle(GetLeaveTypeDetailRequest request, CancellationToken cancellationToken)
    {
        var leaveType = await _repo.Get(request.Id);
        return _mapper.Map<LeaveTypeDTO>(leaveType);
    }
}