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
    public class RoleRepository : IRoleRepository
    {
        protected readonly SafteyRequestsContext Db;
        protected readonly DbSet<EmployeeRole> DbSet;

        public RoleRepository(SafteyRequestsContext context)
        {
            Db = context;
            DbSet = Db.Set<EmployeeRole>();
        }
        public void Add(EmployeeRole request)
        {
            DbSet.Add(request);
        }

        public async Task Delete(Guid id)
        {
            var request = await DbSet.FindAsync(id);
            DbSet.Remove(request);
        }

        public async Task<IEnumerable<EmployeeRole>> GetAll()
        {
            return await DbSet.ToListAsync();
        }

        public async Task Update(Guid id)
        {
            var request = await DbSet.FindAsync(id);
            DbSet.Update(request);
        }
    }
}
