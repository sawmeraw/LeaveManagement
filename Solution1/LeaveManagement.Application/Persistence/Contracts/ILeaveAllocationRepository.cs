using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using LeaveManagement.Application.DTOs.LeaveAllocation;
using LeaveManagement.Domain;

namespace LeaveManagement.Application.Persistence.Contracts
{

    public interface ILeaveAllocationRepository : IGenericRepository<LeaveAllocation>
    {
        Task<LeaveAllocationDTO> GetLeaveAllocationWithDetails(int id);
        Task<List<LeaveAllocationDTO>> GetLeaveAllocationsWithDetails();
    }
}