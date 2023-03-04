using SafetyRequests.Models.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SafetyRequests.Interfaces
{
    public interface IDepartmentRepository
    {
        Task<IEnumerable<Department>> GetAll();
        void Add(Department request);
        Task Update(Guid id);
        Task Delete(Guid id);
    }
}
