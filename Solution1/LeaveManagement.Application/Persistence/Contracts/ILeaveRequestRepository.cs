using System;
using System.Threading.Tasks;
using LeaveManagement.Application.DTOs.LeaveRequest;
using LeaveManagement.Domain;

namespace LeaveManagement.Application.Persistence.Contracts
{
    public interface ILeaveRequestRepository : IGenericRepository<LeaveRequest>
    {
        Task<LeaveRequestDTO> GetLeaveRequestWithDetails(int id);
        Task<LeaveRequestDTO> GetLeaveRequestsWithDetails();
    }
}