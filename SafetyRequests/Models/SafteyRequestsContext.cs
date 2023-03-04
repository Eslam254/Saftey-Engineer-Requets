using Microsoft.EntityFrameworkCore;
using SafetyRequests.Models.DB;
using SafetyRequests.Models.Mappings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SafetyRequests.Models
{
    public class SafteyRequestsContext : DbContext
    {
        public SafteyRequestsContext(DbContextOptions<SafteyRequestsContext> options) : base(options)
        {
        }
        public DbSet<Request> Requests { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<EmployeeRole> EmployeeRoles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new RequestsMapping());
            modelBuilder.ApplyConfiguration(new RolesMapping());
            modelBuilder.ApplyConfiguration(new DeaprtmentMapping());
        }
    }
}
