using SafetyRequests.Models.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SafetyRequests.Interfaces
{
    public interface IRequestRepository
    {
        Task<IEnumerable<Request>> GetAll();
        void Add(Request request);
        Task Update(Guid id);
        Task Delete(Guid id);
        Task<Request> GetById(Guid id);
    }
}
