using SafetyRequests.Models.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SafetyRequests.Interfaces
{
    public interface IRoleRepository
    {
        Task<IEnumerable<EmployeeRole>> GetAll();
        void Add(EmployeeRole request);
        Task Update(Guid id);
        Task Delete(Guid id);
    }
}
