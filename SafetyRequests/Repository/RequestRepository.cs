using Microsoft.EntityFrameworkCore;
using SafetyRequests.Interfaces;
using SafetyRequests.Models;
using SafetyRequests.Models.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SafetyRequests.Repository
{
    public class RequestRepository : IRequestRepository
    {
        protected readonly SafteyRequestsContext Db;
        protected readonly DbSet<Request> DbSet;

        public RequestRepository(SafteyRequestsContext context)
        {
            Db = context;
            DbSet = Db.Set<Request>();
        }

        public void Add(Request request)
        {
            DbSet.Add(request);
        }

        public async Task Delete(Guid id)
        {
            var request = await DbSet.FindAsync(id);
            DbSet.Remove(request);
        }

        public async Task<IEnumerable<Request>> GetAll()
        {
            return await DbSet.OrderByDescending(x=>x.CreatedDate).ToListAsync();
        }

        public async Task<Request> GetById(Guid id)
        {
            return await DbSet.FindAsync(id);
        }

        public async Task Update(Guid id)
        {
            var request = await DbSet.FindAsync(id);
            DbSet.Update(request);
        }
    }
}
